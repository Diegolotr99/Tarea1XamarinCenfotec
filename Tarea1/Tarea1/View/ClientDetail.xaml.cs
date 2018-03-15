using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Model;
using Tarea1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientDetail : ContentPage
	{
		public ClientDetail ()
		{
			InitializeComponent ();
            //Next lines to test the View Client Detail. Burning Actual Client data. 
            ClientViewModel cmv= ClientViewModel.GetInstance();
            BindingContext = cmv;
            Client clt = new Client() {ID="1-15050607",  Name = "Diego", LastName = "Gutierrez", Age = 25, Address="House 9C, San Jose, CR", Email="diegolotr99@gmail.com",
                Imgsource = "https://image.ibb.co/mf5mOS/if_matureman1_628284.png", ListSales=new List<Sale>(),};
            clt.ListSales = GetBurnedSalesData();

            cmv.ActualClient = clt;
        }

        public List<Sale> GetBurnedSalesData()
        {

            List<Sale> LstSales;
            LstSales = new List<Sale>()
            {new Sale() {ID = 1, SaleDate=new DateTime(2018,02,01)},
             new Sale() {ID = 2, SaleDate=new DateTime(2018,01,21)},
             new Sale() {ID = 3, SaleDate=new DateTime(2018,01,17)},
             new Sale() {ID = 4, SaleDate=new DateTime(2018,03,05)},
             new Sale() {ID = 5, SaleDate=new DateTime(2018,03,07)}};
            return LstSales;
        }
    }
}