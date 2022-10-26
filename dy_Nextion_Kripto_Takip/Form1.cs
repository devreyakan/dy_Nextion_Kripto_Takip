using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Windows.Forms;

namespace dy_Nextion_Kripto_Takip
{
    public partial class Form1 : Form
    {
        public static SerialPort port;
        delegate void SetTextCallback(string text);
        private BackgroundWorker hardWorker;
        //private Thread readThread = null;
        byte[] bitiris = new byte[] { 0xff, 0xff, 0xff };


        public Form1()
        {
            InitializeComponent();

            hardWorker = new BackgroundWorker();
            gonder_Buton.Enabled = false;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


            IContainer components = new Container();
            port = new SerialPort(components);
            port.PortName = comPort.SelectedItem.ToString();
            port.BaudRate = Int32.Parse(baudRate.SelectedItem.ToString());
            port.DtrEnable = true;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 500;
            //port.DataBits = 8;
            port.Open();

            //readThread = new Thread(new ThreadStart(this.Read));
            //readThread.Start();
            this.hardWorker.RunWorkerAsync();

            baglan_Buton.Text = "<Bağlandı>";

            baglan_Buton.Enabled = false;
            comPort.Enabled = false;
            gonder_Buton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comPort.Items.Add(s);
            }
            comPort.SelectedIndex = 0;

            baudRate.Items.Add("9600");
            // daha fazla baud rate eklenebilir.

            baudRate.SelectedIndex = 0;
        }


        /* NIST Tarih
        public string nist_tarih()
        {

            var client = new TcpClient("time.nist.gov", 13);
            using (var streamReader = new StreamReader(client.GetStream()))
            {
                var response = streamReader.ReadToEnd();
                var utcDateTimeString = response.Substring(7, 17);
                var localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                return localDateTime.ToString();
            }
        }
        */

        /* Google Tarih
        public string google_tarih()
        {

            var httpWebGoogle = (HttpWebRequest)WebRequest.Create("http://google.com");
            var cevap = httpWebGoogle.GetResponse();
            string bugunTarih = cevap.Headers["date"];
            return DateTime.ParseExact(bugunTarih, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal).ToString();


        }
        */

        /* BTC Blockchain Veri Çekme
        static class BTC_Blockchain
        {
            static WebClient wb = new WebClient();
            //static WebClient.CachePolicy = new System.Net.Cache.RequestCachePolicy(RequestCacheLevel.NoCacheNoStore); 
            public static string sjveri = wb.DownloadString("https://api.blockchain.com/v3/exchange/tickers/BTC-USD" + "?nocache=" + DateTime.Now.Ticks.ToString());
            static JObject json = JObject.Parse(sjveri);
            public static string symbol = json["symbol"].ToString();
            public static string price_24h = json["price_24h"].ToString();
            public static string volume_24h = json["volume_24h"].ToString();
            public static string last_trade_price = json["last_trade_price"].ToString();
        }
        
         */


        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {

                WebClient webClient = new WebClient();
                webClient.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                string sjveri = webClient.DownloadString("https://api.blockchain.com/v3/exchange/tickers/BTC-USD" + "?nocache=" + DateTime.Now.Ticks.ToString());
                JObject json = JObject.Parse(sjveri);
                string symbol = json["symbol"].ToString();
                string price_24h = json["price_24h"].ToString();
                string volume_24h = json["volume_24h"].ToString();
                string last_trade_price = json["last_trade_price"].ToString();


                var pc_tarihi = DateTime.Now;

                string t_fiyat = "t_fiyat.txt=" + '\u0022' + '\u0024' + last_trade_price.Substring(0, last_trade_price.IndexOf(".")) + '\u0022';
                byte[] t_fiyat_byte = Encoding.ASCII.GetBytes(t_fiyat);

                string tarih = "t_tarih.txt=" + '\u0022' + pc_tarihi + '\u0022';
                byte[] tarih_byte = Encoding.ASCII.GetBytes(tarih);

                string fiyat_24 = "t_fiyat_24.txt=" + '\u0022' + "Fiyat(24H): " + '\u0024' + price_24h.Substring(0, price_24h.IndexOf(".")) + '\u0022';
                byte[] fiyat_24_byte = Encoding.ASCII.GetBytes(fiyat_24);

                string hacim = "t_hacim.txt=" + '\u0022' + "Hacim(24H): $" + volume_24h.Substring(0, 5) + "M" + '\u0022';
                byte[] hacim_byte = Encoding.ASCII.GetBytes(hacim);

                byte[] durum_bildirimi = Encoding.ASCII.GetBytes("cirs 320,240,11,GREEN");

                byte[] birlestirilmis = t_fiyat_byte.Concat(bitiris).Concat(tarih_byte).Concat(bitiris).Concat(hacim_byte).Concat(bitiris).Concat(durum_bildirimi).Concat(bitiris).Concat(fiyat_24_byte).Concat(bitiris).ToArray();

                Debug.WriteLine("\nBirlestirilmis: " + BitConverter.ToString(birlestirilmis).Replace("-", " ") + "\nTarih: " + pc_tarihi);

                port.Write(birlestirilmis, 0, birlestirilmis.Length);



            }

