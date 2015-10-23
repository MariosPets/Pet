namespace MariosPet.Telas
{
    partial class FrmBuscaVermifugo
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
            this.groupBoxBuscaVermifugo = new System.Windows.Forms.GroupBox();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.btmSalvar = new System.Windows.Forms.Button();
            this.btmNovo = new System.Windows.Forms.Button();
            this.dtgVermifugo = new System.Windows.Forms.DataGridView();
            this.btmConsultar = new System.Windows.Forms.Button();
            this.txtVermifugo = new System.Windows.Forms.TextBox();
            this.labelBuscaVermifugo = new System.Windows.Forms.Label();
            this.toolTipVermifugos = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxBuscaVermifugo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVermifugo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBuscaVermifugo
            // 
            this.groupBoxBuscaVermifugo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBuscaVermifugo.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromAmareloGrande;
            this.groupBoxBuscaVermifugo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxBuscaVermifugo.Controls.Add(this.btmConsultar);
            this.groupBoxBuscaVermifugo.Controls.Add(this.txtVermifugo);
            this.groupBoxBuscaVermifugo.Controls.Add(this.labelBuscaVermifugo);
            this.groupBoxBuscaVermifugo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxBuscaVermifugo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxBuscaVermifugo.Location = new System.Drawing.Point(40, 12);
            this.groupBoxBuscaVermifugo.Name = "groupBoxBuscaVermifugo";
            this.groupBoxBuscaVermifugo.Size = new System.Drawing.Size(717, 98);
            this.groupBoxBuscaVermifugo.TabIndex = 6;
            this.groupBoxBuscaVermifugo.TabStop = false;
            this.groupBoxBuscaVermifugo.Text = "   Busca Vermífugo";
            // 
            // btmLimpar
            // 
            this.btmLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmLimpar.BackgroundImage = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btmLimpar.FlatAppearance.BorderSize = 0;
            this.btmLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLimpar.Location = new System.Drawing.Point(450, 157);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(110, 40);
            this.btmLimpar.TabIndex = 5;
            this.toolTipVermifugos.SetToolTip(this.btmLimpar, "Limpar os Campos");
            this.btmLimpar.UseVisualStyleBackColor = false;
            // 
            // btmVoltar
            // 
            this.btmVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btmVoltar.FlatAppearance.BorderSize = 0;
            this.btmVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVoltar.Location = new System.Drawing.Point(328, 157);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(116, 49);
            this.btmVoltar.TabIndex = 4;
            this.toolTipVermifugos.SetToolTip(this.btmVoltar, "Voltar ao Menu");
            this.btmVoltar.UseVisualStyleBackColor = false;
            // 
            // btmSalvar
            // 
            this.btmSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmSalvar.BackgroundImage = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btmSalvar.FlatAppearance.BorderSize = 0;
            this.btmSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSalvar.Location = new System.Drawing.Point(566, 157);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(118, 43);
            this.btmSalvar.TabIndex = 6;
            this.toolTipVermifugos.SetToolTip(this.btmSalvar, "Salvar as Informações");
            this.btmSalvar.UseVisualStyleBackColor = false;
            // 
            // btmNovo
            // 
            this.btmNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmNovo.BackgroundImage = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.btmNovo.FlatAppearance.BorderSize = 0;
            this.btmNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNovo.Location = new System.Drawing.Point(6, 157);
            this.btmNovo.Name = "btmNovo";
            this.btmNovo.Size = new System.Drawing.Size(115, 43);
            this.btmNovo.TabIndex = 3;
            this.toolTipVermifugos.SetToolTip(this.btmNovo, "Adicionar novo Vermífugo");
            this.btmNovo.UseVisualStyleBackColor = false;
            // 
            // dtgVermifugo
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.dtgVermifugo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVermifugo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgVermifugo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVermifugo.Location = new System.Drawing.Point(10, 35);
            this.dtgVermifugo.Name = "dtgVermifugo";
            this.dtgVermifugo.Size = new System.Drawing.Size(674, 97);
            this.dtgVermifugo.TabIndex = 2;
            this.toolTipVermifugos.SetToolTip(this.dtgVermifugo, "Resultado da Pesquisa");
            // 
            // btmConsultar
            // 
            this.btmConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmConsultar.FlatAppearance.BorderSize = 0;
            this.btmConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmConsultar.Image = global::MariosPet.Properties.Resources.botaoConsultarVerde;
            this.btmConsultar.Location = new System.Drawing.Point(566, 46);
            this.btmConsultar.Name = "btmConsultar";
            this.btmConsultar.Size = new System.Drawing.Size(114, 32);
            this.btmConsultar.TabIndex = 1;
            this.toolTipVermifugos.SetToolTip(this.btmConsultar, "Consultar");
            this.btmConsultar.UseVisualStyleBackColor = false;
            this.btmConsultar.Click += new System.EventHandler(this.btmConsultar_Click);
            // 
            // txtVermifugo
            // 
            this.txtVermifugo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVermifugo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtVermifugo.Location = new System.Drawing.Point(191, 51);
            this.txtVermifugo.MaxLength = 50;
            this.txtVermifugo.Name = "txtVermifugo";
            this.txtVermifugo.Size = new System.Drawing.Size(369, 27);
            this.txtVermifugo.TabIndex = 0;
            this.toolTipVermifugos.SetToolTip(this.txtVermifugo, "Insira o nome do Vermífugo que deseja pesquisar");
            // 
            // labelBuscaVermifugo
            // 
            this.labelBuscaVermifugo.AutoSize = true;
            this.labelBuscaVermifugo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscaVermifugo.Location = new System.Drawing.Point(6, 50);
            this.labelBuscaVermifugo.Name = "labelBuscaVermifugo";
            this.labelBuscaVermifugo.Size = new System.Drawing.Size(179, 23);
            this.labelBuscaVermifugo.TabIndex = 16;
            this.labelBuscaVermifugo.Text = "Nome Vermífugo:";
            // 
            // toolTipVermifugos
            // 
            this.toolTipVermifugos.AutomaticDelay = 100;
            this.toolTipVermifugos.IsBalloon = true;
            this.toolTipVermifugos.StripAmpersands = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btmLimpar);
            this.groupBox1.Controls.Add(this.dtgVermifugo);
            this.groupBox1.Controls.Add(this.btmVoltar);
            this.groupBox1.Controls.Add(this.btmNovo);
            this.groupBox1.Controls.Add(this.btmSalvar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // FrmBuscaVermifugo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBuscaVermifugo);
            this.Name = "FrmBuscaVermifugo";
            this.Text = "Busca Vermifugo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxBuscaVermifugo.ResumeLayout(false);
            this.groupBoxBuscaVermifugo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVermifugo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscaVermifugo;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Button btmSalvar;
        private System.Windows.Forms.Button btmNovo;
        private System.Windows.Forms.DataGridView dtgVermifugo;
        private System.Windows.Forms.Button btmConsultar;
        private System.Windows.Forms.TextBox txtVermifugo;
        private System.Windows.Forms.Label labelBuscaVermifugo;
        private System.Windows.Forms.ToolTip toolTipVermifugos;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}