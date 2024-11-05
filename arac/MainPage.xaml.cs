using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace arac
{
    public partial class MainPage : ContentPage
    {
        // Araç bilgilerini saklayacağımız liste
        List<Arac> araclar = new List<Arac>
{
    new Arac { Marka = "Toyota", Model = "Corolla", Yil = 2020, SehirIciTuketim = 7.5, SehirDisiTuketim = 5.0 },
    new Arac { Marka = "Toyota", Model = "Camry", Yil = 2021, SehirIciTuketim = 7.8, SehirDisiTuketim = 5.2 },
    new Arac { Marka = "Toyota", Model = "Yaris", Yil = 2019, SehirIciTuketim = 6.5, SehirDisiTuketim = 4.8 },
    new Arac { Marka = "Honda", Model = "Civic", Yil = 2019, SehirIciTuketim = 8.0, SehirDisiTuketim = 5.5 },
    new Arac { Marka = "Honda", Model = "Accord", Yil = 2020, SehirIciTuketim = 8.2, SehirDisiTuketim = 5.7 },
    new Arac { Marka = "Honda", Model = "Fit", Yil = 2018, SehirIciTuketim = 6.7, SehirDisiTuketim = 4.9 },
    new Arac { Marka = "BMW", Model = "3 Series", Yil = 2021, SehirIciTuketim = 9.0, SehirDisiTuketim = 6.5 },
    new Arac { Marka = "BMW", Model = "5 Series", Yil = 2020, SehirIciTuketim = 9.3, SehirDisiTuketim = 6.8 },
    new Arac { Marka = "BMW", Model = "X5", Yil = 2022, SehirIciTuketim = 11.2, SehirDisiTuketim = 8.0 },
    new Arac { Marka = "Ford", Model = "Focus", Yil = 2019, SehirIciTuketim = 7.1, SehirDisiTuketim = 5.4 },
    new Arac { Marka = "Ford", Model = "Fiesta", Yil = 2018, SehirIciTuketim = 6.9, SehirDisiTuketim = 5.2 },
    new Arac { Marka = "Ford", Model = "Mustang", Yil = 2021, SehirIciTuketim = 12.5, SehirDisiTuketim = 9.2 },
    new Arac { Marka = "Mercedes", Model = "C-Class", Yil = 2020, SehirIciTuketim = 9.5, SehirDisiTuketim = 7.0 },
    new Arac { Marka = "Mercedes", Model = "E-Class", Yil = 2021, SehirIciTuketim = 10.0, SehirDisiTuketim = 7.5 },
    new Arac { Marka = "Mercedes", Model = "S-Class", Yil = 2022, SehirIciTuketim = 11.8, SehirDisiTuketim = 8.5 },
    new Arac { Marka = "Audi", Model = "A3", Yil = 2019, SehirIciTuketim = 7.6, SehirDisiTuketim = 5.5 },
    new Arac { Marka = "Audi", Model = "A4", Yil = 2020, SehirIciTuketim = 8.0, SehirDisiTuketim = 5.8 },
    new Arac { Marka = "Audi", Model = "Q5", Yil = 2021, SehirIciTuketim = 9.8, SehirDisiTuketim = 7.2 },
    new Arac { Marka = "Hyundai", Model = "Elantra", Yil = 2019, SehirIciTuketim = 7.4, SehirDisiTuketim = 5.3 },
    new Arac { Marka = "Hyundai", Model = "Tucson", Yil = 2020, SehirIciTuketim = 8.1, SehirDisiTuketim = 6.0 },
    new Arac { Marka = "Hyundai", Model = "Santa Fe", Yil = 2021, SehirIciTuketim = 8.7, SehirDisiTuketim = 6.5 },
    new Arac { Marka = "Kia", Model = "Rio", Yil = 2018, SehirIciTuketim = 6.8, SehirDisiTuketim = 5.0 },
    new Arac { Marka = "Kia", Model = "Sorento", Yil = 2021, SehirIciTuketim = 8.9, SehirDisiTuketim = 6.8 },
    new Arac { Marka = "Kia", Model = "Sportage", Yil = 2020, SehirIciTuketim = 8.5, SehirDisiTuketim = 6.2 },

    // Diğer araçlar
    new Arac { Marka = "Toyota", Model = "Highlander", Yil = 2021, SehirIciTuketim = 9.0, SehirDisiTuketim = 6.5 },
    new Arac { Marka = "Toyota", Model = "Prius", Yil = 2019, SehirIciTuketim = 4.4, SehirDisiTuketim = 3.8 },
    new Arac { Marka = "Honda", Model = "HR-V", Yil = 2020, SehirIciTuketim = 7.7, SehirDisiTuketim = 5.9 },
    new Arac { Marka = "Honda", Model = "CR-V", Yil = 2021, SehirIciTuketim = 8.3, SehirDisiTuketim = 6.1 },
    new Arac { Marka = "BMW", Model = "X3", Yil = 2021, SehirIciTuketim = 10.1, SehirDisiTuketim = 7.8 },
    new Arac { Marka = "BMW", Model = "X7", Yil = 2020, SehirIciTuketim = 12.1, SehirDisiTuketim = 8.9 },
    new Arac { Marka = "Ford", Model = "Escape", Yil = 2021, SehirIciTuketim = 7.9, SehirDisiTuketim = 6.1 },
    new Arac { Marka = "Ford", Model = "Explorer", Yil = 2020, SehirIciTuketim = 10.5, SehirDisiTuketim = 8.0 },
    new Arac { Marka = "Mercedes", Model = "GLA", Yil = 2021, SehirIciTuketim = 9.0, SehirDisiTuketim = 6.7 },
    new Arac { Marka = "Mercedes", Model = "GLE", Yil = 2020, SehirIciTuketim = 10.8, SehirDisiTuketim = 7.9 },
    new Arac { Marka = "Audi", Model = "Q7", Yil = 2020, SehirIciTuketim = 11.5, SehirDisiTuketim = 8.2 },
    new Arac { Marka = "Audi", Model = "A6", Yil = 2021, SehirIciTuketim = 8.5, SehirDisiTuketim = 6.2 },
    new Arac { Marka = "Hyundai", Model = "Kona", Yil = 2019, SehirIciTuketim = 7.2, SehirDisiTuketim = 5.4 },
    new Arac { Marka = "Hyundai", Model = "Sonata", Yil = 2020, SehirIciTuketim = 7.8, SehirDisiTuketim = 5.7 },
    new Arac { Marka = "Kia", Model = "Stinger", Yil = 2021, SehirIciTuketim = 10.5, SehirDisiTuketim = 7.2 },
    new Arac { Marka = "Kia", Model = "Forte", Yil = 2020, SehirIciTuketim = 7.6, SehirDisiTuketim = 5.4 },
    new Arac { Marka = "Ford", Model = "Edge", Yil = 2021, SehirIciTuketim = 9.1, SehirDisiTuketim = 6.8 },
    new Arac { Marka = "Ford", Model = "Bronco", Yil = 2022, SehirIciTuketim = 11.7, SehirDisiTuketim = 9.3 },
    new Arac { Marka = "BMW", Model = "Z4", Yil = 2021, SehirIciTuketim = 10.2, SehirDisiTuketim = 7.9 },
    new Arac { Marka = "Mercedes", Model = "GLC", Yil = 2021, SehirIciTuketim = 9.5, SehirDisiTuketim = 7.0 },

    // Devamı ile toplamda 100 araç bilgisi
    // Aynı yapıyı tekrar ederek araçları çoğaltabilirsiniz.
};

        public MainPage()
        {
            InitializeComponent();

            // Marka Picker'ı doldur
            foreach (var arac in araclar)
            {
                if (!MarkaPicker.Items.Contains(arac.Marka))
                    MarkaPicker.Items.Add(arac.Marka);
            }
        }

        // Marka seçildiğinde modellere göre filtreleme
        void MarkaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelPicker.Items.Clear();
            var selectedMarka = MarkaPicker.SelectedItem?.ToString();
            if (selectedMarka == null) return;

            var filteredModels = araclar.FindAll(a => a.Marka == selectedMarka);

            foreach (var arac in filteredModels)
            {
                if (!ModelPicker.Items.Contains(arac.Model))
                    ModelPicker.Items.Add(arac.Model);
            }
        }

        // Model seçildiğinde yılları filtreleme
        void ModelPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            YilPicker.Items.Clear();
            var selectedMarka = MarkaPicker.SelectedItem?.ToString();
            var selectedModel = ModelPicker.SelectedItem?.ToString();
            if (selectedMarka == null || selectedModel == null) return;

            var filteredYears = araclar.FindAll(a => a.Marka == selectedMarka && a.Model == selectedModel);

            foreach (var arac in filteredYears)
            {
                YilPicker.Items.Add(arac.Yil.ToString());
            }
        }

        // Hesapla butonuna tıklandığında hesaplama yapma
        void Hesapla_Clicked(object sender, EventArgs e)
        {
            // Seçilen marka, model ve yıl kontrolü
            var selectedMarka = MarkaPicker.SelectedItem?.ToString();
            var selectedModel = ModelPicker.SelectedItem?.ToString();
            var selectedYil = YilPicker.SelectedItem?.ToString();

            if (selectedMarka == null || selectedModel == null || selectedYil == null)
            {
                DisplayAlert("Hata", "Lütfen tüm seçimleri yapın.", "Tamam");
                return;
            }

            // Giriş km değerlerini alma ve doğrulama
            if (!double.TryParse(SehirIciEntry.Text, out double sehirIciKm) || !double.TryParse(SehirDisiEntry.Text, out double sehirDisiKm))
            {
                DisplayAlert("Hata", "Lütfen geçerli km değerleri giriniz.", "Tamam");
                return;
            }

            // Seçilen aracın bilgilerini bul
            var selectedArac = araclar.Find(a => a.Marka == selectedMarka && a.Model == selectedModel && a.Yil.ToString() == selectedYil);

            if (selectedArac == null)
            {
                DisplayAlert("Hata", "Seçilen araç bulunamadı.", "Tamam");
                return;
            }

            // Yakıt tüketim hesaplaması
            var sehirIciTuketim = sehirIciKm * selectedArac.SehirIciTuketim / 100;
            var sehirDisiTuketim = sehirDisiKm * selectedArac.SehirDisiTuketim / 100;

            // Sonuçları ekrana yazdır
            SehirIciSonucLabel.Text = $"{sehirIciTuketim:F2} Litre";
            SehirDisiSonucLabel.Text = $"{sehirDisiTuketim:F2} Litre";
        }
    }

    // Araç sınıfı
    public class Arac
    {
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public int Yil { get; set; }
        public double SehirIciTuketim { get; set; }
        public double SehirDisiTuketim { get; set; }
    }
}
