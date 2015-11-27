namespace MariosPet.Telas
{
    partial class FrmFichaClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFichaClinica));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roundButton1 = new MariosPet.Classes.RoundButton();
            this.roundButtonVacina = new MariosPet.Classes.RoundButton();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExames = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuspeita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQueixa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHistoricoClinico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipFichaClinica = new System.Windows.Forms.ToolTip(this.components);
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaAnimal = new System.Windows.Forms.TextBox();
            this.groupBoxPesquisaAnimal = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBoxPesquisaAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromAmareloGrande;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.roundButton1);
            this.groupBox2.Controls.Add(this.roundButtonVacina);
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtExames);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.txtSintomas);
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPrescricao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSuspeita);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtQueixa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHistoricoClinico);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 176);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1291, 542);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Ficha Clínica";
            this.toolTipFichaClinica.SetToolTip(this.groupBox2, "Vacinas");
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(144)))), ((int)(((byte)(35)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Image = global::MariosPet.Properties.Resources.vermifugoMarrom;
            this.roundButton1.Location = new System.Drawing.Point(707, 422);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(60, 55);
            this.roundButton1.TabIndex = 8;
            this.toolTipFichaClinica.SetToolTip(this.roundButton1, "Ir para a Tela de Vermífugos");
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButtonVacina
            // 
            this.roundButtonVacina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(190)))), ((int)(((byte)(142)))));
            this.roundButtonVacina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButtonVacina.FlatAppearance.BorderSize = 0;
            this.roundButtonVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonVacina.Image = global::MariosPet.Properties.Resources.vaccineMarrom;
            this.roundButtonVacina.Location = new System.Drawing.Point(635, 422);
            this.roundButtonVacina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundButtonVacina.Name = "roundButtonVacina";
            this.roundButtonVacina.Size = new System.Drawing.Size(60, 55);
            this.roundButtonVacina.TabIndex = 7;
            this.toolTipFichaClinica.SetToolTip(this.roundButtonVacina, "Ir para a Tela de Vacinas");
            this.roundButtonVacina.UseVisualStyleBackColor = false;
            this.roundButtonVacina.Click += new System.EventHandler(this.roundButtonVacina_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtObservacao.Location = new System.Drawing.Point(13, 422);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(608, 94);
            this.txtObservacao.TabIndex = 6;
            this.toolTipFichaClinica.SetToolTip(this.txtObservacao, "Insira as Observações");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Observações:";
            // 
            // txtExames
            // 
            this.txtExames.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtExames.Location = new System.Drawing.Point(632, 305);
            this.txtExames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExames.MaxLength = 200;
            this.txtExames.Multiline = true;
            this.txtExames.Name = "txtExames";
            this.txtExames.Size = new System.Drawing.Size(635, 86);
            this.txtExames.TabIndex = 5;
            this.toolTipFichaClinica.SetToolTip(this.txtExames, "Exames Complementares");
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btnSalvar.Location = new System.Drawing.Point(1103, 422);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(165, 62);
            this.btnSalvar.TabIndex = 11;
            this.toolTipFichaClinica.SetToolTip(this.btnSalvar, "Salvar Ficha Clínica");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(628, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Exames Complementares:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btnLimpar.Location = new System.Drawing.Point(956, 422);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 62);
            this.btnLimpar.TabIndex = 10;
            this.toolTipFichaClinica.SetToolTip(this.btnLimpar, "Limpar Campos");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSintomas
            // 
            this.txtSintomas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtSintomas.Location = new System.Drawing.Point(13, 305);
            this.txtSintomas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSintomas.MaxLength = 500;
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(608, 86);
            this.txtSintomas.TabIndex = 4;
            this.toolTipFichaClinica.SetToolTip(this.txtSintomas, "Descreva os Sintomas acometidos");
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(800, 426);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 51);
            this.btnVoltar.TabIndex = 9;
            this.toolTipFichaClinica.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sintomas:";
            // 
            // txtPrescricao
            // 
            this.txtPrescricao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPrescricao.Location = new System.Drawing.Point(635, 188);
            this.txtPrescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrescricao.MaxLength = 300;
            this.txtPrescricao.Multiline = true;
            this.txtPrescricao.Name = "txtPrescricao";
            this.txtPrescricao.Size = new System.Drawing.Size(632, 86);
            this.txtPrescricao.TabIndex = 3;
            this.toolTipFichaClinica.SetToolTip(this.txtPrescricao, "Insira a Prescrição");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Prescrição:";
            // 
            // txtSuspeita
            // 
            this.txtSuspeita.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuspeita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtSuspeita.Location = new System.Drawing.Point(12, 188);
            this.txtSuspeita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSuspeita.MaxLength = 200;
            this.txtSuspeita.Multiline = true;
            this.txtSuspeita.Name = "txtSuspeita";
            this.txtSuspeita.Size = new System.Drawing.Size(609, 86);
            this.txtSuspeita.TabIndex = 2;
            this.toolTipFichaClinica.SetToolTip(this.txtSuspeita, "Insira a Suspeita");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Suspeita:";
            // 
            // txtQueixa
            // 
            this.txtQueixa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtQueixa.Location = new System.Drawing.Point(632, 70);
            this.txtQueixa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQueixa.MaxLength = 200;
            this.txtQueixa.Multiline = true;
            this.txtQueixa.Name = "txtQueixa";
            this.txtQueixa.Size = new System.Drawing.Size(635, 88);
            this.txtQueixa.TabIndex = 1;
            this.toolTipFichaClinica.SetToolTip(this.txtQueixa, "Descreva as Principais Queixas");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Principal Queixa:";
            // 
            // txtHistoricoClinico
            // 
            this.txtHistoricoClinico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoricoClinico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtHistoricoClinico.Location = new System.Drawing.Point(12, 70);
            this.txtHistoricoClinico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHistoricoClinico.MaxLength = 1000;
            this.txtHistoricoClinico.Multiline = true;
            this.txtHistoricoClinico.Name = "txtHistoricoClinico";
            this.txtHistoricoClinico.Size = new System.Drawing.Size(609, 88);
            this.txtHistoricoClinico.TabIndex = 0;
            this.toolTipFichaClinica.SetToolTip(this.txtHistoricoClinico, "Insira o Histórico Clínico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Histórico Clinico:";
            // 
            // toolTipFichaClinica
            // 
            this.toolTipFichaClinica.AutomaticDelay = 100;
            this.toolTipFichaClinica.IsBalloon = true;
            this.toolTipFichaClinica.StripAmpersands = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::MariosPet.Properties.Resources.botaoConsultarVerde;
            this.btnConsultar.Location = new System.Drawing.Point(1052, 50);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(155, 54);
            this.btnConsultar.TabIndex = 1;
            this.toolTipFichaClinica.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisaAnimal
            // 
            this.txtPesquisaAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisaAnimal.Location = new System.Drawing.Point(212, 62);
            this.txtPesquisaAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaAnimal.MaxLength = 80;
            this.txtPesquisaAnimal.Name = "txtPesquisaAnimal";
            this.txtPesquisaAnimal.Size = new System.Drawing.Size(768, 32);
            this.txtPesquisaAnimal.TabIndex = 0;
            this.toolTipFichaClinica.SetToolTip(this.txtPesquisaAnimal, "Insira o Nome do Animal");
            // 
            // groupBoxPesquisaAnimal
            // 
            this.groupBoxPesquisaAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxPesquisaAnimal.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromVerdeGrande;
            this.groupBoxPesquisaAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxPesquisaAnimal.Controls.Add(this.btnConsultar);
            this.groupBoxPesquisaAnimal.Controls.Add(this.txtPesquisaAnimal);
            this.groupBoxPesquisaAnimal.Controls.Add(this.lblNome);
            this.groupBoxPesquisaAnimal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxPesquisaAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxPesquisaAnimal.Location = new System.Drawing.Point(16, 26);
            this.groupBoxPesquisaAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPesquisaAnimal.Name = "groupBoxPesquisaAnimal";
            this.groupBoxPesquisaAnimal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPesquisaAnimal.Size = new System.Drawing.Size(1281, 117);
            this.groupBoxPesquisaAnimal.TabIndex = 30;
            this.groupBoxPesquisaAnimal.TabStop = false;
            this.groupBoxPesquisaAnimal.Text = "   Pesquisa";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 62);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(182, 29);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome Animal:";
            // 
            // FrmFichaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1773, 902);
            this.Controls.Add(this.groupBoxPesquisaAnimal);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFichaClinica";
            this.Text = "Ficha Clinica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPesquisaAnimal.ResumeLayout(false);
            this.groupBoxPesquisaAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuspeita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQueixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHistoricoClinico;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipFichaClinica;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxPesquisaAnimal;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaAnimal;
        private System.Windows.Forms.Label lblNome;
        private Classes.RoundButton roundButtonVacina;
        private Classes.RoundButton roundButton1;
    }
}