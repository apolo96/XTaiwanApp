using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XTaiwanApp.Models;

namespace XTaiwanApp.ViewModels
{
    class ItemTwoColumnViewModel
    {
        public ItemTwoColumnViewModel()
        {
            this.ItemTapCommand = new Command<Actor>((actor) =>
            {
                Debug.WriteLine("Item tap id:{0}", actor.ID);                
            });

        }

        public Actor RightColumn { get; set; }
        public Actor LeftColumn { get; set; }

        public ICommand ItemTapCommand { get; private set; }

        public INavigation Navigation { get; set; }
    }
}
