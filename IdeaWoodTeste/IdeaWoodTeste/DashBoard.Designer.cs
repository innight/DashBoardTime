namespace IdeaWoodTeste
{
    partial class DashBoard
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
            this.bRecolherMarcacoes = new System.Windows.Forms.Button();
            this.bProcessar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bGerarMapa = new System.Windows.Forms.Button();
            this.CheckIndividualPorObra = new System.Windows.Forms.CheckBox();
            this.checkIndividualPorTipo = new System.Windows.Forms.CheckBox();
            this.checkIndividualMensal = new System.Windows.Forms.CheckBox();
            this.checkobraportotaldehoras = new System.Windows.Forms.CheckBox();
            this.checkObraPorTipo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bRecolherMarcacoes
            // 
            this.bRecolherMarcacoes.Location = new System.Drawing.Point(12, 419);
            this.bRecolherMarcacoes.Name = "bRecolherMarcacoes";
            this.bRecolherMarcacoes.Size = new System.Drawing.Size(178, 23);
            this.bRecolherMarcacoes.TabIndex = 0;
            this.bRecolherMarcacoes.Text = "Recolher as Marcações";
            this.bRecolherMarcacoes.UseVisualStyleBackColor = true;
            // 
            // bProcessar
            // 
            this.bProcessar.Location = new System.Drawing.Point(12, 468);
            this.bProcessar.Name = "bProcessar";
            this.bProcessar.Size = new System.Drawing.Size(178, 23);
            this.bProcessar.TabIndex = 1;
            this.bProcessar.Text = "Processar";
            this.bProcessar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(12, 233);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Até :";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(213, 37);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(896, 689);
            this.crystalReportViewer1.TabIndex = 8;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // bGerarMapa
            // 
            this.bGerarMapa.Location = new System.Drawing.Point(12, 640);
            this.bGerarMapa.Name = "bGerarMapa";
            this.bGerarMapa.Size = new System.Drawing.Size(178, 86);
            this.bGerarMapa.TabIndex = 9;
            this.bGerarMapa.Text = "Gerar Mapa";
            this.bGerarMapa.UseVisualStyleBackColor = true;
            this.bGerarMapa.Click += new System.EventHandler(this.bGerarMapa_Click);
            // 
            // CheckIndividualPorObra
            // 
            this.CheckIndividualPorObra.AutoSize = true;
            this.CheckIndividualPorObra.Location = new System.Drawing.Point(12, 508);
            this.CheckIndividualPorObra.Name = "CheckIndividualPorObra";
            this.CheckIndividualPorObra.Size = new System.Drawing.Size(115, 17);
            this.CheckIndividualPorObra.TabIndex = 10;
            this.CheckIndividualPorObra.Text = "Individual por Obra";
            this.CheckIndividualPorObra.UseVisualStyleBackColor = true;
            // 
            // checkIndividualPorTipo
            // 
            this.checkIndividualPorTipo.AutoSize = true;
            this.checkIndividualPorTipo.Location = new System.Drawing.Point(12, 531);
            this.checkIndividualPorTipo.Name = "checkIndividualPorTipo";
            this.checkIndividualPorTipo.Size = new System.Drawing.Size(146, 17);
            this.checkIndividualPorTipo.TabIndex = 11;
            this.checkIndividualPorTipo.Text = "Individual por tipo(E,D,IV)";
            this.checkIndividualPorTipo.UseVisualStyleBackColor = true;
            // 
            // checkIndividualMensal
            // 
            this.checkIndividualMensal.AutoSize = true;
            this.checkIndividualMensal.Location = new System.Drawing.Point(12, 554);
            this.checkIndividualMensal.Name = "checkIndividualMensal";
            this.checkIndividualMensal.Size = new System.Drawing.Size(108, 17);
            this.checkIndividualMensal.TabIndex = 12;
            this.checkIndividualMensal.Text = "Individual Mensal";
            this.checkIndividualMensal.UseVisualStyleBackColor = true;
            // 
            // checkobraportotaldehoras
            // 
            this.checkobraportotaldehoras.AutoSize = true;
            this.checkobraportotaldehoras.Location = new System.Drawing.Point(12, 577);
            this.checkobraportotaldehoras.Name = "checkobraportotaldehoras";
            this.checkobraportotaldehoras.Size = new System.Drawing.Size(134, 17);
            this.checkobraportotaldehoras.TabIndex = 13;
            this.checkobraportotaldehoras.Text = "Obra por total de horas";
            this.checkobraportotaldehoras.UseVisualStyleBackColor = true;
            // 
            // checkObraPorTipo
            // 
            this.checkObraPorTipo.AutoSize = true;
            this.checkObraPorTipo.Location = new System.Drawing.Point(12, 600);
            this.checkObraPorTipo.Name = "checkObraPorTipo";
            this.checkObraPorTipo.Size = new System.Drawing.Size(129, 17);
            this.checkObraPorTipo.TabIndex = 14;
            this.checkObraPorTipo.Text = "Obra Por Tipo(E,D,IV)";
            this.checkObraPorTipo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkObraPorTipo);
            this.Controls.Add(this.checkobraportotaldehoras);
            this.Controls.Add(this.checkIndividualMensal);
            this.Controls.Add(this.checkIndividualPorTipo);
            this.Controls.Add(this.CheckIndividualPorObra);
            this.Controls.Add(this.bGerarMapa);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bProcessar);
            this.Controls.Add(this.bRecolherMarcacoes);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRecolherMarcacoes;
        private System.Windows.Forms.Button bProcessar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button bGerarMapa;
        private System.Windows.Forms.CheckBox CheckIndividualPorObra;
        private System.Windows.Forms.CheckBox checkIndividualPorTipo;
        private System.Windows.Forms.CheckBox checkIndividualMensal;
        private System.Windows.Forms.CheckBox checkobraportotaldehoras;
        private System.Windows.Forms.CheckBox checkObraPorTipo;
        private System.Windows.Forms.Button button1;
    }
}