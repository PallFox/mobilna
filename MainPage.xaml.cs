using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        string wybraneZwierze = "";

        public MainPage()
        {
            InitializeComponent();
            List<string> zwierzeta = new List<string> { "Pies", "Kot", "Świnka morska" };
            zwierzetaListView.ItemsSource = zwierzeta;
        }

        private void WybraneZwierze(object sender, SelectedItemChangedEventArgs e)
        {
            var wybrane = zwierzetaListView.SelectedItem;
            if (wybrane != null)
            {
                wybraneZwierze = wybrane.ToString();
                ZmienMaksymalnyWiekZwierzecia(wybraneZwierze);
            }
        }

        private void ZmienMaksymalnyWiekZwierzecia(string zwierze)
        {
            if (zwierze == "Pies")
            {
                wiekSlider.Maximum = 18;
                wiekSlider.Value = 0;
            }
            else if (zwierze == "Kot")
            {
                wiekSlider.Maximum = 20;
                wiekSlider.Value = 0;
            }
            else if (zwierze == "Świnka morska")
            {
                wiekSlider.Maximum = 9;
                wiekSlider.Value = 0;
            }
        }

        private void ZmienWiek(object sender, ValueChangedEventArgs e)
        {
            wiek.Text = wiekSlider.Value.ToString("0");
        }

        private void Wyswietl(object sender, EventArgs e)
        {
            string wlascicielInformacje = wlascicielEntry.Text;
            string zwierze = wybraneZwierze;
            string wiek = wiekSlider.Value.ToString("0");
            string cel = celEntry.Text;
            string czas = time.Time.ToString(@"hh\:mm");

            string komunikat = $"{wlascicielInformacje}, {zwierze}, {wiek}, {cel}, {czas}";

            DisplayAlert("Komunikat", komunikat, "OK");

            informacjeLabel.Text = komunikat;
        }
    }

}
