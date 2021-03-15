
namespace Proyecto_Kevin_Alonso_Gestion_OC_DND
{
    partial class PersonajesDeCadaJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonajesDeCadaJugador));
            this.llamada_de_cthulhuDataSet = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSet();
            this.personajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personajeTableAdapter = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.personajeTableAdapter();
            this.tableAdapterManager = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager();
            this.habilidadesTableAdapter = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.habilidadesTableAdapter();
            this.personajeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fKhabilidadtrepa4F7CD00DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnJugador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJugador = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.llamada_de_cthulhuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKhabilidadtrepa4F7CD00DBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // llamada_de_cthulhuDataSet
            // 
            this.llamada_de_cthulhuDataSet.DataSetName = "llamada_de_cthulhuDataSet";
            this.llamada_de_cthulhuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personajeBindingSource
            // 
            this.personajeBindingSource.DataMember = "personaje";
            this.personajeBindingSource.DataSource = this.llamada_de_cthulhuDataSet;
            // 
            // personajeTableAdapter
            // 
            this.personajeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.habilidadesTableAdapter = this.habilidadesTableAdapter;
            this.tableAdapterManager.personajeTableAdapter = this.personajeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // habilidadesTableAdapter
            // 
            this.habilidadesTableAdapter.ClearBeforeFill = true;
            // 
            // personajeDataGridView
            // 
            this.personajeDataGridView.AllowUserToAddRows = false;
            this.personajeDataGridView.AllowUserToDeleteRows = false;
            this.personajeDataGridView.AutoGenerateColumns = false;
            this.personajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.personajeDataGridView.DataSource = this.personajeBindingSource;
            this.personajeDataGridView.Location = new System.Drawing.Point(14, 92);
            this.personajeDataGridView.Name = "personajeDataGridView";
            this.personajeDataGridView.ReadOnly = true;
            this.personajeDataGridView.Size = new System.Drawing.Size(845, 220);
            this.personajeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "jugador";
            this.dataGridViewTextBoxColumn3.HeaderText = "jugador";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "edad";
            this.dataGridViewTextBoxColumn4.HeaderText = "edad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "puntosvida";
            this.dataGridViewTextBoxColumn5.HeaderText = "puntosvida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "puntosmaguia";
            this.dataGridViewTextBoxColumn6.HeaderText = "puntosmaguia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cordura";
            this.dataGridViewTextBoxColumn7.HeaderText = "cordura";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "suerte";
            this.dataGridViewTextBoxColumn8.HeaderText = "suerte";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(70, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(192, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar por nombre";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fKhabilidadtrepa4F7CD00DBindingSource
            // 
            this.fKhabilidadtrepa4F7CD00DBindingSource.DataMember = "FK__habilidad__trepa__4F7CD00D";
            this.fKhabilidadtrepa4F7CD00DBindingSource.DataSource = this.personajeBindingSource;
            // 
            // btnJugador
            // 
            this.btnJugador.Location = new System.Drawing.Point(192, 52);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(117, 23);
            this.btnJugador.TabIndex = 9;
            this.btnJugador.Text = "Buscar por Jugador";
            this.btnJugador.UseVisualStyleBackColor = true;
            this.btnJugador.Click += new System.EventHandler(this.btnJugador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jugador";
            // 
            // tbJugador
            // 
            this.tbJugador.Location = new System.Drawing.Point(70, 54);
            this.tbJugador.Name = "tbJugador";
            this.tbJugador.Size = new System.Drawing.Size(100, 20);
            this.tbJugador.TabIndex = 7;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://kevinalonso5.github.io/Gestionpersonajes.html";
            // 
            // PersonajesDeCadaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 323);
            this.Controls.Add(this.btnJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJugador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.personajeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonajesDeCadaJugador";
            this.Text = "PersonajesDeCadaJugador";
            this.Load += new System.EventHandler(this.PersonajesDeCadaJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.llamada_de_cthulhuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKhabilidadtrepa4F7CD00DBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private llamada_de_cthulhuDataSet llamada_de_cthulhuDataSet;
        private System.Windows.Forms.BindingSource personajeBindingSource;
        private llamada_de_cthulhuDataSetTableAdapters.personajeTableAdapter personajeTableAdapter;
        private llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personajeDataGridView;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private llamada_de_cthulhuDataSetTableAdapters.habilidadesTableAdapter habilidadesTableAdapter;
        private System.Windows.Forms.BindingSource fKhabilidadtrepa4F7CD00DBindingSource;
        private System.Windows.Forms.Button btnJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJugador;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}