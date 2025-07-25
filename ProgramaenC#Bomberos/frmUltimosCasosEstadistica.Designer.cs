namespace SistemaBSPC
{
    partial class frmUltimosCasosEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUltimosCasosEstadistica));
            this.gbEstadisticaas = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbMostrar = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbEstadisticaas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEstadisticaas
            // 
            this.gbEstadisticaas.Controls.Add(this.radioButton1);
            this.gbEstadisticaas.Controls.Add(this.rbMostrar);
            this.gbEstadisticaas.Controls.Add(this.chart1);
            this.gbEstadisticaas.Location = new System.Drawing.Point(12, 12);
            this.gbEstadisticaas.Name = "gbEstadisticaas";
            this.gbEstadisticaas.Size = new System.Drawing.Size(1240, 657);
            this.gbEstadisticaas.TabIndex = 0;
            this.gbEstadisticaas.TabStop = false;
            this.gbEstadisticaas.Text = "Estadísticas Generales";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(1063, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 30);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Ocultar gráficas";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMostrar
            // 
            this.rbMostrar.AutoSize = true;
            this.rbMostrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbMostrar.Checked = true;
            this.rbMostrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbMostrar.Location = new System.Drawing.Point(875, 32);
            this.rbMostrar.Name = "rbMostrar";
            this.rbMostrar.Size = new System.Drawing.Size(173, 30);
            this.rbMostrar.TabIndex = 4;
            this.rbMostrar.TabStop = true;
            this.rbMostrar.Text = "Mostrar gráficas";
            this.rbMostrar.UseVisualStyleBackColor = false;
            this.rbMostrar.CheckedChanged += new System.EventHandler(this.rbMostrar_CheckedChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Lejjj";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 68);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedDownwardDiagonal;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Lejjj";
            series1.Name = "Intervenciones Del Cuerpo De Bomberos";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1228, 564);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // frmUltimosCasosEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbEstadisticaas);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUltimosCasosEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística de los últimos casos registrados";
            this.Load += new System.EventHandler(this.frmUltimosCasosEstadistica_Load);
            this.gbEstadisticaas.ResumeLayout(false);
            this.gbEstadisticaas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEstadisticaas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbMostrar;
    }
}