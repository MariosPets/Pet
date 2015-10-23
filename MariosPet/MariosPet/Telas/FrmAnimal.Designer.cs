namespace MariosPet.Telas
{
    partial class FrmAnimal
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
            this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.roundButton1 = new MariosPet.Classes.RoundButton();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.radioButtonFemea = new System.Windows.Forms.RadioButton();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.btmSalvar = new System.Windows.Forms.Button();
            this.lblNascimentoAnimal = new System.Windows.Forms.Label();
            this.maskedTxtNascimentoAnimal = new System.Windows.Forms.MaskedTextBox();
            this.lblPelagemCor = new System.Windows.Forms.Label();
            this.txtPelagemCor = new System.Windows.Forms.TextBox();
            this.txtRacaPorte = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.lblRacaPorte = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.toolTipAnimal = new System.Windows.Forms.ToolTip(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaCliente = new System.Windows.Forms.TextBox();
            this.groupBoxPesquisaAnimal = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
            this.groupBoxAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.groupBoxPesquisaAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAnimal
            // 
            this.pictureBoxAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAnimal.Location = new System.Drawing.Point(56, 51);
            this.pictureBoxAnimal.Name = "pictureBoxAnimal";
            this.pictureBoxAnimal.Size = new System.Drawing.Size(170, 167);
            this.pictureBoxAnimal.TabIndex = 1;
            this.pictureBoxAnimal.TabStop = false;
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.groupBoxAnimal.BackgroundImage = global::MariosPet.Properties.Resources.pataVerdeAmareloGrande;
            this.groupBoxAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAnimal.Controls.Add(this.roundButton1);
            this.groupBoxAnimal.Controls.Add(this.radioButtonMacho);
            this.groupBoxAnimal.Controls.Add(this.radioButtonFemea);
            this.groupBoxAnimal.Controls.Add(this.btmLimpar);
            this.groupBoxAnimal.Controls.Add(this.btmVoltar);
            this.groupBoxAnimal.Controls.Add(this.btmSalvar);
            this.groupBoxAnimal.Controls.Add(this.lblNascimentoAnimal);
            this.groupBoxAnimal.Controls.Add(this.maskedTxtNascimentoAnimal);
            this.groupBoxAnimal.Controls.Add(this.pictureBoxAnimal);
            this.groupBoxAnimal.Controls.Add(this.lblPelagemCor);
            this.groupBoxAnimal.Controls.Add(this.txtPelagemCor);
            this.groupBoxAnimal.Controls.Add(this.txtRacaPorte);
            this.groupBoxAnimal.Controls.Add(this.txtNomeAnimal);
            this.groupBoxAnimal.Controls.Add(this.lblRacaPorte);
            this.groupBoxAnimal.Controls.Add(this.lblEmail);
            this.groupBoxAnimal.Controls.Add(this.lblNomeAnimal);
            this.groupBoxAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAnimal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxAnimal.Location = new System.Drawing.Point(33, 246);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(801, 376);
            this.groupBoxAnimal.TabIndex = 6;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "   Dados do Animal";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(190)))), ((int)(((byte)(142)))));
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Image = global::MariosPet.Properties.Resources.addPhotoMarrom;
            this.roundButton1.Location = new System.Drawing.Point(56, 224);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(42, 40);
            this.roundButton1.TabIndex = 6;
            this.toolTipAnimal.SetToolTip(this.roundButton1, "Adicionar uma foto do Animal");
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // radioButtonMacho
            // 
            this.radioButtonMacho.AutoSize = true;
            this.radioButtonMacho.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMacho.Location = new System.Drawing.Point(637, 224);
            this.radioButtonMacho.Name = "radioButtonMacho";
            this.radioButtonMacho.Size = new System.Drawing.Size(77, 22);
            this.radioButtonMacho.TabIndex = 5;
            this.radioButtonMacho.Text = "Macho";
            this.toolTipAnimal.SetToolTip(this.radioButtonMacho, "Selecione se o animal for Macho");
            this.radioButtonMacho.UseVisualStyleBackColor = true;
            this.radioButtonMacho.CheckedChanged += new System.EventHandler(this.radioButtonMasc_CheckedChanged);
            // 
            // radioButtonFemea
            // 
            this.radioButtonFemea.AutoSize = true;
            this.radioButtonFemea.Checked = true;
            this.radioButtonFemea.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemea.Location = new System.Drawing.Point(637, 196);
            this.radioButtonFemea.Name = "radioButtonFemea";
            this.radioButtonFemea.Size = new System.Drawing.Size(80, 22);
            this.radioButtonFemea.TabIndex = 4;
            this.radioButtonFemea.TabStop = true;
            this.radioButtonFemea.Text = "Fêmea";
            this.toolTipAnimal.SetToolTip(this.radioButtonFemea, "Selecione se o animal for Fêmea");
            this.radioButtonFemea.UseVisualStyleBackColor = true;
            this.radioButtonFemea.CheckedChanged += new System.EventHandler(this.radioButtonFem_CheckedChanged);
            // 
            // btmLimpar
            // 
            this.btmLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmLimpar.FlatAppearance.BorderSize = 0;
            this.btmLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLimpar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLimpar.Image = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btmLimpar.Location = new System.Drawing.Point(472, 315);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(117, 44);
            this.btmLimpar.TabIndex = 8;
            this.toolTipAnimal.SetToolTip(this.btmLimpar, "Limpar os Campos");
            this.btmLimpar.UseVisualStyleBackColor = false;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // btmVoltar
            // 
            this.btmVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btmVoltar.FlatAppearance.BorderSize = 0;
            this.btmVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmVoltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVoltar.Location = new System.Drawing.Point(338, 313);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(116, 44);
            this.btmVoltar.TabIndex = 7;
            this.toolTipAnimal.SetToolTip(this.btmVoltar, "Voltar ao Menu");
            this.btmVoltar.UseVisualStyleBackColor = false;
            this.btmVoltar.Click += new System.EventHandler(this.btmVoltar_Click);
            // 
            // btmSalvar
            // 
            this.btmSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmSalvar.FlatAppearance.BorderSize = 0;
            this.btmSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSalvar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarLaranja;
            this.btmSalvar.Location = new System.Drawing.Point(616, 315);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(117, 42);
            this.btmSalvar.TabIndex = 9;
            this.toolTipAnimal.SetToolTip(this.btmSalvar, "Salvar as Informações");
            this.btmSalvar.UseVisualStyleBackColor = false;
            this.btmSalvar.Click += new System.EventHandler(this.btmSalvar_Click_1);
            // 
            // lblNascimentoAnimal
            // 
            this.lblNascimentoAnimal.AutoSize = true;
            this.lblNascimentoAnimal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimentoAnimal.Location = new System.Drawing.Point(232, 195);
            this.lblNascimentoAnimal.Name = "lblNascimentoAnimal";
            this.lblNascimentoAnimal.Size = new System.Drawing.Size(130, 23);
            this.lblNascimentoAnimal.TabIndex = 17;
            this.lblNascimentoAnimal.Text = "Nascimento:";
            // 
            // maskedTxtNascimentoAnimal
            // 
            this.maskedTxtNascimentoAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtNascimentoAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.maskedTxtNascimentoAnimal.Location = new System.Drawing.Point(388, 191);
            this.maskedTxtNascimentoAnimal.Mask = "00/00/0000";
            this.maskedTxtNascimentoAnimal.Name = "maskedTxtNascimentoAnimal";
            this.maskedTxtNascimentoAnimal.Size = new System.Drawing.Size(158, 27);
            this.maskedTxtNascimentoAnimal.TabIndex = 3;
            this.toolTipAnimal.SetToolTip(this.maskedTxtNascimentoAnimal, "Insira a Data de Nascimento do Animal");
            this.maskedTxtNascimentoAnimal.ValidatingType = typeof(System.DateTime);
            // 
            // lblPelagemCor
            // 
            this.lblPelagemCor.AutoSize = true;
            this.lblPelagemCor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelagemCor.Location = new System.Drawing.Point(232, 146);
            this.lblPelagemCor.Name = "lblPelagemCor";
            this.lblPelagemCor.Size = new System.Drawing.Size(141, 23);
            this.lblPelagemCor.TabIndex = 14;
            this.lblPelagemCor.Text = "Pelagem/Cor:";
            // 
            // txtPelagemCor
            // 
            this.txtPelagemCor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelagemCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPelagemCor.Location = new System.Drawing.Point(388, 142);
            this.txtPelagemCor.MaxLength = 20;
            this.txtPelagemCor.Name = "txtPelagemCor";
            this.txtPelagemCor.Size = new System.Drawing.Size(345, 27);
            this.txtPelagemCor.TabIndex = 2;
            this.toolTipAnimal.SetToolTip(this.txtPelagemCor, "Insira a Pelagem/Cor");
            // 
            // txtRacaPorte
            // 
            this.txtRacaPorte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRacaPorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtRacaPorte.Location = new System.Drawing.Point(388, 94);
            this.txtRacaPorte.MaxLength = 20;
            this.txtRacaPorte.Name = "txtRacaPorte";
            this.txtRacaPorte.Size = new System.Drawing.Size(345, 27);
            this.txtRacaPorte.TabIndex = 1;
            this.toolTipAnimal.SetToolTip(this.txtRacaPorte, "Insira a Raça e o Porte");
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtNomeAnimal.Location = new System.Drawing.Point(388, 51);
            this.txtNomeAnimal.MaxLength = 20;
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(345, 27);
            this.txtNomeAnimal.TabIndex = 0;
            this.toolTipAnimal.SetToolTip(this.txtNomeAnimal, "Insira o nome do Animal");
            // 
            // lblRacaPorte
            // 
            this.lblRacaPorte.AutoSize = true;
            this.lblRacaPorte.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacaPorte.Location = new System.Drawing.Point(232, 98);
            this.lblRacaPorte.Name = "lblRacaPorte";
            this.lblRacaPorte.Size = new System.Drawing.Size(129, 23);
            this.lblRacaPorte.TabIndex = 5;
            this.lblRacaPorte.Text = "Raça/Porte: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(565, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Sexo:";
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnimal.Location = new System.Drawing.Point(232, 55);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(74, 23);
            this.lblNomeAnimal.TabIndex = 0;
            this.lblNomeAnimal.Text = "Nome:";
            // 
            // toolTipAnimal
            // 
            this.toolTipAnimal.AutomaticDelay = 100;
            this.toolTipAnimal.IsBalloon = true;
            this.toolTipAnimal.StripAmpersands = true;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.btnNovo.Location = new System.Drawing.Point(668, 142);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 44);
            this.btnNovo.TabIndex = 3;
            this.toolTipAnimal.SetToolTip(this.btnNovo, "Adicionar novo Cliente");
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // dtgCliente
            // 
            this.dtgCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(10, 93);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(634, 93);
            this.dtgCliente.TabIndex = 2;
            this.toolTipAnimal.SetToolTip(this.dtgCliente, "Resultado da Pesquisa");
            this.dtgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_SelectionChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::MariosPet.Properties.Resources.botaoConsultarVerde;
            this.btnConsultar.Location = new System.Drawing.Point(668, 39);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 44);
            this.btnConsultar.TabIndex = 1;
            this.toolTipAnimal.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisaCliente
            // 
            this.txtPesquisaCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisaCliente.Location = new System.Drawing.Point(89, 50);
            this.txtPesquisaCliente.MaxLength = 80;
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.Size = new System.Drawing.Size(555, 27);
            this.txtPesquisaCliente.TabIndex = 0;
            this.toolTipAnimal.SetToolTip(this.txtPesquisaCliente, "Insira o nome do Cliente que deseja pesquisar.");
            // 
            // groupBoxPesquisaAnimal
            // 
            this.groupBoxPesquisaAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxPesquisaAnimal.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromVerdeGrande;
            this.groupBoxPesquisaAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxPesquisaAnimal.Controls.Add(this.btnNovo);
            this.groupBoxPesquisaAnimal.Controls.Add(this.dtgCliente);
            this.groupBoxPesquisaAnimal.Controls.Add(this.btnConsultar);
            this.groupBoxPesquisaAnimal.Controls.Add(this.txtPesquisaCliente);
            this.groupBoxPesquisaAnimal.Controls.Add(this.lblNome);
            this.groupBoxPesquisaAnimal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxPesquisaAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxPesquisaAnimal.Location = new System.Drawing.Point(33, 24);
            this.groupBoxPesquisaAnimal.Name = "groupBoxPesquisaAnimal";
            this.groupBoxPesquisaAnimal.Size = new System.Drawing.Size(801, 204);
            this.groupBoxPesquisaAnimal.TabIndex = 31;
            this.groupBoxPesquisaAnimal.TabStop = false;
            this.groupBoxPesquisaAnimal.Text = "   Pesquisa";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(92, 23);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Cliente: ";
            // 
            // FrmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(885, 733);
            this.Controls.Add(this.groupBoxPesquisaAnimal);
            this.Controls.Add(this.groupBoxAnimal);
            this.Name = "FrmAnimal";
            this.Text = "Cadastro do Animal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.groupBoxPesquisaAnimal.ResumeLayout(false);
            this.groupBoxPesquisaAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnimal;
        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.MaskedTextBox maskedTxtNascimentoAnimal;
        private System.Windows.Forms.Label lblPelagemCor;
        private System.Windows.Forms.TextBox txtPelagemCor;
        private System.Windows.Forms.TextBox txtRacaPorte;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label lblRacaPorte;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.Label lblNascimentoAnimal;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Button btmSalvar;
        private System.Windows.Forms.ToolTip toolTipAnimal;
        private System.Windows.Forms.RadioButton radioButtonMacho;
        private System.Windows.Forms.RadioButton radioButtonFemea;
        private Classes.RoundButton roundButton1;
        private System.Windows.Forms.GroupBox groupBoxPesquisaAnimal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaCliente;
        private System.Windows.Forms.Label lblNome;


    }
}