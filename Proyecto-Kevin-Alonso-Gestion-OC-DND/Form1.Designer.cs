
namespace Proyecto_Kevin_Alonso_Gestion_OC_DND
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaLaLlamadaDeCathuluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPersonajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPersonajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirArmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmNuevoPersonaje = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrdenar = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.numeroPersonajes = new System.Windows.Forms.ToolStripStatusLabel();
            this.llamada_de_cthulhuDataSet = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSet();
            this.personajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personajeTableAdapter = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.personajeTableAdapter();
            this.tableAdapterManager = new Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llamada_de_cthulhuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaLaLlamadaDeCathuluToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaLaLlamadaDeCathuluToolStripMenuItem
            // 
            this.sistemaLaLlamadaDeCathuluToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPersonajeToolStripMenuItem,
            this.editarPersonajesToolStripMenuItem});
            this.sistemaLaLlamadaDeCathuluToolStripMenuItem.Image = global::Proyecto_Kevin_Alonso_Gestion_OC_DND.Properties.Resources.cthulhu;
            this.sistemaLaLlamadaDeCathuluToolStripMenuItem.Name = "sistemaLaLlamadaDeCathuluToolStripMenuItem";
            this.sistemaLaLlamadaDeCathuluToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.sistemaLaLlamadaDeCathuluToolStripMenuItem.Text = "La llamada de Cathulu";
            // 
            // crearPersonajeToolStripMenuItem
            // 
            this.crearPersonajeToolStripMenuItem.Name = "crearPersonajeToolStripMenuItem";
            this.crearPersonajeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearPersonajeToolStripMenuItem.Text = "Crear personaje";
            this.crearPersonajeToolStripMenuItem.Click += new System.EventHandler(this.crearPersonajeToolStripMenuItem_Click);
            // 
            // editarPersonajesToolStripMenuItem
            // 
            this.editarPersonajesToolStripMenuItem.Name = "editarPersonajesToolStripMenuItem";
            this.editarPersonajesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarPersonajesToolStripMenuItem.Text = "Editar personajes";
            this.editarPersonajesToolStripMenuItem.Click += new System.EventHandler(this.listaDePersonajesToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirArmaToolStripMenuItem,
            this.personajesToolStripMenuItem,
            this.ordenarToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.gestionToolStripMenuItem.Text = "gestion";
            // 
            // añadirArmaToolStripMenuItem
            // 
            this.añadirArmaToolStripMenuItem.Name = "añadirArmaToolStripMenuItem";
            this.añadirArmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirArmaToolStripMenuItem.Text = "Añadir Arma";
            this.añadirArmaToolStripMenuItem.Click += new System.EventHandler(this.añadirArmaToolStripMenuItem_Click);
            // 
            // personajesToolStripMenuItem
            // 
            this.personajesToolStripMenuItem.Name = "personajesToolStripMenuItem";
            this.personajesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personajesToolStripMenuItem.Text = "Personajes";
            this.personajesToolStripMenuItem.Click += new System.EventHandler(this.personajesToolStripMenuItem_Click);
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalmenteToolStripMenuItem,
            this.horizontalToolStripMenuItem1});
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            // 
            // verticalmenteToolStripMenuItem
            // 
            this.verticalmenteToolStripMenuItem.Name = "verticalmenteToolStripMenuItem";
            this.verticalmenteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalmenteToolStripMenuItem.Text = "Vertical";
            this.verticalmenteToolStripMenuItem.Click += new System.EventHandler(this.verticalmenteToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem1
            // 
            this.horizontalToolStripMenuItem1.Name = "horizontalToolStripMenuItem1";
            this.horizontalToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem1.Text = "Horizontal";
            this.horizontalToolStripMenuItem1.Click += new System.EventHandler(this.horizontalToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevoPersonaje,
            this.tsmOrdenar,
            this.cerrarVentanasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            // 
            // tsmNuevoPersonaje
            // 
            this.tsmNuevoPersonaje.Name = "tsmNuevoPersonaje";
            this.tsmNuevoPersonaje.Size = new System.Drawing.Size(138, 22);
            this.tsmNuevoPersonaje.Text = "Nuevo Personaje";
            this.tsmNuevoPersonaje.Click += new System.EventHandler(this.tsmNuevoPersonaje_Click);
            // 
            // tsmOrdenar
            // 
            this.tsmOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.tsmOrdenar.Name = "tsmOrdenar";
            this.tsmOrdenar.Size = new System.Drawing.Size(138, 22);
            this.tsmOrdenar.Text = "Ordenar";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // cerrarVentanasToolStripMenuItem
            // 
            this.cerrarVentanasToolStripMenuItem.Name = "cerrarVentanasToolStripMenuItem";
            this.cerrarVentanasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cerrarVentanasToolStripMenuItem.Text = "Cerrar ventanas";
            this.cerrarVentanasToolStripMenuItem.Click += new System.EventHandler(this.cerrarVentanasToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeroPersonajes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // numeroPersonajes
            // 
            this.numeroPersonajes.Name = "numeroPersonajes";
            this.numeroPersonajes.Size = new System.Drawing.Size(140, 17);
            this.numeroPersonajes.Text = "Hay 0 personajes creados";
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
            this.tableAdapterManager.equipadoTableAdapter = null;
            this.tableAdapterManager.equipoTableAdapter = null;
            this.tableAdapterManager.habilidadesTableAdapter = null;
            this.tableAdapterManager.personajeTableAdapter = this.personajeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_Kevin_Alonso_Gestion_OC_DND.llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://kevinalonso5.github.io";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Gestor de personajes para Rol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llamada_de_cthulhuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personajeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaLaLlamadaDeCathuluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPersonajeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevoPersonaje;
        private System.Windows.Forms.ToolStripMenuItem tsmOrdenar;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel numeroPersonajes;
        private System.Windows.Forms.BindingSource personajeBindingSource;
        private llamada_de_cthulhuDataSet llamada_de_cthulhuDataSet;
        private llamada_de_cthulhuDataSetTableAdapters.personajeTableAdapter personajeTableAdapter;
        private llamada_de_cthulhuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem editarPersonajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalmenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem añadirArmaToolStripMenuItem;
    }
}

