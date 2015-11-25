﻿using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmServico : Form
    {
        Servico classeServ = new Servico();
        CrudServico CrudServ = new CrudServico();

        public FrmServico()
        {
            InitializeComponent();

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtServico.Clear();
            mstPreco.Clear();
        }

        public void CopiarParaClasseServico()
        {
            classeServ.descricao = txtServico.Text;
            classeServ.preco = Convert.ToDouble(mstPreco.Text);
        }

        public void CopiarParaFormulario()
        {
            string sql = "select * from servico where id_servico = " + Estatica.id.ToString();
            DataTable servico = CrudServ.consultaServico(sql);

            //Dados Serviço
            classeServ.id = Convert.ToInt32(servico.Rows[0][0].ToString());
            txtServico.Text = servico.Rows[0][1].ToString();
            mstPreco.Text = Convert.ToString(servico.Rows[0][2].ToString());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseServico();
            CrudServico CrudServ = new CrudServico();

            if (Estatica.id != 0)
            {
                CrudServ.alteraServico(classeServ);
                Estatica.id = 0;
            }
            else
            {
                CrudServ.inserirServico(classeServ);
            }            
        }
    }
}
