using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XTaiwanApp.Views;

namespace XTaiwanApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XStackLayoutDemo());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XGridDemo());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XGridKeyBoardDemo());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XAbsoluteLayoutDemo());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XAbsoluteLoaderDemo());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XAbsoluteContentDemo());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XEntryTypeDemo());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XTabbedPageDemo());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomElements.MyTabbedPage());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XMasterDetailPageDemo());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XCarouselPageDemo());
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XListViewDemo());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XListViewTwoColumnItemDemo());
        }
    }
}
