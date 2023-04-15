using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xam.Login.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xam.Login.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SocialLoginPage : ContentPage
	{
		public SocialLoginPage ()
		{
			InitializeComponent ();
            this.BindingContext = new SocialLoginPageViewModel();
        }
	}
}