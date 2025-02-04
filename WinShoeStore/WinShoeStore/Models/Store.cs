using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinShoeStore.Models
{
    public class Store
    {
        public int Id { get; set; }  // Identificador único
        public string Name { get; set; }  // Nombre de la tienda
        public string Address { get; set; }  // Dirección de la tienda
    }
}
