using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PixEnviar : ContentPage
    {
        public PixEnviar()
        {
            InitializeComponent();
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {

            try
            {
                App.Current.MainPage = new NavigationPage(new View.Conta());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }
    }
}