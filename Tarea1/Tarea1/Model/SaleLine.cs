using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.Model
{
    public class SaleLine
    {
        public SaleLine(){

        }
        public int ID { get; set; }
        public Article LineArticle { get; set; }
        public int Quantity { get; set; }
    }
}
