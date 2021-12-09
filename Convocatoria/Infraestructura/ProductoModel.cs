#region Usos
using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Infraestructura
{
    public class ProductoModel
    {
        private Producto[] productos;
        #region CRUD
        //Añadir
        public void Add(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null");
            }
            Add(p, ref productos);
        }
        //Obtener Todo
        public Producto[] GetAll()
        {
            return productos;
        }
        //Actualizar.
        public int Update(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }
            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id:{p.Id} no existe.");
            }
            productos[index] = p;
            return index;
        }
        #endregion
        #region Queries
        //Obtener Producto por Id
        public Producto GetProductoById(int id)
        {
            int index = GetIndexById(id);
            return index < 0 ? null : productos[index];
        }
        #endregion
        #region Private method
        //Añadir
        private void Add(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }

        private int GetIndexById(int id)
        {
            int index = int.MinValue, i = 0;
            if (id <= 0)
            {
                throw new ArgumentException($"El id:{id} no puede ser negativo o cero.");
            }

            if (productos == null)
            {
                return index;
            }

            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        #endregion
    }
}