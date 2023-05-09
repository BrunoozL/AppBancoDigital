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
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.Lobank1.png");
        }

        private bool CheckCredentials(string cpf, string senha)
        {
            //Login Para Admin
            if (cpf == "999.999.999-99" && senha == "zzxxccvv123")
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Menu());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }

        private void btn_login_Clicked(object sender, EventArgs e)
        {
            string cpf = txt_cpf.Text;
            string senha = txt_senha.Text;

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
            {
                DisplayAlert("Erro de Login", "CPF e senha são obrigatórios.", "OK");
                return;
            }

            bool isValidUser = CheckCredentials(cpf, senha);

            if (isValidUser)
            {
                App.Current.MainPage = new NavigationPage(new View.Conta());
            }
            else
            {
                DisplayAlert("Erro de Login", "CPF ou senha inseridos não existem.", "OK");
            }

           /* try
            {
                App.Current.MainPage = new NavigationPage(new View.Conta());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
           */
        }

        private async void btn_CriarConta_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Cadastro());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }
    }
}