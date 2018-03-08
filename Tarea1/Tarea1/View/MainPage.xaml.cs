using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        List<Client> DataSource = new List<Client>();

        public MainPage ()
		{
			InitializeComponent ();
            //lst.ItemsSource = new List<string>() { "item 1", "item 2", "Item 3" };
            lst.ItemsSource = new List<Client>() {
               new Client() {
            Name = "Diego", LastName = "Gutierrez", Age=25, Gender="Men",  Imgsource = "https://image.ibb.co/mf5mOS/if_matureman1_628284.png",
        },
        new Client() {
            Name = "Francisco", LastName = "Marin", Age=60, Gender="Men", Imgsource = "https://image.ibb.co/iHDecn/if_matureman2_628283_Cream.png",
        },
        new Client() {
            Name = "Carlos", LastName = "Mendez", Age=32, Gender="Men", Imgsource = "https://image.ibb.co/hACBq7/if_male3_403019.png",
        },
            new Client()
            {
                Name = "Mary",  LastName = "Poppins", Age=70, Gender="Women",Imgsource = "https://image.ibb.co/jTurq7/if_maturewoman_628297_Cream.png",
         },
            new Client()
            {
                Name = "Juan", LastName = "Perez", Age=35, Gender="Men", Imgsource = "https://image.ibb.co/jN9rq7/if_malecostume_403022.png",
         }
            ,
            new Client()
            {
                Name = "John", LastName = "Doe", Age=52, Gender="Men", Imgsource = "https://image.ibb.co/ekM1OS/if_supportmale_403020.png",
         }
            ,
            new Client()
            {
                Name = "Ana", LastName = "Karenina", Age=40, Gender="Women", Imgsource = "https://image.ibb.co/fLYUcn/if_female1_403023.png",
         }
            ,
            new Client()
            {
                Name = "Lisa", LastName = "Stewart", Age=15, Gender="Women", Imgsource = "https://image.ibb.co/m1q9cn/if_girl_403021.png",
         },
            new Client()
            {
                Name = "Jack", LastName = "Miller", Age=17, Gender="Men", Imgsource = "https://image.ibb.co/cUygOS/if_boy_403024.png",
         }};
            DataSource = lst.ItemsSource as List<Client>;
    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Client> list = lst.ItemsSource as List<Client>;
            if(list != null)
            {
                var result = list.Where(client => client.Name == "Carlos" || client.Name == "Francisco");
                lst.ItemsSource = result;
            }
        }
        private void Button_Clicked_Age(object sender, EventArgs e)
        {
            List<Client> list = lst.ItemsSource as List<Client>;
            if (list != null)
            {
                var result = list.Where(client => client.Age >= 50 );
                lst.ItemsSource = result;
            }
        }
        private void Button_Clicked_Men(object sender, EventArgs e)
        {
            List<Client> list = lst.ItemsSource as List<Client>;
            if (list != null)
            {
                var result = list.Where(client => client.Gender == "Men");
                lst.ItemsSource = result;
            }
        }
        private void Button_Clicked_Women(object sender, EventArgs e)
        {
            List<Client> list = lst.ItemsSource as List<Client>;
            if (list != null)
            {
                var result = list.Where(client => client.Gender == "Women");
                lst.ItemsSource = result;
            }
        }
        private void Button_Clicked_Reset(object sender, EventArgs e)
        {
            
            if (DataSource != null)
            {
                
                lst.ItemsSource = DataSource;
            }
        }
    }
}