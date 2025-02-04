using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinShoeStore.Models
{
    public class Article
    {
        public int Id { get; set; }  // Identificador único
        public string Name { get; set; }  // Nombre del artículo
        public string Description { get; set; }  // Descripción breve
        public decimal Price { get; set; }  // Precio del artículo
        public int Total1 { get; set; }  // Cantidad en tienda física
        public int Total2 { get; set; }  // Cantidad en bodega
        public int StoreId { get; set; }  // Relación con la tienda
    }
}
