#region Usos
using System.Collections.Generic;
using System.Text;
using Domain.Enum;
using System;
#endregion

namespace Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaVencimiento{ get; set; }
        public Categoria Categoria { get; set; }
    }
}