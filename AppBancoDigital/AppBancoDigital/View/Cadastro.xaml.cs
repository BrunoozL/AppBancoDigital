using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.logo_com_nome.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btn_cadastro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Correntista c = await DataServiceCorrentista.SaveAsync(new Model.Correntista
                {
                    nome = txt_nome.Text,
                    data_nasc = dtcpk_nascimento.Date,
                    cpf = txt_cpf.Text,
                    senha = txt_senha.Text,
                    data_cadastro = DateTime.Now,
                    email = txt_email.Text
                });

                if (c.id != null)
                {
                    /**
                     * Vá no arquivo App.xaml.cs e veja que declarei uma propriedade chamada
                     * DadosCorrentista, que irá armazenar os dados do correntista após o cadastro ou
                     * login, enquanto ele estiver usando o App.
                     */
                    App.DadosCorrentista = c;

                    /**
                     * Navegando para a Tela Inicial após cadastrar e definir os dados do Correntista.
                     */
                    await Navigation.PushAsync(new View.Menu());
                }
                else
                    throw new Exception("Ocorreu um erro ao salvar seu cadastro.");
                try
                {
                    App.Current.MainPage = new NavigationPage(new View.Login());
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }

        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }

        }
    }
}