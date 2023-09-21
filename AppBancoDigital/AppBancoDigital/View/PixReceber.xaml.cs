using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PixReceber : ContentPage
    {
        public PixReceber()
        {
            InitializeComponent();

        }

        private void Gerar_QrCode_Clicked(object sender, EventArgs e)
        {
        }
    }
}