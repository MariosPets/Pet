namespace MariosPet.Telas
{
    partial class BuscaFuncionario
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
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxPesquisa = new System.Windows.Forms.ComboBox();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancela = new System.Windows.Forms.Button();
            this.toolTipPesquisaFuncionario = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisa.Location = new System.Drawing.Point(333, 56);
            this.labelPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(149, 23);
            this.labelPesquisa.TabIndex = 1;
            this.labelPesquisa.Text = "Pesquisar por:";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisa.Location = new System.Drawing.Point(23, 48);
            this.textBoxPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPesquisa.MaxLength = 80;
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(294, 31);
            this.textBoxPesquisa.TabIndex = 0;
            this.toolTipPesquisaFuncionario.SetToolTip(this.textBoxPesquisa, "Digite o nome do funcionário que está procurando.");
            // 
            // comboBoxPesquisa
            // 
            this.comboBoxPesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisa.FormattingEnabled = true;
            this.comboBoxPesquisa.Items.AddRange(new object[] {
            "",
            "ID",
            "Nome",
            "CPF",
            "RG",
            "Tipo",
            "Apelido"});
            this.comboBoxPesquisa.Location = new System.Drawing.Point(486, 48);
            this.comboBoxPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPesquisa.Name = "comboBoxPesquisa";
            this.comboBoxPesquisa.Size = new System.Drawing.Size(215, 31);
            this.comboBoxPesquisa.TabIndex = 1;
            this.toolTipPesquisaFuncionario.SetToolTip(this.comboBoxPesquisa, "Selecione o campo da Pesquisa");
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.FlatAppearance.BorderSize = 0;
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisa.Image = global::MariosPet.Properties.Resources.botaoPesquisarLaranja;
            this.buttonPesquisa.Location = new System.Drawing.Point(705, 38);
            this.buttonPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(119, 49);
            this.buttonPesquisa.TabIndex = 2;
            this.toolTipPesquisaFuncionario.SetToolTip(this.buttonPesquisa, "Pesquisar");
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 95);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(801, 231);
            this.dataGridView.TabIndex = 3;
            this.toolTipPesquisaFuncionario.SetToolTip(this.dataGridView, "Resultado da Pesquisa");
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.BackgroundImage = global::MariosPet.Properties.Resources.botaoSelecionarLaranja;
            this.buttonSelecionar.FlatAppearance.BorderSize = 0;
            this.buttonSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSelecionar.Location = new System.Drawing.Point(713, 347);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(111, 42);
            this.buttonSelecionar.TabIndex = 5;
            this.toolTipPesquisaFuncionario.SetToolTip(this.buttonSelecionar, "Selecionar");
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonCancela
            // 
            this.buttonCancela.BackgroundImage = global::MariosPet.Properties.Resources.botaoCancelarVerde;
            this.buttonCancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancela.FlatAppearance.BorderSize = 0;
            this.buttonCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancela.Location = new System.Drawing.Point(585, 344);
            this.buttonCancela.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(116, 45);
            this.buttonCancela.TabIndex = 4;
            this.toolTipPesquisaFuncionario.SetToolTip(this.buttonCancela, "Cancelar");
            this.buttonCancela.UseVisualStyleBackColor = true;
            this.buttonCancela.Click += new System.EventHandler(this.buttonCancela_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPesquisa);
            this.groupBox1.Controls.Add(this.labelPesquisa);
            this.groupBox1.Controls.Add(this.buttonSelecionar);
            this.groupBox1.Controls.Add(this.buttonCancela);
            this.groupBox1.Controls.Add(this.comboBoxPesquisa);
            this.groupBox1.Controls.Add(this.buttonPesquisa);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(27, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 407);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Pesquisar Funcionário";
            // 
            // BuscaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(895, 461);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscaFuncionario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Busca Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxPesquisa;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.ToolTip toolTipPesquisaFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}