using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Kevin_Alonso_Gestion_OC_DND
{
    public partial class PersonajesDeCadaJugador : Form
    {
        public PersonajesDeCadaJugador()
        {
            InitializeComponent();
        }

        private void personajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.llamada_de_cthulhuDataSet);

        }

        private void PersonajesDeCadaJugador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'llamada_de_cthulhuDataSet.personaje' Puede moverla o quitarla según sea necesario.
            this.personajeTableAdapter.Fill(this.llamada_de_cthulhuDataSet.personaje);

        }

        /// <sumamary>
        /// Maneja el evento Click del control btnBuscar, este recorre el DataGridView y para compararlo con el tex box. 
        /// </summary>
        /// <param name="sender">El inicio del evento.</param>
        /// <param name="e">La instancia <see cref="EventArgs"/> que contiene los datos del evento.</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in personajeDataGridView.Rows)
            {
                row.Selected = false;
                String contenido = row.Cells[1].Value.ToString().ToUpper();
                String busqueda = tbName.Text.ToUpper();

                contenido = contenido.Replace(" ", String.Empty);
                busqueda = busqueda.Replace(" ", String.Empty);
                int comparador = contenido.IndexOf(busqueda);


                if (comparador > -1)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in personajeDataGridView.Rows)
            {
                row.Selected = false;
                String contenido = row.Cells[2].Value.ToString().ToUpper();
                String busqueda = tbJugador.Text.ToUpper();

                contenido = contenido.Replace(" ", String.Empty);
                busqueda = busqueda.Replace(" ", String.Empty);
                int comparador = contenido.IndexOf(busqueda);


                if (comparador > -1)
                {
                    row.Selected = true;
                    break;
                }
            }
        }
    }
}
