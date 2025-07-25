namespace SistemaBSPC
{
    partial class frmConsultaAvanzadaEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAvanzadaEstadistica));
            this.gbAvanzada = new System.Windows.Forms.GroupBox();
            this.rbNinguno = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAvanzada
            // 
            this.gbAvanzada.Controls.Add(this.rbNinguno);
            this.gbAvanzada.Controls.Add(this.button1);
            this.gbAvanzada.Controls.Add(this.label2);
            this.gbAvanzada.Controls.Add(this.dateTimePicker1);
            this.gbAvanzada.Controls.Add(this.radioButton3);
            this.gbAvanzada.Controls.Add(this.radioButton2);
            this.gbAvanzada.Controls.Add(this.radioButton1);
            this.gbAvanzada.Controls.Add(this.label1);
            this.gbAvanzada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvanzada.Location = new System.Drawing.Point(12, 12);
            this.gbAvanzada.Name = "gbAvanzada";
            this.gbAvanzada.Size = new System.Drawing.Size(244, 657);
            this.gbAvanzada.TabIndex = 0;
            this.gbAvanzada.TabStop = false;
            this.gbAvanzada.Text = "Consultar gráfica";
            // 
            // rbNinguno
            // 
            this.rbNinguno.AutoSize = true;
            this.rbNinguno.Checked = true;
            this.rbNinguno.Location = new System.Drawing.Point(11, 226);
            this.rbNinguno.Name = "rbNinguno";
            this.rbNinguno.Size = new System.Drawing.Size(89, 25);
            this.rbNinguno.TabIndex = 7;
            this.rbNinguno.TabStop = true;
            this.rbNinguno.Text = "Ninguno\r\n";
            this.rbNinguno.UseVisualStyleBackColor = true;
            this.rbNinguno.CheckedChanged += new System.EventHandler(this.rbNinguno_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elegir fecha deseada:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 176);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(150, 25);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Desde hace 1 año";
            this.radioButton3.UseVisualStyleBackColor = true;

            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 25);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Desde hace un mes";
            this.radioButton2.UseVisualStyleBackColor = true;

            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 79);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(195, 25);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Desde hace una semana";
            this.radioButton1.UseVisualStyleBackColor = true;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver gráficos pasados:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart4
            // 
            chartArea1.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart4.Legends.Add(legend1);
            this.chart4.Location = new System.Drawing.Point(262, 25);
            this.chart4.Name = "chart4";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Intervenciones";
            this.chart4.Series.Add(series1);
            this.chart4.Size = new System.Drawing.Size(990, 644);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "chart4";
            // 
            // frmConsultaAvanzadaEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.gbAvanzada);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaAvanzadaEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta avanzada";
            this.gbAvanzada.ResumeLayout(false);
            this.gbAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAvanzada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.RadioButton rbNinguno;
    }
}