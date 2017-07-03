using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XTaiwanApp.Views.MasterMenu;
using XTaiwanApp.Views.MasterMenu.PagesDetail;

namespace XTaiwanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XMasterDetailPageDemo : MasterDetailPage
    {
        public XMasterDetailPageDemo()
        {
            InitializeComponent();
            var masterPageItem = new List<MasterPageItem>();
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Perfil",
                Icon = "image.png",
                TargetType = typeof(Perfil)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Material",
                Icon = "image.png",
                TargetType = typeof(Material)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Colecciones",
                Icon = "image.png",
                TargetType = typeof(Colecciones)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Configuracion",
                Icon = "image.png",
                TargetType = typeof(Configuracion)
            });
            lvMasterPageItems.ItemsSource = masterPageItem;
        }

        private void lvMasterPageItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var masterPageItem = e.SelectedItem as MasterPageItem;
            if (masterPageItem != null)
            {
                Type page = masterPageItem.TargetType;
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                IsPresented = false;                
            }
            lvMasterPageItems.SelectedItem = null;
        }
    }
}