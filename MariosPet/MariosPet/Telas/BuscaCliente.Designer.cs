namespace MariosPet.Telas
{
    partial class BuscaCliente
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
            this.buttonCancela = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.comboBoxPesquisa = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancela
            // 
            this.buttonCancela.FlatAppearance.BorderSize = 0;
            this.buttonCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancela.Image = global::MariosPet.Properties.Resources.botaoCancelarVerde;
            this.buttonCancela.Location = new System.Drawing.Point(535, 324);
            this.buttonCancela.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(117, 50);
            this.buttonCancela.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonCancela, "Cancelar");
            this.buttonCancela.UseVisualStyleBackColor = true;
            this.buttonCancela.Click += new System.EventHandler(this.buttonCancela_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.BackgroundImage = global::MariosPet.Properties.Resources.botaoSelecionarLaranja;
            this.buttonSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSelecionar.FlatAppearance.BorderSize = 0;
            this.buttonSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar.Location = new System.Drawing.Point(668, 324);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(120, 39);
            this.buttonSelecionar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonSelecionar, "Selecionar");
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 93);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(768, 213);
            this.dataGridView.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dataGridView, "Resultados da Pesquisa");
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackgroundImage = global::MariosPet.Properties.Resources.botaoPesquisarLaranja;
            this.buttonPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPesquisa.FlatAppearance.BorderSize = 0;
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisa.Location = new System.Drawing.Point(668, 33);
            this.buttonPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(120, 46);
            this.buttonPesquisa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonPesquisa, "Pesquisar");
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            // 
            // comboBoxPesquisa
            // 
            this.comboBoxPesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisa.FormattingEnabled = true;
            this.comboBoxPesquisa.Items.AddRange(new object[] {
            "",
            "",
            "ID",
            "Nome",
            "CPF",
            "RG"});
            this.comboBoxPesquisa.Location = new System.Drawing.Point(447, 43);
            this.comboBoxPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPesquisa.Name = "comboBoxPesquisa";
            this.comboBoxPesquisa.Size = new System.Drawing.Size(217, 31);
            this.comboBoxPesquisa.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxPesquisa, "Selecione o campo da Pesquisa");
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisa.Location = new System.Drawing.Point(20, 45);
            this.textBoxPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPesquisa.MaxLength = 80;
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(270, 31);
            this.textBoxPesquisa.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxPesquisa, "Digite o nome do cliente que está procurando.");
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelPesquisa.Location = new System.Drawing.Point(294, 51);
            this.labelPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(149, 23);
            this.labelPesquisa.TabIndex = 1;
            this.labelPesquisa.Text = "Pesquisar por:";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCliente.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromVerdeGrande;
            this.groupBoxCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxCliente.Controls.Add(this.buttonSelecionar);
            this.groupBoxCliente.Controls.Add(this.buttonCancela);
            this.groupBoxCliente.Controls.Add(this.buttonPesquisa);
            this.groupBoxCliente.Controls.Add(this.comboBoxPesquisa);
            this.groupBoxCliente.Controls.Add(this.dataGridView);
            this.groupBoxCliente.Controls.Add(this.textBoxPesquisa);
            this.groupBoxCliente.Controls.Add(this.labelPesquisa);
            this.groupBoxCliente.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxCliente.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(812, 388);
            this.groupBoxCliente.TabIndex = 8;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "   Pesquisar Cliente";
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(901, 429);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscaCliente";
            this.Text = "Busca Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.ComboBox comboBoxPesquisa;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBoxCliente;
    }
}