namespace MariosPet.Telas
{
    partial class FrmPesquisas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisas));
            this.toolTipPesquisas = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.comboBoxPesqPor = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.dataGridViewPesquisas = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.groupBoxPesquisas = new System.Windows.Forms.GroupBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisas)).BeginInit();
            this.groupBoxPesquisas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipPesquisas
            // 
            this.toolTipPesquisas.AutomaticDelay = 100;
            this.toolTipPesquisas.IsBalloon = true;
            this.toolTipPesquisas.StripAmpersands = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnLimpar.BackgroundImage = global::MariosPet.Properties.Resources.botaoLimparVerde;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(594, 343);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 44);
            this.btnLimpar.TabIndex = 8;
            this.toolTipPesquisas.SetToolTip(this.btnLimpar, "Limpar os Campos");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarLaranja;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(27, 343);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 44);
            this.btnVoltar.TabIndex = 5;
            this.toolTipPesquisas.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // comboBoxPesqPor
            // 
            this.comboBoxPesqPor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesqPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.comboBoxPesqPor.FormattingEnabled = true;
            this.comboBoxPesqPor.Location = new System.Drawing.Point(524, 47);
            this.comboBoxPesqPor.Name = "comboBoxPesqPor";
            this.comboBoxPesqPor.Size = new System.Drawing.Size(186, 26);
            this.comboBoxPesqPor.TabIndex = 1;
            this.comboBoxPesqPor.Text = "    ---Selecionar---";
            this.toolTipPesquisas.SetToolTip(this.comboBoxPesqPor, "Selecionar informação a ser pesquisada");
            this.comboBoxPesqPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxPesqPor_SelectedIndexChanged);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Clientes",
            "Animais",
            "Laboratórios",
            "Medicamentos",
            "Solicitação de Exames",
            "Prontuário",
            "Produtos",
            "Serviços",
            "Fornecedores",
            "Vendas",
            "Funcionários"});
            this.comboBoxTipo.Location = new System.Drawing.Point(90, 47);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(268, 26);
            this.comboBoxTipo.TabIndex = 0;
            this.comboBoxTipo.Text = "         ---Selecionar---";
            this.toolTipPesquisas.SetToolTip(this.comboBoxTipo, "Selecionar o Tipo de Pesquisa");
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // dataGridViewPesquisas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.dataGridViewPesquisas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPesquisas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dataGridViewPesquisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPesquisas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPesquisas.Location = new System.Drawing.Point(27, 28);
            this.dataGridViewPesquisas.Name = "dataGridViewPesquisas";
            this.dataGridViewPesquisas.Size = new System.Drawing.Size(683, 288);
            this.dataGridViewPesquisas.TabIndex = 4;
            this.toolTipPesquisas.SetToolTip(this.dataGridViewPesquisas, "Resultado da Pesquisa");
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnConsultar.BackgroundImage = global::MariosPet.Properties.Resources.botaoConsultarLaranja;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(594, 104);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 44);
            this.btnConsultar.TabIndex = 3;
            this.toolTipPesquisas.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisa.Location = new System.Drawing.Point(131, 114);
            this.txtPesquisa.MaxLength = 80;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(439, 27);
            this.txtPesquisa.TabIndex = 2;
            this.toolTipPesquisas.SetToolTip(this.txtPesquisa, "Insira a informação a ser pesquisada");
            // 
            // buttonEditar
            // 
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Image = global::MariosPet.Properties.Resources.botaoEditarLaranja;
            this.buttonEditar.Location = new System.Drawing.Point(403, 343);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(115, 44);
            this.buttonEditar.TabIndex = 7;
            this.toolTipPesquisas.SetToolTip(this.buttonEditar, "Editar Informação selecionada");
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Image = global::MariosPet.Properties.Resources.botaoExcluirVerde;
            this.buttonExcluir.Location = new System.Drawing.Point(198, 343);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(140, 44);
            this.buttonExcluir.TabIndex = 6;
            this.toolTipPesquisas.SetToolTip(this.buttonExcluir, "Excluir Informação selecionada");
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBoxPesquisas
            // 
            this.groupBoxPesquisas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxPesquisas.BackgroundImage = global::MariosPet.Properties.Resources.pataVerdeMarromGrande;
            this.groupBoxPesquisas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxPesquisas.Controls.Add(this.lblConsulta);
            this.groupBoxPesquisas.Controls.Add(this.label1);
            this.groupBoxPesquisas.Controls.Add(this.comboBoxPesqPor);
            this.groupBoxPesquisas.Controls.Add(this.comboBoxTipo);
            this.groupBoxPesquisas.Controls.Add(this.btnConsultar);
            this.groupBoxPesquisas.Controls.Add(this.txtPesquisa);
            this.groupBoxPesquisas.Controls.Add(this.lblTipo);
            this.groupBoxPesquisas.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxPesquisas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxPesquisas.Location = new System.Drawing.Point(38, 12);
            this.groupBoxPesquisas.Name = "groupBoxPesquisas";
            this.groupBoxPesquisas.Size = new System.Drawing.Size(752, 157);
            this.groupBoxPesquisas.TabIndex = 3;
            this.groupBoxPesquisas.TabStop = false;
            this.groupBoxPesquisas.Text = "   Pesquisa";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(23, 118);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(102, 23);
            this.lblConsulta.TabIndex = 20;
            this.lblConsulta.Text = "Consulta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pesquisa por:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(23, 50);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(61, 23);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonEditar);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.dataGridViewPesquisas);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(38, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 395);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // FrmPesquisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(851, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPesquisas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisas";
            this.Text = "Pesquisas e Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPesquisas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisas)).EndInit();
            this.groupBoxPesquisas.ResumeLayout(false);
            this.groupBoxPesquisas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPesquisas;
        private System.Windows.Forms.DataGridView dataGridViewPesquisas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox comboBoxPesqPor;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipPesquisas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}