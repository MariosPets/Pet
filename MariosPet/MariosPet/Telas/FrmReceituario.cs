using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Diagnostics;

namespace MariosPet.Telas
{
    public partial class FrmReceituario : Form
    {
        public FrmReceituario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //local
            ReportViewer report = new ReportViewer();
            report.ProcessingMode = ProcessingMode.Local;

            report.LocalReport.ReportEmbeddedResource = "MariosPet.Report1.rdlc";

            //criar listas
            List<ReportParameter> lista = new List<ReportParameter>();

            lista.Add(new ReportParameter("NomeVeterinario", txtNomeVeterinario.Text));
            lista.Add(new ReportParameter("Prescricao", txtPrescricao.Text));

            report.LocalReport.SetParameters(lista);

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extrension;

            byte[] bytePdf = report.LocalReport.Render("PDF", null, out mimeType, out encoding ,out extrension, out streamids, out warnings);

            //criar pdf
            FileStream file = null;
            string nomeArquivo = Path.GetTempPath() + "Receiturario" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";

            //abrir pdf
            file = new FileStream(nomeArquivo, FileMode.Create);
            file.Write(bytePdf, 0, bytePdf.Length);
            file.Close();
            Process.Start(nomeArquivo);
            MessageBox.Show("Receituário Salvo com Sucesso", "Receituário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
