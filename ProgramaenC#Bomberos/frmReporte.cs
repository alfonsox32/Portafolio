using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaBSPC
{
    public partial class frmReporte : Form
    {
        private DataTable _dataTable;
       
        public frmReporte(DataTable dataTable)
        {
            InitializeComponent();
            _dataTable = dataTable;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            string reportPath = Path.Combine(Application.StartupPath, "Reports", "Report1.rdlc");

            if (!System.IO.File.Exists(reportPath))
            {
                MessageBox.Show("No se puede encontrar el archivo RDLC en la ruta: " + reportPath);
                return;
            }

            // Crear una instancia del ReportDataSource
            ReportDataSource rds = new ReportDataSource("DataSetReporte", _dataTable);

            // Limpiar las fuentes de datos del ReportViewer
            rvReporte.LocalReport.DataSources.Clear();

            // Establecer el path del archivo RDLC
            rvReporte.LocalReport.ReportPath = reportPath;

            // Añadir la fuente de datos
            rvReporte.LocalReport.DataSources.Add(rds);

            // Refrescar el ReportViewer
            rvReporte.RefreshReport();
        } 
    }

}