            catch (WebException web_hata)
            {

                Debug.Write("Hata: " + web_hata.ToString());

                string hata_1 = "t_hacim.txt=" + '\u0022' + '\u0022';
                byte[] hata_1_byte = Encoding.ASCII.GetBytes(hata_1);

                byte[] durum_bildirimi = Encoding.ASCII.GetBytes("cirs 320,240,11,RED");

                string veri_hatasi = "t_fiyat.txt=" + '\u0022' + "Hata 1" + '\u0022';
                byte[] veri_hatasi_byte = Encoding.ASCII.GetBytes(veri_hatasi);

                byte[] hata_birlestir = hata_1_byte.Concat(bitiris).Concat(durum_bildirimi).Concat(bitiris).Concat(veri_hatasi_byte).Concat(bitiris).ToArray();
                port.Write(hata_birlestir, 0, hata_birlestir.Length);
            }


            catch (IOException port_hata)
            {
                Debug.Write("Hata: " + port_hata.ToString());

            }

            catch
            {

            }

        }
        bool timerkontrol = false;
        System.Timers.Timer timer1 = new System.Timers.Timer();
        private void sendBtn_Click(object sender, EventArgs e)
        {


            if (port.IsOpen)
            {
                byte[] bitcoin_sayfasi = Encoding.ASCII.GetBytes("page 0");
                byte[] sayfa_degistir = bitcoin_sayfasi.Concat(bitiris).ToArray();
                port.Write(sayfa_degistir, 0, sayfa_degistir.Length);

                if (timerkontrol == false)
                {
                    timer1.Interval = 1000;
                    timer1.Elapsed += timer_Elapsed;
                    timer1.Start();
                    timerkontrol = true;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //readThread.Abort();

            //formdan cikinca sayfayi "cevrimdisi" sayfasina almak icin
            byte[] cikis_sayfasi = Encoding.ASCII.GetBytes("page 1");
            byte[] hata_birlestir = cikis_sayfasi.Concat(bitiris).ToArray();
            port.Write(hata_birlestir, 0, hata_birlestir.Length);

            System.Threading.Thread.Sleep(50);
            port.Close();
        }

        /* Okuma işlemleri gerekirse
        private void SetText(string text)
        {

            if (this.receiveText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.receiveText.Text += text;
                this.receiveText.Text += "\n";
            }
        }

        public void Read()
        {
            while (port.IsOpen)
            {
                try
                {
                    string message = port.ReadLine();
                    this.SetText(message);
                }
                catch (TimeoutException) { }
            }
        }
        */
        /* binarybirleştirme
        public static void ikilibinarybirlestirme()
        {


            byte[] ilk = new byte[] { 0xff, 0xff, 0xff };
            byte[] ikinci = new byte[] { 0xff, 0xff, 0xff };
            byte[] birlesmis = new byte[ikinci.Length + ilk.Length];

            for (int i = 0; i < birlesmis.Length; ++i)
            {
                birlesmis[i] = i < ikinci.Length ? ikinci[i] : ilk[i - ikinci.Length];
            }
        }
        */

    }
}
