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
    public partial class EditarPersonajes : Form
    {
        public EditarPersonajes()
        {
            InitializeComponent();
            personajes();
        }

        private void ListaPersonajes_Load(object sender, EventArgs e)
        {
            this.personajeTableAdapter.Fill(this.llamada_de_cthulhuDataSet.personaje);
            this.habilidadesTableAdapter.Fill(this.llamada_de_cthulhuDataSet.habilidades);

        }

        private void personajeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.llamada_de_cthulhuDataSet);
        }
    }
}
