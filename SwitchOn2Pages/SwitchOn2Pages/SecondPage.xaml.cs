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
	public partial class SecondPage : ContentPage
	{

        public SecondPage()
        {
        }

        public SecondPage (bool OnOf)
		{
			InitializeComponent ();
            if (OnOf)
            {
                SwitchImage.IsVisible = true;
            }
            else { return; }
        }

        //public Image SwitchImage { get; }
    }

}
