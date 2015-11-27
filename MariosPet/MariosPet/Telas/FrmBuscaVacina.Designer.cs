namespace MariosPet.Telas
{
    partial class FrmBuscaVacina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscaVacina));
            this.groupBoxBuscaVacina = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaVacina = new System.Windows.Forms.TextBox();
            this.lblNomeVacina = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgBuscaVacina = new System.Windows.Forms.DataGridView();
            this.toolTipBuscaVacina = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxBuscaVacina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaVacina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBuscaVacina
            // 
            this.groupBoxBuscaVacina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBuscaVacina.BackgroundImage = global::MariosPet.Properties.Resources.pataAmareloMarromGrande;
            this.groupBoxBuscaVacina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxBuscaVacina.Controls.Add(this.btnConsultar);
            this.groupBoxBuscaVacina.Controls.Add(this.txtPesquisaVacina);
            this.groupBoxBuscaVacina.Controls.Add(this.lblNomeVacina);
            this.groupBoxBuscaVacina.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxBuscaVacina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxBuscaVacina.Location = new System.Drawing.Point(67, 28);
            this.groupBoxBuscaVacina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBuscaVacina.Name = "groupBoxBuscaVacina";
            this.groupBoxBuscaVacina.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBuscaVacina.Size = new System.Drawing.Size(935, 121);
            this.groupBoxBuscaVacina.TabIndex = 5;
            this.groupBoxBuscaVacina.TabStop = false;
            this.groupBoxBuscaVacina.Text = "   Busca Vacina";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnConsultar.BackgroundImage = global::MariosPet.Properties.Resources.botaoConsultarVerde;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(756, 52);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 49);
            this.btnConsultar.TabIndex = 1;
            this.toolTipBuscaVacina.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisaVacina
            // 
            this.txtPesquisaVacina.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaVacina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisaVacina.Location = new System.Drawing.Point(212, 62);
            this.txtPesquisaVacina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaVacina.MaxLength = 50;
            this.txtPesquisaVacina.Name = "txtPesquisaVacina";
            this.txtPesquisaVacina.Size = new System.Drawing.Size(519, 32);
            this.txtPesquisaVacina.TabIndex = 0;
            this.toolTipBuscaVacina.SetToolTip(this.txtPesquisaVacina, "Insira o nome da Vacina que deseja pesquisar.");
            // 
            // lblNomeVacina
            // 
            this.lblNomeVacina.AutoSize = true;
            this.lblNomeVacina.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVacina.Location = new System.Drawing.Point(8, 62);
            this.lblNomeVacina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeVacina.Name = "lblNomeVacina";
            this.lblNomeVacina.Size = new System.Drawing.Size(180, 29);
            this.lblNomeVacina.TabIndex = 16;
            this.lblNomeVacina.Text = "Nome Vacina:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btnSalvar.Location = new System.Drawing.Point(757, 174);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(156, 38);
            this.btnSalvar.TabIndex = 6;
            this.toolTipBuscaVacina.SetToolTip(this.btnSalvar, "Salvar as Informações");
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btnLimpar.Location = new System.Drawing.Point(605, 174);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 38);
            this.btnLimpar.TabIndex = 5;
            this.toolTipBuscaVacina.SetToolTip(this.btnLimpar, "Limpar os Campos");
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btnVoltar.Location = new System.Drawing.Point(400, 174);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(168, 38);
            this.btnVoltar.TabIndex = 4;
            this.toolTipBuscaVacina.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.btnNovo.Location = new System.Drawing.Point(13, 174);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(156, 47);
            this.btnNovo.TabIndex = 3;
            this.toolTipBuscaVacina.SetToolTip(this.btnNovo, "Adicionar nova Vacina");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtgBuscaVacina
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.dtgBuscaVacina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBuscaVacina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgBuscaVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaVacina.Location = new System.Drawing.Point(13, 23);
            this.dtgBuscaVacina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgBuscaVacina.Name = "dtgBuscaVacina";
            this.dtgBuscaVacina.Size = new System.Drawing.Size(899, 119);
            this.dtgBuscaVacina.TabIndex = 2;
            this.toolTipBuscaVacina.SetToolTip(this.dtgBuscaVacina, "Resultado da Pesquisa");
            // 
            // toolTipBuscaVacina
            // 
            this.toolTipBuscaVacina.AutomaticDelay = 100;
            this.toolTipBuscaVacina.IsBalloon = true;
            this.toolTipBuscaVacina.StripAmpersands = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.dtgBuscaVacina);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(67, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(935, 244);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // FrmBuscaVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1099, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBuscaVacina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBuscaVacina";
            this.Text = "Busca Vacina";
            this.groupBoxBuscaVacina.ResumeLayout(false);
            this.groupBoxBuscaVacina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaVacina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscaVacina;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgBuscaVacina;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaVacina;
        private System.Windows.Forms.Label lblNomeVacina;
        private System.Windows.Forms.ToolTip toolTipBuscaVacina;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}