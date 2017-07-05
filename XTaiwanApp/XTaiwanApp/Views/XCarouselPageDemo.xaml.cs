using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XTaiwanApp.Models;

namespace XTaiwanApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XCarouselPageDemo : CarouselPage
	{
		public XCarouselPageDemo ()
		{
			InitializeComponent ();
            Pages = new ObservableCollection<XImage>
            {
                new XImage
                {
                    ImageSource = "http://davidguetta.com/sites/default/files/listen.jpg",
                    Name = "David Guetta"
                },
                new XImage
                {
                    ImageSource = "https://i.refresher.sk/public/tajoslav/ludia/avicii-dj%5B1%5D.jpg",
                    Name = "Avicii"
                },
                new XImage
                {
                    ImageSource = "https://s3.amazonaws.com/ssglobalcdn/performers/profile/deadmau5.jpg",
                    Name = "Deadmau5"
                },
                new XImage
                {
                    ImageSource = "http://neomusicmex.com/wp-content/uploads/2015/12/dj_tiesto_club_life_img426.jpg",
                    Name = "Tiesto"
                }
            };
            ItemsSource = Pages;
        }

        public ObservableCollection<XImage> Pages { get; private set; }
    }
}