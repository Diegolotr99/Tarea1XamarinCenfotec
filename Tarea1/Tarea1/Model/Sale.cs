using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.Model
{
    public class Sale
    {


        public int ID { get; set; }
        public DateTime SaleDate { get; set; }
        public List<SaleLine> ListSaleLines { get; set; }

        public string SaleDateString => SaleDate.ToShortDateString();


    }
}
