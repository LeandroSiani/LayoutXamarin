using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Layout.Views;

namespace XF.Layout
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ButtonLayoutClicked(object sender, EventArgs e)
        {
            if (sender as Button == BtnAbsolut)
                Navigation.PushAsync(new AbsolutLayoutPage());
            else if (sender as Button == BtnStack)
                Navigation.PushAsync(new StackLayoutPage());
            else if (sender as Button == BtnLoginAbsolut)
                Navigation.PushAsync(new LoginAbsolutPage());
            else if (sender as Button == BtnRelative)
                Navigation.PushAsync(new RelativeLayoutPage());
            else if (sender as Button == BtnGrid)
                Navigation.PushAsync(new GridPage());
            else if (sender as Button == BtnFlex)
                Navigation.PushAsync(new FlexlayoutPage());
        }
    }
}
