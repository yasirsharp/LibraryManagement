using System;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        // verilerin kayıt edileceği dosyanın yolunu ekliyorum
        // LibraryManagement proje klasörü içerisinde .sln dosyasının yanına DataBase.txt dosyasına verilerimizi kaydediyoruz.
        string dosyaYolu = "../../../DataBase.txt";


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1 yüklendiği anda loadLogs methodu çağırıyorum
            // Bu method veritabanı dosyasını okur
            // dosyada veri var ise listeler
            loadLogs();
        }

        private void loadLogs()
        {

            /*
            
                Algoritma 
                - Dosya açılır
                - Dosyanın Her bir satırı okunur.
                - Okunan satır içerisinde standart olarak belirlenmiş tarih verisinin olduğu kısım alınır.
                - Kitabın kiralandığı günden itibaren geçen gün sayısı hesaplanır.
                - kitap kiralandığı günden itibaren 15 günden fazla 45 günden az olmuş ise ₺15 ceza uygulanır.
                - Kitap kiralandıktan sonra 45 günden daha fazla sürede teslim edilmediyse, 15TL ye ek olarak 45 günden sonraki her gün için 1 lira daha ceza yaılacak
                - Ceza alan kişiler listBox2 adındaki listeye eklenecek 
                - Ceza alsa da almasa da okunan satır listBox1 adındaki listeye eklenecek

             */
            //başlangıçta listbox lar içerisinde bellekte kalan veri var ise bunlar temizlenir
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            
            double cezaTutari;

            //try - catch bloğu Hata yönetimi için kullanılan bloktur
            // bu projede try - catch bloğu dosya okumada veya veri çekerken oluşabilecek hataları yönetebilmek için kullanılmıştır
            try
            {

                // using yapısı garbage collector gibi çalışır
                // Kullanılan nesne ile blok bittikten sonra bellekten silinerek bellek tasarrufu sağlanır
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;

                    // DataBase dosyasındaki satırlar dolaşılır satırın null olması dosyanın sonunda olduğu anlamına gelir
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

}
