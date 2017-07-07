using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XTaiwanApp.Models;

namespace XTaiwanApp.CustomElements
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActorTwoCard : ViewCell
	{
		public ActorTwoCard ()
		{
			InitializeComponent ();
		}
        #region "LeftColumn"
        public static readonly BindableProperty LeftColumnProperty =
            BindableProperty.Create(
                "LeftColumn",
                typeof(Actor),
                typeof(ActorTwoCard),
                null);
        public Actor LeftColumn
        {
            get { return (Actor)GetValue(LeftColumnProperty); }
            set { SetValue(LeftColumnProperty, value); }
        }
        #endregion

        #region "RightColumn"
        public static readonly BindableProperty RightColumnProperty =
            BindableProperty.Create(
                "RightColumn",
                typeof(Actor),
                typeof(ActorTwoCard),
                null);
        public Actor RightColumn
        {
            get { return (Actor)GetValue(RightColumnProperty); }
            set { SetValue(RightColumnProperty, value); }
        }
        #endregion

        #region "ItemTapCommand"
        public static readonly BindableProperty ItemTapCommandProperty =
            BindableProperty.Create(
                "ItemTapCommand",
                typeof(ICommand),
                typeof(ActorTwoCard),
                null);
        public ICommand ItemTapCommand
        {
            get { return (ICommand)GetValue(ItemTapCommandProperty); }
            set { SetValue(ItemTapCommandProperty, value); }
        }
        #endregion

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (BindingContext != null)
            {
                imgLeftPhoto.Source = LeftColumn.Photo;
                lbLeftName.Text = LeftColumn.Name;
                imgLeftPhoto.GestureRecognizers.Add(
                    new TapGestureRecognizer(OnLeftPhotoTapped));

                if (RightColumn != null)
                {
                    imgRightPhoto.Source = RightColumn.Photo;
                    lbRightName.Text = RightColumn.Name;
                    imgRightPhoto.GestureRecognizers.Add(
                        new TapGestureRecognizer(OnRightPhotoTapped));
                }
                else
                {
                    imgRightPhoto.Source = null;
                    lbRightName.Text = "";
                }
            }
        }

        void OnLeftPhotoTapped(View arg1, object arg2)
        {
            ItemTapCommand.Execute(LeftColumn);
        }
        void OnRightPhotoTapped(View arg1, object arg2)
        {
            ItemTapCommand.Execute(RightColumn);
        }
    }
}