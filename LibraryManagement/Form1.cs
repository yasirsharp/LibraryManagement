using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        string dosyaYolu = "deneme.txt";
        double cezaTutari;

        KiraBilgisi[] kiraBilgisis = { new KiraBilgisi{} };

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadLogs();
        }

        private void loadLogs()
        {
            listBox1.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;
                    Console.WriteLine("Kaydedilen veriler:");
                    while ((satir = sr.ReadLine()) != null)
                    {
                        DateTime tarih = Convert.ToDateTime(satir.Substring(satir.IndexOf('+')+1, 10));
                        TimeSpan kiraGunSayisi = tarih - Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                        double fark = Math.Abs(Convert.ToInt32(kiraGunSayisi.TotalDays));
                        if (fark>15)
                        {
                            if (fark > 15 && fark < 45) { cezaTutari = 15; }
                            else { cezaTutari = 15 + (fark - 45); }
                            listBox2.Items.Add($"!! {satir}\t\tCeza Tutarı:₺{cezaTutari}");
                        }
                        label4.Text = fark.ToString();
                        satir = satir.Replace('+',' ');
                        listBox1.Items.Add(satir);
                    }
                }
            }
            catch (Exception ex)
            {
                label4.Text = "Bir hata oluştu: " + ex.Message;
            }
        }

        private void btnRentABook_Click(object sender, EventArgs e)
        {
            string data = $"{tbxUserName.Text}\t\t{tbxBookName.Text}\t\t+{kiraTarihi.Value.ToString("dd/MM/yyyy")}";
            try
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu,append:true))
                {
                    sw.WriteLine(data);
                }
                label4.Text="Veri başarıyla kaydedildi.";
            }
            catch (Exception ex)
            {
                label4.Text = "Bir hata oluştu: " + ex.Message;
            }
            loadLogs();
        }
    }

    class KiraBilgisi
    {
        public KiraBilgisi()
        {
            
        }
        public string userName { get; set; }
        public string bookName { get; set; }
        public DateTime kiraTarihi { get; set; }
    }

}
