namespace MariosPet.Telas
{
    partial class FrmServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServico));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBoxServico = new System.Windows.Forms.GroupBox();
            this.mstPreco = new System.Windows.Forms.MaskedTextBox();
            this.toolTipServicos = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(221, 23);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Descrição do Serviço:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(173, 78);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(71, 23);
            this.lblCpf.TabIndex = 17;
            this.lblCpf.Text = "Preço:";
            // 
            // txtServico
            // 
            this.txtServico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtServico.Location = new System.Drawing.Point(262, 36);
            this.txtServico.MaxLength = 30;
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(449, 27);
            this.txtServico.TabIndex = 0;
            this.toolTipServicos.SetToolTip(this.txtServico, "Descreva o Serviço");
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(608, 128);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 46);
            this.btnSalvar.TabIndex = 4;
            this.toolTipServicos.SetToolTip(this.btnSalvar, "Salvar as Informações");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnLimpar.BackgroundImage = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(475, 128);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 46);
            this.btnLimpar.TabIndex = 3;
            this.toolTipServicos.SetToolTip(this.btnLimpar, "Limpar os Campos");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(333, 128);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 46);
            this.btnVoltar.TabIndex = 2;
            this.toolTipServicos.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBoxServico
            // 
            this.groupBoxServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxServico.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromAmareloGrande;
            this.groupBoxServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxServico.Controls.Add(this.mstPreco);
            this.groupBoxServico.Controls.Add(this.btnVoltar);
            this.groupBoxServico.Controls.Add(this.btnLimpar);
            this.groupBoxServico.Controls.Add(this.btnSalvar);
            this.groupBoxServico.Controls.Add(this.txtServico);
            this.groupBoxServico.Controls.Add(this.lblCpf);
            this.groupBoxServico.Controls.Add(this.lblNome);
            this.groupBoxServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxServico.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxServico.Location = new System.Drawing.Point(201, 8);
            this.groupBoxServico.Name = "groupBoxServico";
            this.groupBoxServico.Size = new System.Drawing.Size(743, 197);
            this.groupBoxServico.TabIndex = 4;
            this.groupBoxServico.TabStop = false;
            this.groupBoxServico.Text = "   Dados do Serviço";
            // 
            // mstPreco
            // 
            this.mstPreco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mstPreco.Location = new System.Drawing.Point(262, 79);
            this.mstPreco.Name = "mstPreco";
            this.mstPreco.Size = new System.Drawing.Size(107, 27);
            this.mstPreco.TabIndex = 1;
            this.toolTipServicos.SetToolTip(this.mstPreco, "Insira o Valor");
            // 
            // toolTipServicos
            // 
            this.toolTipServicos.AutomaticDelay = 100;
            this.toolTipServicos.IsBalloon = true;
            this.toolTipServicos.StripAmpersands = true;
            // 
            // FrmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1114, 733);
            this.Controls.Add(this.groupBoxServico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServico";
            this.Text = "Cadastrar Serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxServico.ResumeLayout(false);
            this.groupBoxServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBoxServico;
        private System.Windows.Forms.MaskedTextBox mstPreco;
        private System.Windows.Forms.ToolTip toolTipServicos;
    }
}