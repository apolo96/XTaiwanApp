using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XTaiwanApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XEntryTypeDemo : ContentPage
	{
		public XEntryTypeDemo ()
		{
			InitializeComponent ();
		}

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine(e.NewTextValue);
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            Entry entry = sender as Entry;
            Debug.WriteLine(entry.Text);
        }
    }
}