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
        }

        private void Botão_receber_pix_Clicked(object sender, EventArgs e)
        {

        }

        private void Botão_fazer_pix_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_sair_Clicked(object sender, EventArgs e)
        {

        }
    }
}