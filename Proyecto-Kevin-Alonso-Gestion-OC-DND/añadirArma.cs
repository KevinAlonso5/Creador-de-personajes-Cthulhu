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
    public partial class añadirArma : Form
    {
        public añadirArma()
        {
            InitializeComponent();
        }

        private void equipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.llamada_de_cthulhuDataSet);

        }

        private void añadirArma_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'llamada_de_cthulhuDataSet.equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.llamada_de_cthulhuDataSet.equipo);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tipoArma() != -1)
            {
                equipoTableAdapter.Insert(tbNombre.Text, tbDaño.Text, tbAlcance.Text, tbNumAtac.Text, Convert.ToInt32(nudMunicion.Value), Convert.ToInt32(nudAveria.Value), tipoArma());
            }
            else
            {
                MessageBox.Show("No pudes dejar el valor vacio");
            }
            
        }

        private int tipoArma()
        {
            switch (cbTipoArma.Text)
            {
                case "Arma Corta(pistolas)":
                    return 0;
                    break;
                case "Arma Larga(Escopetas)":
                    return 1;
                    break;
                case "Arma mele(Cuchillos)":
                    return 2;
                    break;
                default:
                    return -1;
                    break;


            }
        }
    }
}
