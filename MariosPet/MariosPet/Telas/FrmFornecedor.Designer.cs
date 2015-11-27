namespace MariosPet.Telas
{
    partial class FrmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNomeContato = new System.Windows.Forms.TextBox();
            this.labelNomeContato = new System.Windows.Forms.Label();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.labelEmail2 = new System.Windows.Forms.Label();
            this.textBoxEmail1 = new System.Windows.Forms.TextBox();
            this.labelEmail1 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mstCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtAtividade = new System.Windows.Forms.TextBox();
            this.txtDenominacao = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.toolTipFornecedor = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromVerdeGrande;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.textBoxNomeContato);
            this.groupBox1.Controls.Add(this.labelNomeContato);
            this.groupBox1.Controls.Add(this.textBoxEmail2);
            this.groupBox1.Controls.Add(this.labelEmail2);
            this.groupBox1.Controls.Add(this.textBoxEmail1);
            this.groupBox1.Controls.Add(this.labelEmail1);
            this.groupBox1.Controls.Add(this.txtTelefone2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mstCNPJ);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtAtividade);
            this.groupBox1.Controls.Add(this.txtDenominacao);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(150, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Dados  do Fornecedor";
            // 
            // textBoxNomeContato
            // 
            this.textBoxNomeContato.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.textBoxNomeContato.Location = new System.Drawing.Point(226, 299);
            this.textBoxNomeContato.MaxLength = 50;
            this.textBoxNomeContato.Name = "textBoxNomeContato";
            this.textBoxNomeContato.Size = new System.Drawing.Size(469, 27);
            this.textBoxNomeContato.TabIndex = 7;
            this.toolTipFornecedor.SetToolTip(this.textBoxNomeContato, "Insira o nome para Contato");
            // 
            // labelNomeContato
            // 
            this.labelNomeContato.AutoSize = true;
            this.labelNomeContato.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeContato.Location = new System.Drawing.Point(6, 298);
            this.labelNomeContato.Name = "labelNomeContato";
            this.labelNomeContato.Size = new System.Drawing.Size(204, 23);
            this.labelNomeContato.TabIndex = 31;
            this.labelNomeContato.Text = "Nome para Contato:";
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.textBoxEmail2.Location = new System.Drawing.Point(226, 249);
            this.textBoxEmail2.MaxLength = 50;
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(469, 27);
            this.textBoxEmail2.TabIndex = 6;
            this.toolTipFornecedor.SetToolTip(this.textBoxEmail2, "Insira o e-mail para Contato");
            // 
            // labelEmail2
            // 
            this.labelEmail2.AutoSize = true;
            this.labelEmail2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail2.Location = new System.Drawing.Point(129, 248);
            this.labelEmail2.Name = "labelEmail2";
            this.labelEmail2.Size = new System.Drawing.Size(81, 23);
            this.labelEmail2.TabIndex = 29;
            this.labelEmail2.Text = "E-mail:";
            // 
            // textBoxEmail1
            // 
            this.textBoxEmail1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.textBoxEmail1.Location = new System.Drawing.Point(226, 208);
            this.textBoxEmail1.MaxLength = 50;
            this.textBoxEmail1.Name = "textBoxEmail1";
            this.textBoxEmail1.Size = new System.Drawing.Size(469, 27);
            this.textBoxEmail1.TabIndex = 5;
            this.toolTipFornecedor.SetToolTip(this.textBoxEmail1, "Insira o e-mail para Contato");
            // 
            // labelEmail1
            // 
            this.labelEmail1.AutoSize = true;
            this.labelEmail1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail1.Location = new System.Drawing.Point(129, 208);
            this.labelEmail1.Name = "labelEmail1";
            this.labelEmail1.Size = new System.Drawing.Size(81, 23);
            this.labelEmail1.TabIndex = 27;
            this.labelEmail1.Text = "E-mail:";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtTelefone2.Location = new System.Drawing.Point(525, 167);
            this.txtTelefone2.MaxLength = 15;
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(170, 27);
            this.txtTelefone2.TabIndex = 4;
            this.toolTipFornecedor.SetToolTip(this.txtTelefone2, "Insira o telefone para Contato");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Telefone:";
            // 
            // mstCNPJ
            // 
            this.mstCNPJ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mstCNPJ.Location = new System.Drawing.Point(226, 78);
            this.mstCNPJ.Mask = "000.000.000-00";
            this.mstCNPJ.Name = "mstCNPJ";
            this.mstCNPJ.Size = new System.Drawing.Size(170, 27);
            this.mstCNPJ.TabIndex = 1;
            this.toolTipFornecedor.SetToolTip(this.mstCNPJ, "Insira o CNPJ do Fornecedor");
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtTelefone.Location = new System.Drawing.Point(226, 166);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(170, 27);
            this.txtTelefone.TabIndex = 3;
            this.toolTipFornecedor.SetToolTip(this.txtTelefone, "Insira o telefone para Contato");
            // 
            // txtAtividade
            // 
            this.txtAtividade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtAtividade.Location = new System.Drawing.Point(226, 121);
            this.txtAtividade.MaxLength = 40;
            this.txtAtividade.Name = "txtAtividade";
            this.txtAtividade.Size = new System.Drawing.Size(469, 27);
            this.txtAtividade.TabIndex = 2;
            this.toolTipFornecedor.SetToolTip(this.txtAtividade, "Insira o Ramo da Atividade do Fornecedor");
            // 
            // txtDenominacao
            // 
            this.txtDenominacao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenominacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtDenominacao.Location = new System.Drawing.Point(226, 36);
            this.txtDenominacao.MaxLength = 40;
            this.txtDenominacao.Name = "txtDenominacao";
            this.txtDenominacao.Size = new System.Drawing.Size(469, 27);
            this.txtDenominacao.TabIndex = 0;
            this.toolTipFornecedor.SetToolTip(this.txtDenominacao, "Insira o Nome do Fornecedor");
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(111, 166);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(101, 23);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(11, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(199, 23);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Ramo da Atividade:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(144, 82);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(66, 23);
            this.lblCpf.TabIndex = 17;
            this.lblCpf.Text = "CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(214, 23);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Denominação Social:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromAmareloGrande;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Controls.Add(this.maskedTextBoxCep);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.cmbUF);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.lblUF);
            this.groupBox2.Controls.Add(this.lblCEP);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.lblComplemento);
            this.groupBox2.Controls.Add(this.txtRua);
            this.groupBox2.Controls.Add(this.lblRua);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox2.Location = new System.Drawing.Point(160, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 339);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Endereço";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarLaranja;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(156, 253);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 41);
            this.btnVoltar.TabIndex = 7;
            this.toolTipFornecedor.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.maskedTextBoxCep.Location = new System.Drawing.Point(473, 138);
            this.maskedTextBoxCep.Mask = "##.###-###";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(171, 27);
            this.maskedTextBoxCep.TabIndex = 4;
            this.toolTipFornecedor.SetToolTip(this.maskedTextBoxCep, "Insira o CEP");
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnLimpar.BackgroundImage = global::MariosPet.Properties.Resources.botaoLimparVerde;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(308, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 41);
            this.btnLimpar.TabIndex = 8;
            this.toolTipFornecedor.SetToolTip(this.btnLimpar, "Limpar Campos");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cmbUF
            // 
            this.cmbUF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
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
            this.cmbUF.Location = new System.Drawing.Point(473, 187);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(171, 26);
            this.cmbUF.TabIndex = 6;
            this.cmbUF.Text = "---Selecione---";
            this.toolTipFornecedor.SetToolTip(this.cmbUF, "Selecione a UF");
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::MariosPet.Properties.Resources.botaoSalvarLaranja;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(459, 253);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 41);
            this.btnSalvar.TabIndex = 9;
            this.toolTipFornecedor.SetToolTip(this.btnSalvar, "Salvar as Informações");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtCidade.Location = new System.Drawing.Point(156, 185);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(195, 27);
            this.txtCidade.TabIndex = 5;
            this.toolTipFornecedor.SetToolTip(this.txtCidade, "Insira a Cidade");
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
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtBairro.Location = new System.Drawing.Point(156, 137);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(195, 27);
            this.txtBairro.TabIndex = 3;
            this.toolTipFornecedor.SetToolTip(this.txtBairro, "Insira o Bairro");
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
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtNumero.Location = new System.Drawing.Point(156, 90);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(81, 27);
            this.txtNumero.TabIndex = 1;
            this.toolTipFornecedor.SetToolTip(this.txtNumero, "Insira o Número do Estabelecimento");
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
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtComplemento.Location = new System.Drawing.Point(473, 97);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(170, 27);
            this.txtComplemento.TabIndex = 2;
            this.toolTipFornecedor.SetToolTip(this.txtComplemento, "Insira o Complemento");
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
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtRua.Location = new System.Drawing.Point(156, 44);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(488, 27);
            this.txtRua.TabIndex = 0;
            this.toolTipFornecedor.SetToolTip(this.txtRua, "Insira o Nome da Rua");
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
            // toolTipFornecedor
            // 
            this.toolTipFornecedor.AutomaticDelay = 100;
            this.toolTipFornecedor.IsBalloon = true;
            this.toolTipFornecedor.StripAmpersands = true;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1261, 733);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFornecedor";
            this.Text = "Cadastrar Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mstCNPJ;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtAtividade;
        private System.Windows.Forms.TextBox txtDenominacao;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.ComboBox cmbUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipFornecedor;
        private System.Windows.Forms.TextBox textBoxEmail1;
        private System.Windows.Forms.Label labelEmail1;
        private System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.Label labelEmail2;
        private System.Windows.Forms.TextBox textBoxNomeContato;
        private System.Windows.Forms.Label labelNomeContato;
    }
}