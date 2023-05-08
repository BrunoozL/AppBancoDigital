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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Lobank1.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}