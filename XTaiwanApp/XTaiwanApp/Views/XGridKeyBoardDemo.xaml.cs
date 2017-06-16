using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XTaiwanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XGridKeyBoardDemo : ContentPage
    {
        public XGridKeyBoardDemo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (sender as Button);
            var number = button.Text;
            lbShowNumber.Text += number;
        }
    }
}