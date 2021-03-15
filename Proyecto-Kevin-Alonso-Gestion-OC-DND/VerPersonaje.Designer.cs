
namespace Proyecto_Kevin_Alonso_Gestion_OC_DND
{
    partial class VerPersonaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPersonaje));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Infome_con_graficos2 = new Proyecto_Kevin_Alonso_Gestion_OC_DND.Infome_con_graficos();
            this.Infome_con_graficos1 = new Proyecto_Kevin_Alonso_Gestion_OC_DND.Infome_con_graficos();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "D:\\Escritorio\\prollecto intefaces ultima version\\Proyecto-Kevin-Alonso-Gestion-OC" +
    "-DND\\verPersonaje.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1068, 1036);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.UseWaitCursor = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://kevinalonso5.github.io/Verlasfichasdepersonaje.html";
            // 
            // VerPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 1036);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerPersonaje";
            this.Text = "VerPersonaje";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Infome_con_graficos Infome_con_graficos2;
        private Infome_con_graficos Infome_con_graficos1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}