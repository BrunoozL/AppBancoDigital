﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBancoDigital.Model;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conta : ContentPage
    {
        bool txt_saldo = false;
        string txt_sim = "Sim";
        string txt_nao = "Nao"; 
        public Conta()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Correntista c = new Correntista();
            lbl_nome.Text =  App.DadosCorrentista.nome + "   ";
            //lbl_saldo.Text = "" + App.DadosConta.saldo;//
        }

        private async void Botão_receber_pix_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.PixReceber());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }

        private async void Botão_fazer_pix_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.PixEnviar());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }

        private async void btn_sair_Clicked(object sender, EventArgs e)
        {
            try
            {
                string resp = await DisplayActionSheet("Tem certeza que deseja sair?", txt_sim, txt_nao);

                if (resp == txt_sim)
                {
                    App.Current.MainPage = new NavigationPage(new View.Menu());
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }

        private async void btn_config_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Config());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
            }
        }
    }
}