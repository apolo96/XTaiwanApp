using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XTaiwanApp.CustomElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActorCard : ViewCell
    {
        public ActorCard()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty IDProperty =
            BindableProperty.Create("ID",typeof(int),typeof(ActorCard),0);

        public int ID
        {
            get { return (int)GetValue(IDProperty); }
            set { SetValue(IDProperty,value); }
        }

        public static readonly BindableProperty NameProperty =
            BindableProperty.Create("Name", typeof(string), typeof(ActorCard), null);

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly BindableProperty PhotoProperty =
            BindableProperty.Create("Photo", typeof(string), typeof(ActorCard), null);

        public string Photo
        {
            get { return (string)GetValue(PhotoProperty); }
            set { SetValue(PhotoProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (BindingContext != null)
            {
                lbID.Text = ID.ToString();
                lbName.Text = Name;
                imgSource.Source = Photo;
            }
        }
    }
}