using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Model
{
    public class Client
    {
        public string ID { get; set; }
        public string Name { get; set; }
       public string LastName { get; set; }
       public int Age { get; set; }
       public string Email { get; set; }
       public string Address { get; set; }
       public List<Sale> ListSales { get; set; }
       public string Imgsource { get; set; }

       public string FullName => Name +" "+ LastName;


        public static async Task<ObservableCollection<Client>> GetClients()
        {
            ObservableCollection<Client> LstPersons;
            LstPersons = new ObservableCollection<Client>()
            {new Client() {Name = "Diego", LastName = "Gutierrez", Age=25,  Imgsource = "https://image.ibb.co/mf5mOS/if_matureman1_628284.png",},
             new Client() {Name = "Francisco", LastName = "Marin", Age=60, Imgsource = "https://image.ibb.co/iHDecn/if_matureman2_628283_Cream.png",},
             new Client() {Name = "Carlos", LastName = "Mendez", Age=32,  Imgsource = "https://image.ibb.co/hACBq7/if_male3_403019.png",},
             new Client() {Name = "Mary",  LastName = "Poppins", Age=70, Imgsource = "https://image.ibb.co/jTurq7/if_maturewoman_628297_Cream.png",},
             new Client() {Name = "Juan", LastName = "Perez", Age=35, Imgsource = "https://image.ibb.co/jN9rq7/if_malecostume_403022.png",},
             new Client() {Name = "John", LastName = "Doe", Age=52, Imgsource = "https://image.ibb.co/ekM1OS/if_supportmale_403020.png",},
             new Client() {Name = "Ana", LastName = "Karenina", Age=40, Imgsource = "https://image.ibb.co/fLYUcn/if_female1_403023.png",},
             new Client() {Name = "Lisa", LastName = "Stewart", Age=15, Imgsource = "https://image.ibb.co/m1q9cn/if_girl_403021.png",},
             new Client() {Name = "Jack", LastName = "Miller", Age=17,  Imgsource = "https://image.ibb.co/cUygOS/if_boy_403024.png",}};     
            return LstPersons;

        }
        
    }
}
