using System;
using System.Collections;
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
    public partial class Cthulhu : Form
    {
        private ArrayList valHab;

        public Cthulhu()
        {
            valHab = new ArrayList();
            InitializeComponent();
            crearComprobador();


            lbPunTrabajo.Checked = true;

            this.ttCthulhu.SetToolTip(this.btnRecalcular, "Este boton se ocupa de recalcular los datos de las estadisticas si se han cambiado y asignar los valores calculados");
            this.ttCthulhu.SetToolTip(this.tbNombre, "introduce aqui el nombre de tu personaje");
            this.ttCthulhu.SetToolTip(this.cbTrabajo, "elige el trabajo de tu personaje");
            this.ttCthulhu.SetToolTip(this.nudEdad, "pon la edad, pero ten ecuenta que si es mallor de 40 habra cambios en tus estadisticas");
            this.ttCthulhu.SetToolTip(this.nudFuerza, "indica la capacidade fisica de tu personaje. ejem: levantar cosas pesada");
            this.ttCthulhu.SetToolTip(this.nudDes, "indica la aguilidad de tu personaje. ejem: escapar");
            this.ttCthulhu.SetToolTip(this.nudPod, "indica tu capacidad para la magia. ejem: lanzar echizos");
            this.ttCthulhu.SetToolTip(this.nudCons, "indica tu resistencia al daño. ejem: soportar el dolor");
            this.ttCthulhu.SetToolTip(this.nudApa, "indica lo atractivo que eres par el resto, puede referirse a caracter");
            this.ttCthulhu.SetToolTip(this.nudEdu, "indica tu grados de estudio 50 = eso, 60 = bachiller, 70 = carrera, 80 = maseter, 90 = doctorado");
            this.ttCthulhu.SetToolTip(this.nudTam, "indica tu tamaño, no tiene que ser altura tambien puede ser peso");
            this.ttCthulhu.SetToolTip(this.nudInt, "indica los inteligente que eres");
        }

        /// <summary>
        /// Generador de numeros random.
        /// </summary>
        /// <param name="repeticiones">Numero de veces que se genera el numero</param>
        /// <returns> manda devuelta el el resultado de los numeros random</returns>
        private int generadorRandom(int repeticiones)
        {
            Random dado = new Random();
            int salida = 0;
            for (int i = 0; i < repeticiones; i++)
            {
                salida = salida + dado.Next(6) + 1;
            }
            return salida;
        }


        /// <summary>
        /// Coloca los valores correspondientes en las labels y en el numericUpDown.
        /// </summary>
        /// <param name="extremo">Manda la etiqueta a la que ahi que asignarle el valor de extremo.</param>
        /// <param name="dificil">Manda la etiqueta a la que ahi que asignarle el valor de dificil.</param>
        /// <param name="stbase">Manda al NumericUpDown a la que ahi que asignarle el valor base .</param>
        /// <param name="dados">Devuelve los numeros aleatorios que asigna a los otros parametros.</param>
        /// 
        private void ests(Label extremo, Label dificil, NumericUpDown stbase, int dados)
        {
            extremo.Text = dados + "";
            stbase.Value = dados * 5 ;
            dificil.Text = Convert.ToInt32(stbase.Value / 2) + "";
        }


        /// <summary>
        /// Este metodo hace las comprobaciones y se ocupa de gestionar lo que ocurre al operar con las habilidades.
        /// </summary>
        /// <param name="numHab">El parametro es la localizacion que tiene la habilidada en el ArrayList.</param>
        /// <param name="entrada">Indica el numericUpDown con el que se a interactuado.</param>
        /// 
        private void cambiosHabilidades(int numHab, NumericUpDown entrada, CheckBox checBoxEntrada)
        {
            int ValCambiado = Convert.ToInt32(entrada.Value);
            int ValHabilidad = Convert.ToInt32(valHab[numHab]);

            if (ValCambiado > ValHabilidad)
            {
                int restado = (ValCambiado - ValHabilidad);
                if (lbPunTrabajo.Checked)
                {
                    if ((checBoxEntrada.Checked) && (Convert.ToInt32(lbPunTrabajo.Text) > 0))
                    {
                        lbPunTrabajo.Text = Convert.ToInt32(lbPunTrabajo.Text) - restado + "";
                        valHab[numHab] = ValCambiado;
                    }
                    else
                    {
                        entrada.Value = ValHabilidad;
                    }

                }
                else if (lbPuntPropios.Checked)
                {
                    if(Convert.ToInt32(lbPuntPropios.Text) > 0)
                    {
                        lbPuntPropios.Text = Convert.ToInt32(lbPuntPropios.Text) - restado + "";
                        valHab[numHab] = ValCambiado;
                    }
                    else
                    {
                        entrada.Value = ValHabilidad;
                    }

                }
                
            }

            else if(ValCambiado < ValHabilidad)
            {
                int sumado = (ValHabilidad - ValCambiado);
                if (lbPuntPropios.Checked)
                {
                    lbPuntPropios.Text = Convert.ToInt32(lbPuntPropios.Text) + sumado + "";
                }
                else if (lbPunTrabajo.Checked)
                {
                    lbPunTrabajo.Text = Convert.ToInt32(lbPunTrabajo.Text) + sumado + "";

                }
                valHab[numHab] = ValCambiado;
            }

            else if ((Convert.ToInt32(lbPunTrabajo.Text) <= 0) || (Convert.ToInt32(lbPunTrabajo.Text) > 0))
            {
                
            }

            
        }


        /// <summary>
        /// Este metodo crea una arry list que almacena los valores que tienen todas las habilidades
        /// para despues comprobar si este a sido incrementado o decrementado.
        /// </summary>

        private void crearComprobador()
        {
            //primera de cuatro
            valHab.Add(1);  //0  antropologuia
            valHab.Add(20); //1  arma corta
            valHab.Add(25); //2  arma larga
            valHab.Add(1);  //3  arqueologuia
            valHab.Add(5);  //4  arte
            valHab.Add(20); //5  buscar libros
            valHab.Add(1);  //6  cerrajeria
            valHab.Add(5);  //7  charlataneria
            valHab.Add(1);  //8  ciencia
            valHab.Add(5);  //9  ciencia oculta
            valHab.Add(25); //10  pelea
            valHab.Add(20); //11  conducir automovil
            valHab.Add(1);  //12  conducir maquinaria

            //segundo de cuatro
            valHab.Add(5);  //13  contavilidad
            valHab.Add(0);  //14  credito
            valHab.Add(5);  //15  derecho
            valHab.Add(25); //16  descubrir
            valHab.Add(5);  //17  disfrazarse
            valHab.Add(10); //18  electricidad
            valHab.Add(15); //19  encanto
            valHab.Add(5);  //20  equitacion
            valHab.Add(20); //21  escuchar
            valHab.Add(0);  //22  esquivar
            valHab.Add(5);  //23  historia
            valHab.Add(15); //24  intimaidar
            valHab.Add(10); //25  juego de manos

            //tercer de cuatro
            valHab.Add(20); //26    lanzar
            valHab.Add(10); //27    mecanica
            valHab.Add(1);  //28    medicina
            valHab.Add(0);  //29    mitos Cth
            valHab.Add(20); //30    nada
            valHab.Add(10); //31    naturaleza
            valHab.Add(10); //32    orientarse
            valHab.Add(10); //33    persuasion
            valHab.Add(1);  //34    pilotar
            valHab.Add(30); //35    primeros aux
            valHab.Add(1);  //36    psicoanalisis
            valHab.Add(10); //37    psicologuia
            valHab.Add(20); //38    saltar

            //cuatro de cuatro
            valHab.Add(10); //39    seguir rastro
            valHab.Add(20); //40    siguilo
            valHab.Add(10); //41    supervivencia
            valHab.Add(5);  //42    tasacion
            valHab.Add(20); //43    trepar
        }


        /// <summary>
        /// este metodo comprueba que trabajo se a asignado y marcar como chec aquellas casillas que se pueden mejorar
        /// solo con los puntos de trabajo.
        /// </summary>
        private void comprobarTrabajo()
        {
            String trabajo = cbTrabajo.Text;

            switch (trabajo)
            {
                case "Anticuario":
                    cbBuscarlibros.Checked = true;
                    cbArte.Checked = true;
                    cbCharlataneria.Checked = true;
                    cbDescubrir.Checked = true;
                    cbHistoria.Checked = true;
                    cbTasacion.Checked = true;
                    cbPersuasion.Checked = true;
                    break;
                case "Detective":
                    cbCharlataneria.Checked = true;
                    cbDerecho.Checked = true;
                    cbDescubrir.Checked = true;
                    cbEscuchar.Checked = true;
                    cbPersuasion.Checked = true;
                    cbPsicologuia.Checked = true;
                    cbArmaCorta.Checked = true;
                    break;

                case "Diletante":
                    cbCredito.Checked = true;
                    cbEquitacion.Checked = true;
                    cbRiflesEscopetas.Checked = true;
                    cbArte.Checked = true;
                    cbTasacion.Checked = true;
                    cbPsicoanalisis.Checked = true;
                    cbEncanto.Checked = true;
                    break;

                case "Escritor":
                    cbBuscarlibros.Checked = true;
                    cbCienciasOcultas.Checked = true;
                    cbHistoria.Checked = true;
                    cbPsicologuia.Checked = true;
                    cbPersuasion.Checked = true;
                    cbPsicoanalisis.Checked = true;
                    cbCharlataneria.Checked = true;
                    break;

                case "Médico":
                    cbMedicina.Checked = true;
                    cbPrimerosAuxilios.Checked = true;
                    cbPsicoanalisis.Checked = true;
                    cbPsicologuia.Checked = true;
                    cbBuscarlibros.Checked = true;
                    cbAntropologuia.Checked = true;
                    break;

                case "Profesor de universidad":
                    cbAntropologuia.Checked = true;
                    cbArqueologuia.Checked = true;
                    cbArte.Checked = true;
                    cbBuscarlibros.Checked = true;
                    cbCiencia.Checked = true;
                    cbContavilidad.Checked = true;
                    cbDerecho.Checked = true;
                    cbHistoria.Checked = true;
                    cbMecanica.Checked = true;
                    cbMedicina.Checked = true;
                    cbNaturaleza.Checked = true;
                    cbPsicoanalisis.Checked = true;
                    cbPsicologuia.Checked = true;
                    break;

                case "Abogado":
                    cbBuscarlibros.Checked = true;
                    cbCharlataneria.Checked = true;
                    cbCredito.Checked = true;
                    cbDerecho.Checked = true;
                    cbPersuasion.Checked = true;
                    cbPsicologuia.Checked = true;
                    cbDescubrir.Checked = true;
                    break;

                case "Artista":
                    cbArte.Checked = true;
                    cbCharlataneria.Checked = true;
                    cbDescubrir.Checked = true;
                    cbHistoria.Checked = true;
                    cbPsicologuia.Checked = true;
                    break;

                case "Clérigo":
                    cbBuscarlibros.Checked = true;
                    cbContavilidad.Checked = true;
                    cbEscuchar.Checked = true;
                    cbHistoria.Checked = true;
                    cbPersuasion.Checked = true;
                    cbPsicologuia.Checked = true;
                    break;

                case "Granjero/guardabosques":
                    cbConducirMaquinaria.Checked = true;
                    cbElectricidad.Checked = true;
                    cbArte.Checked = true;
                    cbNaturaleza.Checked = true;
                    cbMecanica.Checked = true;
                    cbOrientarse.Checked = true;
                    break;

                case "Músico":
                    cbCharlataneria.Checked = true;
                    cbEscuchar.Checked = true;
                    cbArte.Checked = true;
                    cbPersuasion.Checked = true;
                    cbPsicologuia.Checked = true;
                    break;

                case "Orador":
                    cbCharlataneria.Checked = true;
                    cbCredito.Checked = true;
                    cbDisfrazarse.Checked = true;
                    cbEsquivar.Checked = true;
                    cbPersuasion.Checked = true;
                    break;

                case "Parapsicólogo":
                    cbPsicologuia.Checked = true;
                    cbPsicoanalisis.Checked = true;
                    cbCharlataneria.Checked = true;
                    cbAntropologuia.Checked = true;
                    cbBuscarlibros.Checked = true;
                    cbCienciasOcultas.Checked = true;
                    cbHistoria.Checked = true;
                    break;

                case "Trotamundos":
                    cbCharlataneria.Checked = true;
                    cbSigilo.Checked = true;
                    cbEsquivar.Checked = true;
                    cbEscuchar.Checked = true;
                    cbNaturaleza.Checked = true;
                    cbPrimerosAuxilios.Checked = true;
                    break;

                default:
                    MessageBox.Show("Devido a que el trabajo que has escoguido no esta en la lista, no se podran marcar con un check la habilidades correspondientes", "Otros Trabajos", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    break;

            }
        }



        /// este conjunto de metodos llama al metodo ests con los distintos valores
        private void btnFuerza_Click(object sender, EventArgs e)
        {
            ests(lbExtremoFuerza, lbDificilFuerza, nudFuerza, generadorRandom(3));
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            ests(lbExtremoCons, lbDificilCons, nudCons, generadorRandom(3));
        }

        private void btnTam_Click(object sender, EventArgs e)
        {
            ests(lbExtremoTam, lbDificilTam, nudTam, generadorRandom(2) + 6);
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            ests(lbExtremoDes, lbDificilDes, nudDes, generadorRandom(3));
        }

        private void btnApa_Click(object sender, EventArgs e)
        {
            ests(lbExtremoApa, lbDificilApa, nudApa, generadorRandom(3));
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            ests(lbExtremoInt, lbDificilInt, nudInt, generadorRandom(2)+6);
        }

        private void btnPod_Click(object sender, EventArgs e)
        {
            ests(lbExtremoPod, lbDificilPod, nudPod, generadorRandom(3));
        }

        private void btnEdu_Click(object sender, EventArgs e)
        {
            ests(lbExtremoEdu, lbDificilEdu, nudEdu, generadorRandom(3)+2);
        }



        /// <summary>
        /// Este boton recalcula y coloca los valores a los distintos controles.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia <see cref="EventArgs"/> que contiene los datos del evento.</param>
        private void btnRecalcular_Click(object sender, EventArgs e)
        {

            edad();

            recalculo();

            movimiento();

            lbVida.Text = (Convert.ToInt32(lbExtremoTam.Text) + Convert.ToInt32(lbExtremoCons.Text)) / 2 + "";
            lbMP.Text = Convert.ToInt32(lbExtremoPod.Text) + "";
            lbCordura.Text = Convert.ToInt32(lbExtremoPod.Text) + "";
            lbSuerte.Text = generadorRandom(3) + "";

            lbPunTrabajo.Text = Convert.ToInt32(lbExtremoEdu.Text) * 20 + "";
            lbPuntPropios.Text = Convert.ToInt32(lbExtremoInt.Text) * 10 + "";

            esquivarNumericUpDown.Value = Convert.ToInt32(lbDificilDes.Text);

            comprobarTrabajo();
            AsignarDificultad();
        }

        /// <summary>
        /// Este metodo hace los cambios de la edad se apliquen
        /// </summary>
        private void edad()
        {
            if (nudEdad.Value > 30)
            {
                int mallorQue = Convert.ToInt32(nudEdad.Value) - 40;
                while (mallorQue > 10)
                {
                    if (nudFuerza.Value > 5) { nudFuerza.Value = nudFuerza.Value - 1; }
                    if (nudCons.Value > 5) { nudCons.Value = nudCons.Value - 1; }
                    if (nudDes.Value > 5) { nudDes.Value = nudDes.Value - 1; }
                    if (nudApa.Value > 5) { nudApa.Value = nudApa.Value - 1; }
                    if (nudFuerza.Value < 95) { nudEdu.Value = nudEdu.Value + 5; }

                    mallorQue -= 10;
                }
            }
        }

        /// <summary>
        /// Este metodo determina que valor le corresponde a la estadistica de Mov
        /// </summary>
        private void movimiento()
        {
            if ((nudTam.Value > nudCons.Value) && (nudTam.Value > nudFuerza.Value))
            {
                lbMov.Text = "7";
            }
            else if ((nudTam.Value == nudCons.Value) || (nudTam.Value == nudFuerza.Value))
            {
                lbMov.Text = "8";
            }
            else if ((nudTam.Value < nudCons.Value) && (nudTam.Value < nudFuerza.Value))
            {
                lbMov.Text = "9";
            }
        }

        /// <summary>
        /// Este metodo comprueba que las estadisticas esten bien y en caso de que no coloca el valor que les corresponde
        /// </summary>
        private void recalculo()
        {
            if (Convert.ToInt32(nudFuerza.Value / 5) != Convert.ToInt32(lbExtremoFuerza.Text)) { }
            {
                int estFuer = Convert.ToInt32(nudFuerza.Value);
                lbExtremoFuerza.Text = "" + estFuer / 5;
                lbDificilFuerza.Text = "" + estFuer / 2;
            }
            if (Convert.ToInt32(lbExtremoCons.Text) != Convert.ToInt32(nudCons.Value / 5))
            {
                int estCons = Convert.ToInt32(nudCons.Value);
                lbExtremoCons.Text = "" + estCons / 5;
                lbDificilCons.Text = "" + estCons / 2;
            }

            if (Convert.ToInt32(lbExtremoTam.Text) != Convert.ToInt32(nudTam.Value / 5))
            {
                int estTam = Convert.ToInt32(nudTam.Value);
                lbExtremoTam.Text = "" + estTam / 5;
                lbDificilTam.Text = "" + estTam / 2;
            }

            if (Convert.ToInt32(lbExtremoDes.Text) != Convert.ToInt32(nudDes.Value / 5))
            {
                int estDes = Convert.ToInt32(nudDes.Value);
                lbExtremoDes.Text = "" + estDes / 5;
                lbDificilDes.Text = "" + estDes / 2;
                esquivarNumericUpDown.Value = Convert.ToInt32(lbDificilDes.Text);
            }

            if (Convert.ToInt32(lbExtremoApa.Text) != Convert.ToInt32(nudApa.Value / 5))
            {
                int estApa = Convert.ToInt32(nudApa.Value);
                lbExtremoApa.Text = "" + estApa / 5;
                lbDificilApa.Text = "" + estApa / 2;
            }

            if (Convert.ToInt32(lbExtremoInt.Text) != Convert.ToInt32(nudInt.Value / 5))
            {
                int estInt = Convert.ToInt32(nudInt.Value);
                lbExtremoInt.Text = "" + estInt / 5;
                lbDificilInt.Text = "" + estInt / 2;
            }

            if (Convert.ToInt32(lbExtremoPod.Text) != Convert.ToInt32(nudPod.Value / 5))
            {
                int estPod = Convert.ToInt32(nudPod.Value);
                lbExtremoPod.Text = "" + estPod / 5;
                lbDificilPod.Text = "" + estPod / 2;
            }
            if (Convert.ToInt32(lbExtremoEdu.Text) != Convert.ToInt32(nudEdu.Value / 5))
            {
                int estEdu = Convert.ToInt32(nudEdu.Value);
                lbExtremoEdu.Text = "" + estEdu / 5;
                lbDificilEdu.Text = "" + estEdu / 2;
            }
        }


        /// estos metodos se ocupan de llamar al metodo cambiosHabilidades y enviarles la informacion
        /// cuando modificas los NumericUpDown
        private void antropologuiaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(0, antropologuiaNumericUpDown, cbAntropologuia);
        }

        private void armacortaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(1, armacortaNumericUpDown, cbArmaCorta);
            AsignarDificultad();
        }

        private void fusilYescopetaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(2, fusilYescopetaNumericUpDown, cbRiflesEscopetas);
            AsignarDificultad();
        }

        private void arqueologuiaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(3, arqueologuiaNumericUpDown, cbArqueologuia);
        }
        private void arteYartesaniaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(4, arteYartesaniaNumericUpDown, cbArte);
        }

        private void buscarlibrosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(5, buscarlibrosNumericUpDown, cbBuscarlibros);
        }

        private void cerrajeriaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(6, cerrajeriaNumericUpDown, cbCerrajeria);
        }

        private void charlataneriaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(7, charlataneriaNumericUpDown, cbCharlataneria);
        }

        private void cienciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(8, cienciaNumericUpDown, cbCiencia);
        }

        private void cienciasocultasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(9, cienciasocultasNumericUpDown, cbCienciasOcultas);
        }

        private void peleaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(10, peleaNumericUpDown, cbPelea);
            AsignarDificultad();
        }

        private void conducirautomovilNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(11, conducirautomovilNumericUpDown, cbConducirAutomovil);
        }

        private void conducirmaquinariaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(12, conducirmaquinariaNumericUpDown, cbConducirMaquinaria);
        }

        private void contavilidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(13, contavilidadNumericUpDown, cbContavilidad);
        }

        private void creditoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(14, creditoNumericUpDown, cbCredito);
        }

        private void derechoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(15, derechoNumericUpDown, cbDerecho);
        }

        private void descubrirNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(16, descubrirNumericUpDown, cbDescubrir);
        }

        private void disfrazarseNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(17, disfrazarseNumericUpDown, cbDisfrazarse);
        }

        private void electricidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(18, electricidadNumericUpDown, cbElectricidad);
        }

        private void encantoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(19, encantoNumericUpDown, cbEncanto);
        }

        private void equitacionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(20, equitacionNumericUpDown, cbEquitacion);
        }

        private void escucharNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(21, escucharNumericUpDown, cbEscuchar);
        }

        private void esquivarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(22, esquivarNumericUpDown, cbEsquivar);
        }

        private void historiaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(23, historiaNumericUpDown,cbHistoria);
        }

        private void intimidarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(24, intimidarNumericUpDown,cbIntimidar);
        }

        private void juegomanosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(25, juegomanosNumericUpDown, cbJuegoManos);
        }

        private void lanzarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(26, lanzarNumericUpDown, cbLanzar);
        }

        private void mecanicaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(27, mecanicaNumericUpDown, cbMecanica);
        }

        private void medicinaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(28, medicinaNumericUpDown, cbMedicina);
        }

        private void mitoscthulhuNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(29, mitoscthulhuNumericUpDown, cbMitosCth);
        }

        private void nadarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(30, nadarNumericUpDown, cbNadar);
        }

        private void naturalezaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(31, naturalezaNumericUpDown, cbNaturaleza);
        }

        private void orientarseNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(32, orientarseNumericUpDown, cbOrientarse);
        }

        private void persuasionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(33, persuasionNumericUpDown, cbPersuasion);
        }

        private void pilotarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(34, pilotarNumericUpDown, cbPilotar);
        }

        private void primerosauxiliosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(35, primerosauxiliosNumericUpDown, cbPrimerosAuxilios);
        }

        private void psicoanalisisNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(36, psicoanalisisNumericUpDown, cbPsicoanalisis);
        }

        private void psicologuiaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(37, psicologuiaNumericUpDown, cbPsicologuia);
        }

        private void saltarNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(38, saltarNumericUpDown, cbSaltar);
        }

        private void seguirrastoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(39, seguirrastoNumericUpDown, cbSeguirRasto);
        }

        private void sigiloNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(40, sigiloNumericUpDown, cbSigilo);
        }

        private void supervivenciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(41, supervivenciaNumericUpDown, cbSupervivencia);
        }

        private void tasacionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(42, tasacionNumericUpDown, cbTasacion);
        }

        private void treparNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cambiosHabilidades(43, treparNumericUpDown, cbTrepar);
        }

        /// <summary>
        /// Al pulsar el boton guardar se envian los datos a la base de datos mendiante el metodo insert
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia <see cref="EventArgs"/> que contiene los datos del evento.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.habilidadesTableAdapter.Fill(this.llamada_de_cthulhuDataSet.habilidades);
            this.personajeTableAdapter.Fill(this.llamada_de_cthulhuDataSet.personaje);

            if ((Convert.ToInt32(lbPunTrabajo.Text) < 0)||(Convert.ToInt32(lbPuntPropios.Text) < 0))
            {
                MessageBox.Show("los numeros de las habilidades no pueden ser negativos", "no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                personajeTableAdapter.Insert(tbNombre.Text, tbJugador.Text, Convert.ToInt32(nudEdad.Value), Convert.ToInt32(lbVida.Text),
                Convert.ToInt32(lbMP.Text), Convert.ToInt32(lbCordura.Text), Convert.ToInt32(lbSuerte.Text),
                Convert.ToInt32(nudFuerza.Value), Convert.ToInt32(nudDes.Value), Convert.ToInt32(nudPod.Value),
                Convert.ToInt32(nudCons.Value), Convert.ToInt32(nudApa.Value), Convert.ToInt32(nudEdu.Value),
                Convert.ToInt32(nudTam.Value), Convert.ToInt32(nudInt.Value), Convert.ToInt32(lbMov.Text));


                habilidadesTableAdapter.Insert(Convert.ToInt32(personajeTableAdapter.GetOnId()), Convert.ToInt32(antropologuiaNumericUpDown.Value),
                    Convert.ToInt32(armacortaNumericUpDown.Value), Convert.ToInt32(fusilYescopetaNumericUpDown.Value),
                    Convert.ToInt32(arqueologuiaNumericUpDown.Value), Convert.ToInt32(arteYartesaniaNumericUpDown.Value),
                    Convert.ToInt32(buscarlibrosNumericUpDown.Value), Convert.ToInt32(cerrajeriaNumericUpDown.Value),
                    Convert.ToInt32(charlataneriaNumericUpDown.Value), Convert.ToInt32(cienciaNumericUpDown.Value),
                    Convert.ToInt32(cienciasocultasNumericUpDown.Value), Convert.ToInt32(peleaNumericUpDown.Value),
                    Convert.ToInt32(conducirautomovilNumericUpDown.Value), Convert.ToInt32(conducirmaquinariaNumericUpDown.Value),
                    Convert.ToInt32(contavilidadNumericUpDown.Value), Convert.ToInt32(creditoNumericUpDown.Value),
                    Convert.ToInt32(derechoNumericUpDown.Value), Convert.ToInt32(descubrirNumericUpDown.Value),
                    Convert.ToInt32(disfrazarseNumericUpDown.Value), Convert.ToInt32(electricidadNumericUpDown.Value),
                    Convert.ToInt32(encantoNumericUpDown.Value), Convert.ToInt32(equitacionNumericUpDown.Value),
                    Convert.ToInt32(escucharNumericUpDown.Value), Convert.ToInt32(esquivarNumericUpDown.Value),
                    Convert.ToInt32(historiaNumericUpDown.Value), Convert.ToInt32(intimidarNumericUpDown.Value),
                    Convert.ToInt32(juegomanosNumericUpDown.Value), Convert.ToInt32(lanzarNumericUpDown.Value),
                    Convert.ToInt32(mecanicaNumericUpDown.Value), Convert.ToInt32(medicinaNumericUpDown.Value),
                    Convert.ToInt32(mitoscthulhuNumericUpDown.Value), Convert.ToInt32(nadarNumericUpDown.Value),
                    Convert.ToInt32(naturalezaNumericUpDown.Value), Convert.ToInt32(orientarseNumericUpDown.Value),
                    Convert.ToInt32(persuasionNumericUpDown.Value), Convert.ToInt32(pilotarNumericUpDown.Value),
                    Convert.ToInt32(primerosauxiliosNumericUpDown.Value),
                    Convert.ToInt32(psicoanalisisNumericUpDown.Value), Convert.ToInt32(psicologuiaNumericUpDown.Value),
                    Convert.ToInt32(saltarNumericUpDown.Value), Convert.ToInt32(seguirrastoNumericUpDown.Value),
                    Convert.ToInt32(sigiloNumericUpDown.Value), Convert.ToInt32(supervivenciaNumericUpDown.Value),
                    Convert.ToInt32(tasacionNumericUpDown.Value), Convert.ToInt32(treparNumericUpDown.Value));

                equipadoTableAdapter.Insert(Convert.ToInt32(personajeTableAdapter.GetOnId()), Convert.ToInt32(id_armaTextBox.Text),
                    Convert.ToInt32(lbDificulNormal.Text), Convert.ToInt32(lbDificulDificil.Text), Convert.ToInt32(lbDificulExtremo.Text));

                MessageBox.Show("El personaje se a creado con exito", "creada con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }

        }

        private void Cthulhu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'llamada_de_cthulhuDataSet.equipado' Puede moverla o quitarla según sea necesario.
            this.equipadoTableAdapter.Fill(this.llamada_de_cthulhuDataSet.equipado);
            // TODO: esta línea de código carga datos en la tabla 'llamada_de_cthulhuDataSet.equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.llamada_de_cthulhuDataSet.equipo);

            AsignarDificultad();

        }

        private void nombreComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            AsignarDificultad();
        }
        /// <summary>
        /// Este metodo permite que se asigne la difultad de cada arma de forma automatica
        /// </summary>
        private void AsignarDificultad()
        {
            switch (corto_largoTextBox.Text)
            {
                case "0":
                    lbDificulNormal.Text = armacortaNumericUpDown.Value + "";
                    lbDificulDificil.Text = Convert.ToInt32(armacortaNumericUpDown.Value / 2) + "";
                    lbDificulExtremo.Text = Convert.ToInt32(armacortaNumericUpDown.Value / 5) + "";
                    break;
                case "1":
                    lbDificulNormal.Text = fusilYescopetaNumericUpDown.Value + "";
                    lbDificulDificil.Text = Convert.ToInt32(fusilYescopetaNumericUpDown.Value / 2) + "";
                    lbDificulExtremo.Text = Convert.ToInt32(fusilYescopetaNumericUpDown.Value / 5) + "";
                    break;
                case "2":
                    lbDificulNormal.Text = peleaNumericUpDown.Value + "";
                    lbDificulDificil.Text = Convert.ToInt32(peleaNumericUpDown.Value / 2) + "";
                    lbDificulExtremo.Text = Convert.ToInt32(peleaNumericUpDown.Value / 5) + "";
                    break;
            }
        }
    }
}
