
namespace Proyecto_Kevin_Alonso_Gestion_OC_DND
{
    partial class añadirArma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(añadirArma));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDaño = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumAtac = new System.Windows.Forms.TextBox();
            this.tbAlcance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudMunicion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAveria = new System.Windows.Forms.NumericUpDown();
            this.cbTipoArma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.llamada_de_cthulhuDataSet = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSet();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoTableAdapter = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.equipoTableAdapter();
            this.tableAdapterManager = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.nudMunicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAveria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llamada_de_cthulhuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(18, 42);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbDaño
            // 
            this.tbDaño.Location = new System.Drawing.Point(124, 42);
            this.tbDaño.Name = "tbDaño";
            this.tbDaño.Size = new System.Drawing.Size(100, 20);
            this.tbDaño.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Daño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantida de ataques";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alcance";
            // 
            // tbNumAtac
            // 
            this.tbNumAtac.Location = new System.Drawing.Point(336, 43);
            this.tbNumAtac.Name = "tbNumAtac";
            this.tbNumAtac.Size = new System.Drawing.Size(100, 20);
            this.tbNumAtac.TabIndex = 9;
            // 
            // tbAlcance
            // 
            this.tbAlcance.Location = new System.Drawing.Point(230, 42);
            this.tbAlcance.Name = "tbAlcance";
            this.tbAlcance.Size = new System.Drawing.Size(100, 20);
            this.tbAlcance.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Punto de averia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(698, 100);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudMunicion
            // 
            this.nudMunicion.Location = new System.Drawing.Point(442, 42);
            this.nudMunicion.Name = "nudMunicion";
            this.nudMunicion.Size = new System.Drawing.Size(89, 20);
            this.nudMunicion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Municion";
            // 
            // nudAveria
            // 
            this.nudAveria.Location = new System.Drawing.Point(537, 42);
            this.nudAveria.Name = "nudAveria";
            this.nudAveria.Size = new System.Drawing.Size(100, 20);
            this.nudAveria.TabIndex = 17;
            // 
            // cbTipoArma
            // 
            this.cbTipoArma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoArma.FormattingEnabled = true;
            this.cbTipoArma.Items.AddRange(new object[] {
            "Arma Corta(pistolas)",
            "Arma Larga(Escopetas)",
            "Arma mele(Cuchillos)"});
            this.cbTipoArma.Location = new System.Drawing.Point(643, 41);
            this.cbTipoArma.Name = "cbTipoArma";
            this.cbTipoArma.Size = new System.Drawing.Size(121, 21);
            this.cbTipoArma.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tipo de arma";
            // 
            // llamada_de_cthulhuDataSet
            // 
            this.llamada_de_cthulhuDataSet.DataSetName = "llamada_de_cthulhuDataSet";
            this.llamada_de_cthulhuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "equipo";
            this.equipoBindingSource.DataSource = this.llamada_de_cthulhuDataSet;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.equipadoTableAdapter = null;
            this.tableAdapterManager.equipoTableAdapter = this.equipoTableAdapter;
            this.tableAdapterManager.habilidadesTableAdapter = null;
            this.tableAdapterManager.personajeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // añadirArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 136);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipoArma);
            this.Controls.Add(this.nudAveria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMunicion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumAtac);
            this.Controls.Add(this.tbAlcance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbDaño);
            this.Controls.Add(this.tbNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "añadirArma";
            this.Text = "añadirArma";
            this.Load += new System.EventHandler(this.añadirArma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMunicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAveria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llamada_de_cthulhuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private llamada_de_cthulhuDataSet llamada_de_cthulhuDataSet;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDaño;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumAtac;
        private System.Windows.Forms.TextBox tbAlcance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudMunicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAveria;
        private System.Windows.Forms.ComboBox cbTipoArma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private llamada_de_cthulhuDataSetTableAdapters.equipoTableAdapter equipoTableAdapter;
        private llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}