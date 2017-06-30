using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XTaiwanApp.Views.TabbedContent;

namespace XTaiwanApp.CustomElements
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyTabbedPage : ContentPage
	{
		public MyTabbedPage ()
		{
			InitializeComponent();
            var page = new PageOne();
            cvContentPlaceHolder.Content = page.Content;
        }

        private void TapGestureRecognizer_Tapped_One(object sender, EventArgs e)
        {
            
        }
        private void TapGestureRecognizer_Tapped_PageTwo(object sender, EventArgs e)
        {
            var page = new PageTwo();
            cvContentPlaceHolder.Content = page.Content;
        }
        private void TapGestureRecognizer_Tapped_Three(object sender, EventArgs e)
        {
            var page = new PageThree();
            cvContentPlaceHolder.Content = page.Content;
        }
    }
}