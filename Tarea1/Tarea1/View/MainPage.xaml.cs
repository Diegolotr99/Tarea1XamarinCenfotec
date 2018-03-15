using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea1.ViewModel;
namespace Tarea1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        List<Client> DataSource = new List<Client>();

        public MainPage ()
		{
			InitializeComponent ();
            BindingContext = new ClientViewModel();
        }

     
    }
}