using System;
using System.IO;
using System.Security.Cryptography;
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

                    //DataBase dosyasındaki her bir null olmayan satırı gezer
                    // DataBase dosyasındaki satırın null olması dosyanın sonunda olduğu anlamına gelir
                    while ((satir = sr.ReadLine()) != null)
                    {
                        //DataBase dosyasındaki satırda kiralama tarihi alınır
                        DateTime tarih = Convert.ToDateTime(satir.Substring(satir.IndexOf('+')+1, 10));
                        //[string].SubString(req int startIndex, int length) methodu bir metin içindeki bir kesiti alır
                        // Tavsiye edilen kullanımı: 2 parametre (başlangıç indisi) ile (uzunluk değeri) kullanımıdır
                        //[string].IndexOf() methodu bir metin içerisinde parametre ile istenen karakteri bularak metin içerisindeki indisini döndürür.


                        //Kştap kiralandıktan sonra kaç gün geçmiş hesabı yapılır
                        TimeSpan kiraGunSayisi = tarih - Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                        double fark = Math.Abs(Convert.ToInt32(kiraGunSayisi.TotalDays));

                        //ceza hesabı ilk 15 günden sonra yapılır
                        if (fark>15)
                        {
                            //kitap 15 gün ile 45 gün arasında teslim edilmemişse ₺15 ceza tutarı
                            if (fark > 15 && fark < 45) { cezaTutari = 15; }

                            //kitap 45 günden fazla teslim edilmemişse 45 günden sonraki her gün için ₺1(yalnız bir Türk Lirası) cezai işlem uygulanır
                            else { cezaTutari = 15 + (fark - 45); }

                            //cezaya düşen kitap kiraları listBox2 adındaki listeye yazdırılır
                            listBox2.Items.Add($"!! {satir}\t\tCeza Tutarı:₺{cezaTutari}");
                        }
                        
                        satir = satir.Replace('+',' ');
                        listBox1.Items.Add(satir);
                    }
                }
            }
            //dosya okumada veya veri çekerken oluşabilecek hataları yönetebilmek için catch bloğu kullanılabilir
            catch (Exception ex)
            {
            }
        }

        private void btnRentABook_Click(object sender, EventArgs e)
        {
            //data değişkeni Arayüzden alınan [Kullanıcı Adı], [Kitap Adı] ve [Kitabın kiralandığı tarih(gün/ay/yıl)] verilerini tutar.
            string data = $"{tbxUserName.Text}\t\t{tbxBookName.Text}\t\t+{kiraTarihi.Value.ToString("dd/MM/yyyy")}";

            try
            {
                //StreamWriter ile DataBase dosyası açılır 
                using (StreamWriter sw = new StreamWriter(path:dosyaYolu,append:true))
                {
                    //data DataBase e gönderilir
                    sw.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
            }

            //Veri Kaydı yapıldıktan sonra Tablolar güncellenir
            loadLogs();
        }
    }

}
