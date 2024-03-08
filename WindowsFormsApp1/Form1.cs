using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string[]> randevular = new List<string[]>();
        private HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            listViewRandevular.Columns.Add("Çağrı Tarihi", 100);
            listViewRandevular.Columns.Add("Gsm", 120);
            listViewRandevular.Columns.Add("Kurslar", 50);
            listViewRandevular.Columns.Add("Hocalar", 50);
            listViewRandevular.Columns.Add("Randevu Tarihi", 100);
            listViewRandevular.Columns.Add("Amo Linki", 300);
            listViewRandevular.Columns.Add("Randevu Durumu", 50);
            listViewRandevular.Columns.Add("İsim Soyisim", 100);
            listViewRandevular.Columns.Add("Data", 30);



        }

        private async Task serviceRequestAsync()
        {
            var values = new Dictionary<string, string>
            {
                { "param1", "value1" },
                { "param2", "value2" },
               
            };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://ogubenn.com.tr/meeting.php?action=viewMeeting", content);
            var responseString = await response.Content.ReadAsStringAsync();
            // responseString içindeki verileri işleyebilirsiniz
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            string[] randevu = new string[9];
            randevu[0] = dateTimePickerCagriTarihi.Value.ToShortDateString();
            randevu[1] = txtGsm.Text;
            randevu[2] = GetSecilenKurslar();
            randevu[3] = GetSecilenHocalar();
            randevu[4] = dateTimePickerRandevuTarihi.Value.ToShortDateString();
            randevu[5] = txtAmoLinki.Text;
            randevu[6] = GetRandevuDurumu();
            randevu[7] = comboBox2.SelectedItem.ToString();
            randevu[8] = comboBox1.SelectedItem.ToString();

            randevular.Add(randevu);
            string url = string.Format("https://ogubenn.com.tr/meeting.php?action=addMeeting&phone={0}&course={1}&teacher={2}&name_surname={3}&meet_date={4}&ammo_link={5}&meet_case={6}&data={7}", randevu[1], randevu[2], randevu[3],randevu[7],randevu[4],randevu[5],randevu[6],randevu[8]);
            new WebClient().DownloadString(url);

            ListViewItem item = new ListViewItem(randevu);
            listViewRandevular.Items.Add(item);

            MessageBox.Show("Randevu başarıyla kaydedildi.");

            await serviceRequestAsync();
        }

        private string GetSecilenKurslar()
        {
            List<string> secilenKurslar = new List<string>();
            if (chkKurs_Python.Checked)
                secilenKurslar.Add("Python");
            if (chkKurs_Scratch.Checked)
                secilenKurslar.Add("Scratch");
            if (chkKurs_KodlamaSovalyesi.Checked)
                secilenKurslar.Add("Kodlama Şövalyesi");
            if (chkKurs_Roblox.Checked)
                secilenKurslar.Add("Roblox");
            return string.Join(", ", secilenKurslar);
        }

        private string GetSecilenHocalar()
        {
            List<string> secilenHocalar = new List<string>();
            if (chkHoca_Ece.Checked)
                secilenHocalar.Add("Ece");
            if (chkHoca_Leyla.Checked)
                secilenHocalar.Add("Leyla");
            if (chkHoca_Mustafa.Checked)
                secilenHocalar.Add("Mustafa");
            if (chkHoca_Ozge.Checked)
                secilenHocalar.Add("Özge");
            return string.Join(", ", secilenHocalar);
        }

        private string GetRandevuDurumu()
        {
            if (chkRandevuAlindi.Checked)
                return "Randevu Alındı";
            else if (chkRandevuIptal.Checked)
                return "Randevu İptal";
            else if (chkRandevuGirdi.Checked)
                return "Randevuya Girdi";
            else
                return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Seçiniz"); 
            comboBox2.Items.Add("Seçiniz");

            
            comboBox1.Items.Add("Ulaşılamadı");
            comboBox1.Items.Add("Eski Veriler");
            comboBox1.Items.Add("Yaz Dönemi");
            comboBox1.Items.Add("Eski Veriler 2");
            comboBox1.Items.Add("Online/Ertelenen");
            comboBox1.Items.Add("İzmir/Ertelenen");
            comboBox1.Items.Add("Ankara/Ertelenen");
            comboBox1.Items.Add("Antalya/Ertelenen");


            comboBox2.Items.Add("Oğulcan Durkan");
            comboBox2.Items.Add("Fatma Erkek");
            comboBox2.Items.Add("Bilge Özdemir");
            comboBox2.Items.Add("Elvan Dalgıç");
            comboBox2.Items.Add("Lale Akyüz");
            comboBox2.Items.Add("Songül Ölmez");
            comboBox2.Items.Add("Ceyda Günden");
            comboBox2.Items.Add("Merve Günay");
            comboBox2.Items.Add("Figen Karaman");
            comboBox2.Items.Add("Yunus Emre");
            comboBox2.Items.Add("Zeynep Karacık");
            comboBox2.Items.Add("Damla Turan");

            
            comboBox1.SelectedIndex = 0; 
            comboBox2.SelectedIndex = 0;
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Tıklanan linkin URL'sini al
            string url = "https://ogubenn.com.tr/";

            // URL'yi varsayılan web tarayıcısında aç
            System.Diagnostics.Process.Start(url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Tıklanan linkin URL'sini al
            string url = "https://ogubenn.com.tr/meeting.php?action=viewMeeting";

            // URL'yi varsayılan web tarayıcısında aç
            System.Diagnostics.Process.Start(url);
        }
    }
}
