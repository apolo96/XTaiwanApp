using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XTaiwanApp.Models;
using XTaiwanApp.ViewModels;

namespace XTaiwanApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XListViewTwoColumnItemDemo : ContentPage
	{
		public XListViewTwoColumnItemDemo ()
		{
			InitializeComponent ();
            lvActors.ItemsSource = ConvertToTwoColumnsViewModelCollection(loadData());
		}

        IList<ItemTwoColumnViewModel> ConvertToTwoColumnsViewModelCollection(IList<Actor> actors)
        {
            var dataSource = new List<ItemTwoColumnViewModel>();
            for (var i = 0; i <= actors.Count - 1; i += 2)
            {
                var hasRight = (i + 1) < actors.Count;
                dataSource.Add(new ItemTwoColumnViewModel
                {
                    LeftColumn = actors[i],
                    RightColumn = hasRight ? actors[i + 1] : null,
                    Navigation = Navigation
                });
            }

            return dataSource;
        }

        private IList<Actor> loadData()
        {
            var imgSource = "https://avatars0.githubusercontent.com/u/790012?v=3&s=200";
            var actors = new List<Actor>();
            actors.Add(
                new Actor
                {
                    ID = 0,
                    Name = "Leonardo DiCaprio",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 1,
                    Name = "Jony Dep",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 2,
                    Name = "Jeen Querry",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 3,
                    Name = "Brad Pitt",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 4,
                    Name = "Mario Kaselo",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 5,
                    Name = "Emily Rios",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 6,
                    Name = "Casandra Roma",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 6,
                    Name = "Casandra Roma",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 6,
                    Name = "Casandra Roma",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 6,
                    Name = "Casandra Roma",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 6,
                    Name = "Casandra Roma",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 6,
                    Name = "Casandra Roma",
                    Photo = imgSource
                }
            );
            actors.Add(
                new Actor
                {
                    ID = 6,
                    Name = "Casandra Roma",
                    Photo = imgSource
                }
            );
            return actors;
        }

    }
}