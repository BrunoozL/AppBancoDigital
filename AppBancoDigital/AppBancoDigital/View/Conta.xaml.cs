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
    public partial class Conta : ContentPage
    {
        bool txt_saldo = false;
        public Conta()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.logo.png");
            btnolho.Source = ImageSource.FromResource("AppBancoDigital.Imagens.olho_aberto.png");
        }

        private async void btnolho_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!txt_saldo) 
                {
                    txt_saldo = true;
                    btnolho.Source = ImageSource.FromResource("AppBancoDigital.Imagens.olho_fechado.png");
                }
                else
                {
                    txt_saldo = false;
                   btnolho.Source = ImageSource.FromResource("AppBancoDigital.Imagens.olho_aberto.png");
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro", ex.Message, "OK");
            }
        }
    }
}