using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMTurkey_TWRP_DownLoader
{
    public partial class Form1 : Form
    {
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        string appPath = Application.StartupPath + "\\";
        public Form1()
        {
            InitializeComponent();
        }
        private void aramayap()
        {
            baglantim.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = textBox1.Text;
            cumle = "Select * from twrp where marka_model like '%" + textBox1.Text + "%'";
            OleDbDataAdapter adptr = new OleDbDataAdapter(cumle, baglantim);
            adptr.Fill(tbl);
            baglantim.Close();
            data.DataSource = tbl;
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");

        private void comboboxaAktar()
        {
            string yazi = "";
            for (int i = 0; i <= data.RowCount - 2; i++)
            {
                yazi = "";
                for (int j = 0; j <= data.ColumnCount - 1; j++)
                {
                    if (j == 0)
                    {
                        yazi = yazi + data.Rows[i].Cells[j].Value.ToString();

                    }
                    else
                    {
                        //    yazi = yazi + "x" + dataGridView1.Rows[0].Cells[0].Value.ToString();
                    }
                }
                combo_MarkaModel.Items.Add(yazi);

            }
        }

        private void kayitlariListele()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from twrp", baglantim);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                data.DataSource = dshafiza.Tables[0];
                baglantim.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata.Message);
            }
        }
        private void kryptonPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void deneme_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

        }

        private static void Completed(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kayitlariListele();
            comboboxaAktar();
           baglantim.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = textBox1.Text;
            cumle = "Select * from twrp where marka_model like '%" + textBox1.Text + "%'";
            OleDbDataAdapter adptr = new OleDbDataAdapter(cumle, baglantim);
            adptr.Fill(tbl);
            baglantim.Close();
            data.DataSource = tbl;
        }

        private void button6_Click(object sender, EventArgs e)

        { 
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Btn_Install_Click(object sender, EventArgs e)
        {
           
        }

        private void Combo_MarkaModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = combo_MarkaModel.SelectedItem.ToString();
            aramayap();
            lbl_Link.Text = data.Rows[0].Cells[2].Value.ToString();

            combo_Sunucu.Items.Clear();

            combo_Surum.Items.Clear();

            combo_Surum.Items.Add(data.Rows[0].Cells[1].Value.ToString());
            combo_Sunucu.Items.Add(data.Rows[0].Cells[3].Value.ToString());
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
        private void yuzde(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            in1 = e.BytesReceived/10000;//çekilen byte.
            in2 = e.TotalBytesToReceive/1000000;
            in3 = e.ProgressPercentage;
            btn_Download.Text = "İndirme İşlemini Devam Ediyor" + " %" + in3.ToString(); 
            label2.Text = "Anlık İndirilen Veri : " + in1.ToString() + " KB";
            label1.Text = "Toplam Dosya Boyutu : " + in2.ToString() + " MB"; // Dosyanın toplam boyutu.
        }
        private void veritabanitamamlandi(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                MessageBox.Show("Veritabanınız başarılı bir şekilde güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = "Toplam Dosya Boyutu : 0 MB";
                label2.Text = "Anlık İndirilen Veri : 0 KB";
                btn_Download.Text = "İndirme İşlemini Başlat";
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);
                progressBar.Value = 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                label1.Text = "Toplam Dosya Boyutu : 0 MB";
                label2.Text = "Anlık İndirilen Veri : 0 KB";
                btn_Download.Text = "İndirme İşlemini Başlat";
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);
                progressBar.Value = 10;
            }
        }
        private void tamamlandi(object sender, AsyncCompletedEventArgs e)
        {

            string masaustu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show("Dosyanız başarılı bir şekilde indirildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            try
            {
                
                File.Copy(appPath + data.Rows[0].Cells[0].Value.ToString() + " TWRP.img", masaustu + "\\" + data.Rows[0].Cells[0].Value.ToString() + " TWRP.img");

            }
            catch (Exception et)
            {
                MessageBox.Show(" Masaüstünde" + et.Message.ToString() + "Uygulama klasörü açılıyor oradan alabilirsiniz.","Dosya Zaten Var",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            label1.Text = "Toplam Dosya Boyutu : 0 MB";
            label2.Text = "Anlık İndirilen Veri : 0 KB";
            btn_Download.Text = "İndirme İşlemini Başlat";
            progressBar.ProgressColor = Color.FromArgb(79, 186, 111);
            progressBar.Value =10;



        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {

        }
        long in1, in2 ,in3;

        private void Label3_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value == 10)
            {
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);
            }
            if (progressBar.Value == 15)
            {
                progressBar.ProgressColor = Color.FromArgb(194, 140, 50);

            }
            else if (progressBar.Value == 30)
            {
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);

            }
            else if (progressBar.Value == 45)
            {
                progressBar.ProgressColor = Color.FromArgb(194, 140, 50);

            }
            else if (progressBar.Value == 60)
            {
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);

            }
            else if (progressBar.Value == 72)
            {
                progressBar.ProgressColor = Color.FromArgb(194, 140, 50);

            }
            else if (progressBar.Value == 80)
            {
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);

            }
            else if (progressBar.Value == 90)
            {
                progressBar.ProgressColor = Color.FromArgb(194, 140, 50);

            }
            else if (progressBar.Value == 100)
            {
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);

            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gsmturkey.net");
            MessageBox.Show("Beta versiyonunda şu anlık elle güncelleme denetlemek durumundasınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
                    

                Timer tm = new Timer();

                string indirURL = "https://github.com/barismizrakli/TWRPDownLoader/raw/master/data.accdb";
                string klasor = appPath;
                string dsyadi = "data.accdb";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(veritabanitamamlandi);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(yuzde);
                webClient.DownloadFileAsync(new Uri(indirURL), klasor + dsyadi);
                tm.Interval = 1000;
                tm.Tick += new EventHandler(tm_Tick);
                tm.Start();
                Console.ReadLine();
                tm.Stop();

                label1.Text = "Toplam Dosya Boyutu : 0 MB";
                label2.Text = "Anlık İndirilen Veri : 0 MB";
                btn_Download.Text = "İndirme İşlemini Başlat";

                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);
                progressBar.Value = 10;
                tm.Stop();
         
        }

        private void combo_Sunucu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Sunucu.SelectedItem.ToString() == "TeamWin")
            {
                label4.Text = "Statü : OFFICIAL";
            }
            else
            {
                label4.Text = "Statü : Derleme-Port";
            }
        }

        private void Btn_Download_Click_1(object sender, EventArgs e)
        {
            try
            {
                Timer tm = new Timer();

                string indirURL = lbl_Link.Text;
                string klasor = appPath;
                string dsyadi = data.Rows[0].Cells[0].Value.ToString() + " TWRP.img";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(tamamlandi);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(yuzde);
                webClient.DownloadFileAsync(new Uri(indirURL), klasor + dsyadi);
                tm.Interval = 1000;
                tm.Tick += new EventHandler(tm_Tick);
                tm.Start();
                Console.ReadLine();
                tm.Stop();

                label1.Text = "Toplam Dosya Boyutu : 0 MB";
                label2.Text = "Anlık İndirilen Veri : 0 MB";
                btn_Download.Text = "İndirme İşlemini Başlat";
                progressBar.ProgressColor = Color.FromArgb(79, 186, 111);
                progressBar.Value = 10;

                tm.Stop();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Geçersiz URI: URI biçimi belirlenemedi.")
                {
                    MessageBox.Show("Lütfen bir cihaz seçimi yapınız.","Seçim Yapılmadı",MessageBoxButtons.OK,MessageBoxIcon.Error );
                }
            }
        }
        void tm_Tick(object sender, EventArgs e)
        {

                }
    }
}

