using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Diagnostics;
using MariosPet.Classes;
using System.Web.UI.WebControls;
using MariosPet.Crud;

namespace MariosPet.Telas
{
    public partial class FrmCateirinha : Form
    {

        Cliente classeCli = new Cliente();
        CrudCliente CrudCli = new CrudCliente();
        DataTable tabelaCli = new DataTable();

        public FrmCateirinha()
        {
            InitializeComponent();

            tabelaCli = CrudCli.consultaCliente("select NOME from CLIENTE inner join PESSOA on PESSOA.ID_PESSOA = CLIENTE.ID_PESSOA where CLIENTE.ID_PESSOA=1");
            PreencheCampos();
        }

        public void PreencheCampos()
        {
            //Dados Pessoais
            txtNome.Text = tabelaCli.Rows[0][0].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //local
            ReportViewer report = new ReportViewer();
            report.ProcessingMode = ProcessingMode.Local;

            report.LocalReport.ReportEmbeddedResource = "MariosPet.Report2.rdlc";

            //criar listas
            List<ReportParameter> lista = new List<ReportParameter>();

            lista.Add(new ReportParameter("NomeAnimal", txtNome.Text));
            lista.Add(new ReportParameter("Cor", txtCor.Text));
            lista.Add(new ReportParameter("Sexo", txtSexo.Text));
            lista.Add(new ReportParameter("Raca", txtRaca.Text));
            lista.Add(new ReportParameter("Registro", txtRegistro.Text));
            lista.Add(new ReportParameter("Proprietario", txtProprietario.Text));

            report.LocalReport.SetParameters(lista);

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extrension;

            byte[] bytePdf = report.LocalReport.Render("PDF", null, out mimeType, out encoding, out extrension, out streamids, out warnings);

            //criar pdf
            FileStream file = null;
            string nomeArquivo = Path.GetTempPath() + "Carteira" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";

            //abrir pdf
            file = new FileStream(nomeArquivo, FileMode.Create);
            file.Write(bytePdf, 0, bytePdf.Length);
            file.Close();
            Process.Start(nomeArquivo);
        }
    }
}
