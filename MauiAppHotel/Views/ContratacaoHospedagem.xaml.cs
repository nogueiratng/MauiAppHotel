namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        // Evento do bot�o "Sobre"
        private async void BtnSobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobrePage());
        }
    }
}
