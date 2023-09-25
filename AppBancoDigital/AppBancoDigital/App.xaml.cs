using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital
{
    public partial class App : Application
    {
        public static Model.Conta DadosConta { get; set; }
        public static Model.Correntista DadosCorrentista { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new View.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
