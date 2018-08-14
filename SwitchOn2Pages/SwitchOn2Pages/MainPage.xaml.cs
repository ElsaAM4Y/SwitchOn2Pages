using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwitchOn2Pages
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new NavigationPage(new FirstPage()));
            Children.Add(new NavigationPage(new SecondPage()));

        }
    }
}
