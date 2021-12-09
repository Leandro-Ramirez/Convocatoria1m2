#region Usos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Formulario.Formularios
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void LblAcciones_Click(object sender, EventArgs e)
        {

        }

        #region Boton: Registrar
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Boton: Filtrar
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            lblCategoria.Visible = true;
            cmbCategoria.Visible = true;
            btnVisualizar.Visible = true;
        }
        #endregion

        #region Boton: Calcular
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Perecederos {Precio x Existencia} + Lacteos {Precio x Existencia} 
        }
        #endregion

        #region Boton: Visualizar (Actualizar)
        private void BtnVisualizar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}