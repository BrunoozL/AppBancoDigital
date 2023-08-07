using AppBancoDigital.Model;
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

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            if (txt_cpf.Text == null || txt_senha.Text == null)
            {
                await DisplayAlert("Erro de Login", "CPF ou senha insetidos não existem", "OK");
            }
            else
            {
                try
                {
                    Model.Correntista c = await Service.DataServiceCorrentista.LoginAsync(new Model.Correntista
                    {
                        cpf = txt_cpf.Text,
                        senha = txt_senha.Text,
                    });

                    if (c.id != null)
                    {
                        App.DadosCorrentista = c;
                        App.Current.MainPage = new NavigationPage(new View.Conta());
                    }
                    else
                        throw new Exception("Dados de login inválidos.");
                }


                catch (Exception ex)
                {
                    await DisplayAlert("Ops!", ex.Message, "OK");
                }
            }
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