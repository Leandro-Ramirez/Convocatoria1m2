#region Usos
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using Domain.Entities;
using Infraestructura;
using System.Drawing;
using System.Data;
using Domain.Enum;
using System.Linq;
using System.Text;
using System;
#endregion

namespace Formulario.Formularios
{
    public partial class AgregarProducto : Form
    {
        public ProductoModel PModel { get; set; }
        public AgregarProducto()
        {
            InitializeComponent();
        }
        #region Cargar el Form
        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(Enum.GetValues(typeof(Categoria))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }
        #endregion

        #region Boton: Aceptar
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                //Id = PModel.GetLastProductoId() + 1,
                Nombre = txbNombre.Text,
                Descripcion = txbDescripcion.Text,
                Precio = nudPrecio.Value,
                Existencia = (int)nudCantidad.Value,
                FechaVencimiento = dtpVendimiento.Value,
                Categoria = (Categoria)cmbCategoria.SelectedIndex
            };

            PModel.Add(p);

            Dispose();
        }
        #endregion

        #region Boton: Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}