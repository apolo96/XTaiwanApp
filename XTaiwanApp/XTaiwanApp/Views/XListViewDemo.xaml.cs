using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XTaiwanApp.Models;

namespace XTaiwanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XListViewDemo : ContentPage
    {
        public XListViewDemo()
        {
            InitializeComponent();
            lvActors.ItemsSource = loadData();
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
            return actors;
        }
    }
}