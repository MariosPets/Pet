namespace MariosPet.Telas
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.btmSalvar = new System.Windows.Forms.Button();
            this.cmbUFCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplementoCliente = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtRuaCliente = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefone3Cliente = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone2Cliente = new System.Windows.Forms.TextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.mskNascimentoCliente = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mstRG = new System.Windows.Forms.MaskedTextBox();
            this.mstCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.toolTipCliente = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmLimpar
            // 
            this.btmLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmLimpar.BackgroundImage")));
            this.btmLimpar.FlatAppearance.BorderSize = 0;
            this.btmLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLimpar.Location = new System.Drawing.Point(538, 688);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(117, 44);
            this.btmLimpar.TabIndex = 3;
            this.toolTipCliente.SetToolTip(this.btmLimpar, "Limpar os Campos");
            this.btmLimpar.UseVisualStyleBackColor = false;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // btmVoltar
            // 
            this.btmVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmVoltar.BackgroundImage")));
            this.btmVoltar.FlatAppearance.BorderSize = 0;
            this.btmVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmVoltar.Location = new System.Drawing.Point(340, 689);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(116, 44);
            this.btmVoltar.TabIndex = 2;
            this.toolTipCliente.SetToolTip(this.btmVoltar, "Voltar ao Menu");
            this.btmVoltar.UseVisualStyleBackColor = false;
            this.btmVoltar.Click += new System.EventHandler(this.btmVoltar_Click);
            // 
            // btmSalvar
            // 
            this.btmSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmSalvar.BackgroundImage")));
            this.btmSalvar.FlatAppearance.BorderSize = 0;
            this.btmSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSalvar.Location = new System.Drawing.Point(736, 690);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(117, 42);
            this.btmSalvar.TabIndex = 4;
            this.toolTipCliente.SetToolTip(this.btmSalvar, "Salvar as Informações");
            this.btmSalvar.UseVisualStyleBackColor = false;
            this.btmSalvar.Click += new System.EventHandler(this.btmSalvar_Click_1);
            // 
            // cmbUFCliente
            // 
            this.cmbUFCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUFCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.cmbUFCliente.FormattingEnabled = true;
            this.cmbUFCliente.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA) ",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmbUFCliente.Location = new System.Drawing.Point(473, 187);
            this.cmbUFCliente.Name = "cmbUFCliente";
            this.cmbUFCliente.Size = new System.Drawing.Size(171, 26);
            this.cmbUFCliente.TabIndex = 6;
            this.cmbUFCliente.Text = "---Selecione---";
            this.toolTipCliente.SetToolTip(this.cmbUFCliente, "Selecione o Estado");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.mskCepCliente);
            this.groupBox2.Controls.Add(this.cmbUFCliente);
            this.groupBox2.Controls.Add(this.lblUF);
            this.groupBox2.Controls.Add(this.lblCEP);
            this.groupBox2.Controls.Add(this.txtCidadeCliente);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.txtBairroCliente);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.txtNumeroCliente);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.txtComplementoCliente);
            this.groupBox2.Controls.Add(this.lblComplemento);
            this.groupBox2.Controls.Add(this.txtRuaCliente);
            this.groupBox2.Controls.Add(this.lblRua);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox2.Location = new System.Drawing.Point(243, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Endereço";
            // 
            // mskCepCliente
            // 
            this.mskCepCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCepCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mskCepCliente.Location = new System.Drawing.Point(473, 138);
            this.mskCepCliente.Mask = "##,###-###";
            this.mskCepCliente.Name = "mskCepCliente";
            this.mskCepCliente.Size = new System.Drawing.Size(171, 27);
            this.mskCepCliente.TabIndex = 4;
            this.toolTipCliente.SetToolTip(this.mskCepCliente, "Insira o CEP");
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(412, 190);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(44, 23);
            this.lblUF.TabIndex = 20;
            this.lblUF.Text = "UF:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(400, 142);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(55, 23);
            this.lblCEP.TabIndex = 18;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtCidadeCliente.Location = new System.Drawing.Point(156, 185);
            this.txtCidadeCliente.MaxLength = 30;
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(195, 27);
            this.txtCidadeCliente.TabIndex = 5;
            this.toolTipCliente.SetToolTip(this.txtCidadeCliente, "Insira o nome da Cidade");
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(6, 185);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(84, 23);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtBairroCliente.Location = new System.Drawing.Point(156, 137);
            this.txtBairroCliente.MaxLength = 30;
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(195, 27);
            this.txtBairroCliente.TabIndex = 3;
            this.toolTipCliente.SetToolTip(this.txtBairroCliente, "Insira o Nome do Bairro");
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(6, 137);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(77, 23);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtNumeroCliente.Location = new System.Drawing.Point(156, 90);
            this.txtNumeroCliente.MaxLength = 10;
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(81, 27);
            this.txtNumeroCliente.TabIndex = 1;
            this.toolTipCliente.SetToolTip(this.txtNumeroCliente, "Insira o Número da Residência");
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(6, 90);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(94, 23);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero:";
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtComplementoCliente.Location = new System.Drawing.Point(473, 97);
            this.txtComplementoCliente.MaxLength = 30;
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.Size = new System.Drawing.Size(170, 27);
            this.txtComplementoCliente.TabIndex = 2;
            this.toolTipCliente.SetToolTip(this.txtComplementoCliente, "Insira o Complemento");
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(304, 101);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(151, 23);
            this.lblComplemento.TabIndex = 10;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtRuaCliente
            // 
            this.txtRuaCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtRuaCliente.Location = new System.Drawing.Point(156, 44);
            this.txtRuaCliente.MaxLength = 50;
            this.txtRuaCliente.Name = "txtRuaCliente";
            this.txtRuaCliente.Size = new System.Drawing.Size(488, 27);
            this.txtRuaCliente.TabIndex = 0;
            this.toolTipCliente.SetToolTip(this.txtRuaCliente, "Insira o nome da Rua");
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(6, 49);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(55, 23);
            this.lblRua.TabIndex = 8;
            this.lblRua.Text = "Rua:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(408, 126);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(47, 23);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(6, 126);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(54, 23);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtTelefone3Cliente);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.txtTelefone2Cliente);
            this.groupBox1.Controls.Add(this.lblTelefone2);
            this.groupBox1.Controls.Add(this.mskNascimentoCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mstRG);
            this.groupBox1.Controls.Add(this.mstCPF);
            this.groupBox1.Controls.Add(this.txtTelefoneCliente);
            this.groupBox1.Controls.Add(this.txtEmailCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.lblTelefone1);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(243, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Dados Pessoais";
            // 
            // txtTelefone3Cliente
            // 
            this.txtTelefone3Cliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone3Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtTelefone3Cliente.Location = new System.Drawing.Point(156, 252);
            this.txtTelefone3Cliente.MaxLength = 15;
            this.txtTelefone3Cliente.Name = "txtTelefone3Cliente";
            this.txtTelefone3Cliente.Size = new System.Drawing.Size(170, 27);
            this.txtTelefone3Cliente.TabIndex = 7;
            this.toolTipCliente.SetToolTip(this.txtTelefone3Cliente, "Insira o número do Telefone");
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(6, 252);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(101, 23);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone2Cliente
            // 
            this.txtTelefone2Cliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtTelefone2Cliente.Location = new System.Drawing.Point(473, 209);
            this.txtTelefone2Cliente.MaxLength = 15;
            this.txtTelefone2Cliente.Name = "txtTelefone2Cliente";
            this.txtTelefone2Cliente.Size = new System.Drawing.Size(170, 27);
            this.txtTelefone2Cliente.TabIndex = 6;
            this.toolTipCliente.SetToolTip(this.txtTelefone2Cliente, "Insira o número do Telefone");
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.Location = new System.Drawing.Point(356, 209);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(101, 23);
            this.lblTelefone2.TabIndex = 16;
            this.lblTelefone2.Text = "Telefone:";
            // 
            // mskNascimentoCliente
            // 
            this.mskNascimentoCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNascimentoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mskNascimentoCliente.Location = new System.Drawing.Point(156, 81);
            this.mskNascimentoCliente.Mask = "00/00/0000";
            this.mskNascimentoCliente.Name = "mskNascimentoCliente";
            this.mskNascimentoCliente.Size = new System.Drawing.Size(170, 27);
            this.mskNascimentoCliente.TabIndex = 1;
            this.toolTipCliente.SetToolTip(this.mskNascimentoCliente, "Insira a Data de Nascimento");
            this.mskNascimentoCliente.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nascimento:";
            // 
            // mstRG
            // 
            this.mstRG.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mstRG.Location = new System.Drawing.Point(473, 122);
            this.mstRG.Mask = "00.000.000-0";
            this.mstRG.Name = "mstRG";
            this.mstRG.Size = new System.Drawing.Size(170, 27);
            this.mstRG.TabIndex = 3;
            this.toolTipCliente.SetToolTip(this.mstRG, "Insira o RG");
            // 
            // mstCPF
            // 
            this.mstCPF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mstCPF.Location = new System.Drawing.Point(156, 123);
            this.mstCPF.Mask = "000.000.000-00";
            this.mstCPF.Name = "mstCPF";
            this.mstCPF.Size = new System.Drawing.Size(170, 27);
            this.mstCPF.TabIndex = 2;
            this.toolTipCliente.SetToolTip(this.mstCPF, "Insira o CPF");
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtTelefoneCliente.Location = new System.Drawing.Point(156, 209);
            this.txtTelefoneCliente.MaxLength = 15;
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(170, 27);
            this.txtTelefoneCliente.TabIndex = 5;
            this.toolTipCliente.SetToolTip(this.txtTelefoneCliente, "Insira o número do Telefone");
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtEmailCliente.Location = new System.Drawing.Point(156, 167);
            this.txtEmailCliente.MaxLength = 50;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(487, 27);
            this.txtEmailCliente.TabIndex = 4;
            this.toolTipCliente.SetToolTip(this.txtEmailCliente, "Insira o E-mail");
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtNomeCliente.Location = new System.Drawing.Point(156, 39);
            this.txtNomeCliente.MaxLength = 80;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(487, 27);
            this.txtNomeCliente.TabIndex = 0;
            this.toolTipCliente.SetToolTip(this.txtNomeCliente, "Insira o nome do Cliente");
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.Location = new System.Drawing.Point(6, 209);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(101, 23);
            this.lblTelefone1.TabIndex = 5;
            this.lblTelefone1.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // toolTipCliente
            // 
            this.toolTipCliente.AutomaticDelay = 100;
            this.toolTipCliente.IsBalloon = true;
            this.toolTipCliente.StripAmpersands = true;
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1114, 733);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.btmVoltar);
            this.Controls.Add(this.btmSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro do Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Button btmSalvar;
        private System.Windows.Forms.ComboBox cmbUFCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtComplementoCliente;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtRuaCliente;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mstRG;
        private System.Windows.Forms.MaskedTextBox mstCPF;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.MaskedTextBox mskNascimentoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCepCliente;
        private System.Windows.Forms.ToolTip toolTipCliente;
        private System.Windows.Forms.TextBox txtTelefone2Cliente;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.TextBox txtTelefone3Cliente;
        private System.Windows.Forms.Label lblTelefone;
    }
}