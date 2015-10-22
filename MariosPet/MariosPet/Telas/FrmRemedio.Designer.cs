namespace MariosPet.Telas
{
    partial class FrmRemedio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.nudMaximo = new System.Windows.Forms.NumericUpDown();
            this.nudMinimo = new System.Windows.Forms.NumericUpDown();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.toolTipRemedio = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromVerdeGrande;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.nudMaximo);
            this.groupBox1.Controls.Add(this.nudMinimo);
            this.groupBox1.Controls.Add(this.nudQuantidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(222, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 233);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Dados do Medicamento";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarLaranja;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(352, 181);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 46);
            this.btnVoltar.TabIndex = 4;
            this.toolTipRemedio.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnLimpar.BackgroundImage = global::MariosPet.Properties.Resources.botaoLimparVerde;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(489, 181);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 46);
            this.btnLimpar.TabIndex = 5;
            this.toolTipRemedio.SetToolTip(this.btnLimpar, "Limpar os Campos");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarLaranja;
            this.btnSalvar.Location = new System.Drawing.Point(611, 181);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 46);
            this.btnSalvar.TabIndex = 6;
            this.toolTipRemedio.SetToolTip(this.btnSalvar, "Salvar as Informações");
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // nudMaximo
            // 
            this.nudMaximo.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.nudMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.nudMaximo.Location = new System.Drawing.Point(560, 122);
            this.nudMaximo.Name = "nudMaximo";
            this.nudMaximo.Size = new System.Drawing.Size(83, 31);
            this.nudMaximo.TabIndex = 3;
            this.toolTipRemedio.SetToolTip(this.nudMaximo, "Insira a Quantidade Máxima");
            // 
            // nudMinimo
            // 
            this.nudMinimo.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.nudMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.nudMinimo.Location = new System.Drawing.Point(250, 122);
            this.nudMinimo.Name = "nudMinimo";
            this.nudMinimo.Size = new System.Drawing.Size(81, 31);
            this.nudMinimo.TabIndex = 2;
            this.toolTipRemedio.SetToolTip(this.nudMinimo, "Insira a Quantidade Mínima");
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.nudQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.nudQuantidade.Location = new System.Drawing.Point(250, 76);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(81, 31);
            this.nudQuantidade.TabIndex = 1;
            this.toolTipRemedio.SetToolTip(this.nudQuantidade, "Insira a Quantidade");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Máximo no estoque:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtMedicamento.Location = new System.Drawing.Point(250, 36);
            this.txtMedicamento.MaxLength = 50;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(469, 27);
            this.txtMedicamento.TabIndex = 0;
            this.toolTipRemedio.SetToolTip(this.txtMedicamento, "Insira o Nome do Medicamento");
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(42, 130);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(202, 23);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "Minimo no estoque:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(116, 78);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(128, 23);
            this.lblCpf.TabIndex = 17;
            this.lblCpf.Text = "Quantidade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(238, 23);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome do Medicamento:";
            // 
            // toolTipRemedio
            // 
            this.toolTipRemedio.AutomaticDelay = 100;
            this.toolTipRemedio.IsBalloon = true;
            this.toolTipRemedio.StripAmpersands = true;
            // 
            // FrmRemedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1114, 733);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRemedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Remedio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.NumericUpDown nudMaximo;
        private System.Windows.Forms.NumericUpDown nudMinimo;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolTip toolTipRemedio;
    }
}