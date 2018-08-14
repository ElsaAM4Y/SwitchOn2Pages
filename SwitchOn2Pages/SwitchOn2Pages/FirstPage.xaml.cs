using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwitchOn2Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			InitializeComponent ();
            //Navigation.PushAsync(new SecondPage(MySwitch.IsToggled));
        }

    }
}