namespace MariosPet.Telas
{
    partial class FrmAgenda
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
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.groupBoxAgendamento = new System.Windows.Forms.GroupBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.checkBoxAtendido = new System.Windows.Forms.CheckBox();
            this.comboBoxServico = new System.Windows.Forms.ComboBox();
            this.labelServiço = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelHorariosAgendados = new System.Windows.Forms.Label();
            this.dataGridViewAgendados = new System.Windows.Forms.DataGridView();
            this.dataGridViewLivres = new System.Windows.Forms.DataGridView();
            this.labelHorariosLivres = new System.Windows.Forms.Label();
            this.textBoxFuncionario = new System.Windows.Forms.TextBox();
            this.buttonFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipAgenda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.AutoSize = true;
            this.labelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelFuncionario.Location = new System.Drawing.Point(106, 160);
            this.labelFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(92, 20);
            this.labelFuncionario.TabIndex = 0;
            this.labelFuncionario.Text = "Funcionário";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelData.Location = new System.Drawing.Point(106, 114);
            this.labelData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data";
            // 
            // groupBoxAgendamento
            // 
            this.groupBoxAgendamento.Controls.Add(this.labelHora);
            this.groupBoxAgendamento.Controls.Add(this.buttonCliente);
            this.groupBoxAgendamento.Controls.Add(this.textBoxCliente);
            this.groupBoxAgendamento.Controls.Add(this.buttonExcluir);
            this.groupBoxAgendamento.Controls.Add(this.buttonSalvar);
            this.groupBoxAgendamento.Controls.Add(this.checkBoxAtendido);
            this.groupBoxAgendamento.Controls.Add(this.comboBoxServico);
            this.groupBoxAgendamento.Controls.Add(this.labelServiço);
            this.groupBoxAgendamento.Controls.Add(this.labelCliente);
            this.groupBoxAgendamento.Enabled = false;
            this.groupBoxAgendamento.Location = new System.Drawing.Point(110, 196);
            this.groupBoxAgendamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAgendamento.Name = "groupBoxAgendamento";
            this.groupBoxAgendamento.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAgendamento.Size = new System.Drawing.Size(493, 174);
            this.groupBoxAgendamento.TabIndex = 20;
            this.groupBoxAgendamento.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelHora.Location = new System.Drawing.Point(4, 15);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(49, 20);
            this.labelHora.TabIndex = 29;
            this.labelHora.Text = "hh:hh";
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackgroundImage = global::MariosPet.Properties.Resources.botaoSelecionarLaranja;
            this.buttonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Location = new System.Drawing.Point(359, 36);
            this.buttonCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(122, 46);
            this.buttonCliente.TabIndex = 2;
            this.toolTipAgenda.SetToolTip(this.buttonCliente, "Selecionar Cliente");
            this.buttonCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.textBoxCliente.Location = new System.Drawing.Point(66, 50);
            this.textBoxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(289, 20);
            this.textBoxCliente.TabIndex = 1;
            this.toolTipAgenda.SetToolTip(this.textBoxCliente, "Insira o nome do Cliente");
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Image = global::MariosPet.Properties.Resources.botaoExcluirLaranja;
            this.buttonExcluir.Location = new System.Drawing.Point(232, 122);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(123, 48);
            this.buttonExcluir.TabIndex = 4;
            this.toolTipAgenda.SetToolTip(this.buttonExcluir, "Excluir");
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.buttonSalvar.Location = new System.Drawing.Point(359, 125);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(123, 42);
            this.buttonSalvar.TabIndex = 5;
            this.toolTipAgenda.SetToolTip(this.buttonSalvar, "Salvar");
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtendido
            // 
            this.checkBoxAtendido.AutoSize = true;
            this.checkBoxAtendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.checkBoxAtendido.Location = new System.Drawing.Point(377, 17);
            this.checkBoxAtendido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAtendido.Name = "checkBoxAtendido";
            this.checkBoxAtendido.Size = new System.Drawing.Size(81, 20);
            this.checkBoxAtendido.TabIndex = 4;
            this.checkBoxAtendido.Text = "Atendido";
            this.toolTipAgenda.SetToolTip(this.checkBoxAtendido, "Selecionar se Atendido");
            this.checkBoxAtendido.UseVisualStyleBackColor = true;
            // 
            // comboBoxServico
            // 
            this.comboBoxServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.comboBoxServico.FormattingEnabled = true;
            this.comboBoxServico.Location = new System.Drawing.Point(66, 87);
            this.comboBoxServico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxServico.Name = "comboBoxServico";
            this.comboBoxServico.Size = new System.Drawing.Size(289, 21);
            this.comboBoxServico.TabIndex = 3;
            this.toolTipAgenda.SetToolTip(this.comboBoxServico, "Selecionar Serviço");
            // 
            // labelServiço
            // 
            this.labelServiço.AutoSize = true;
            this.labelServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiço.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelServiço.Location = new System.Drawing.Point(4, 85);
            this.labelServiço.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelServiço.Name = "labelServiço";
            this.labelServiço.Size = new System.Drawing.Size(61, 20);
            this.labelServiço.TabIndex = 2;
            this.labelServiço.Text = "Serviço";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelCliente.Location = new System.Drawing.Point(4, 48);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(58, 20);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.Location = new System.Drawing.Point(163, 113);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(302, 20);
            this.dateTimePicker.TabIndex = 1;
            this.toolTipAgenda.SetToolTip(this.dateTimePicker, "Data");
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelHorariosAgendados
            // 
            this.labelHorariosAgendados.AutoSize = true;
            this.labelHorariosAgendados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorariosAgendados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelHorariosAgendados.Location = new System.Drawing.Point(114, 372);
            this.labelHorariosAgendados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHorariosAgendados.Name = "labelHorariosAgendados";
            this.labelHorariosAgendados.Size = new System.Drawing.Size(155, 20);
            this.labelHorariosAgendados.TabIndex = 0;
            this.labelHorariosAgendados.Text = "Horários Agendados";
            // 
            // dataGridViewAgendados
            // 
            this.dataGridViewAgendados.AllowUserToAddRows = false;
            this.dataGridViewAgendados.AllowUserToDeleteRows = false;
            this.dataGridViewAgendados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.dataGridViewAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendados.Location = new System.Drawing.Point(118, 395);
            this.dataGridViewAgendados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAgendados.Name = "dataGridViewAgendados";
            this.dataGridViewAgendados.ReadOnly = true;
            this.dataGridViewAgendados.RowTemplate.Height = 24;
            this.dataGridViewAgendados.Size = new System.Drawing.Size(180, 122);
            this.dataGridViewAgendados.TabIndex = 10;
            this.toolTipAgenda.SetToolTip(this.dataGridViewAgendados, "Horários Agendados");
            // 
            // dataGridViewLivres
            // 
            this.dataGridViewLivres.AllowUserToAddRows = false;
            this.dataGridViewLivres.AllowUserToDeleteRows = false;
            this.dataGridViewLivres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.dataGridViewLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivres.Location = new System.Drawing.Point(358, 395);
            this.dataGridViewLivres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewLivres.Name = "dataGridViewLivres";
            this.dataGridViewLivres.ReadOnly = true;
            this.dataGridViewLivres.RowTemplate.Height = 24;
            this.dataGridViewLivres.Size = new System.Drawing.Size(180, 122);
            this.dataGridViewLivres.TabIndex = 11;
            this.toolTipAgenda.SetToolTip(this.dataGridViewLivres, "Horários Livres");
            // 
            // labelHorariosLivres
            // 
            this.labelHorariosLivres.AutoSize = true;
            this.labelHorariosLivres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorariosLivres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelHorariosLivres.Location = new System.Drawing.Point(357, 372);
            this.labelHorariosLivres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHorariosLivres.Name = "labelHorariosLivres";
            this.labelHorariosLivres.Size = new System.Drawing.Size(114, 20);
            this.labelHorariosLivres.TabIndex = 0;
            this.labelHorariosLivres.Text = "Horários Livres";
            // 
            // textBoxFuncionario
            // 
            this.textBoxFuncionario.Enabled = false;
            this.textBoxFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.textBoxFuncionario.Location = new System.Drawing.Point(202, 160);
            this.textBoxFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFuncionario.Name = "textBoxFuncionario";
            this.textBoxFuncionario.Size = new System.Drawing.Size(263, 20);
            this.textBoxFuncionario.TabIndex = 2;
            this.toolTipAgenda.SetToolTip(this.textBoxFuncionario, "Insira o nome do Funcionário");
            this.textBoxFuncionario.TextChanged += new System.EventHandler(this.textBoxFuncionario_TextChanged);
            // 
            // buttonFuncionario
            // 
            this.buttonFuncionario.BackgroundImage = global::MariosPet.Properties.Resources.botaoSelecionarLaranja;
            this.buttonFuncionario.FlatAppearance.BorderSize = 0;
            this.buttonFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFuncionario.Location = new System.Drawing.Point(469, 148);
            this.buttonFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFuncionario.Name = "buttonFuncionario";
            this.buttonFuncionario.Size = new System.Drawing.Size(118, 42);
            this.buttonFuncionario.TabIndex = 3;
            this.toolTipAgenda.SetToolTip(this.buttonFuncionario, "Selecionar Funcionário");
            this.buttonFuncionario.UseVisualStyleBackColor = true;
            this.buttonFuncionario.Click += new System.EventHandler(this.buttonFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::MariosPet.Properties.Resources.pataAmareloVerdeGrande;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(105, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "     AGENDA";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1022, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFuncionario);
            this.Controls.Add(this.textBoxFuncionario);
            this.Controls.Add(this.dataGridViewLivres);
            this.Controls.Add(this.labelHorariosLivres);
            this.Controls.Add(this.dataGridViewAgendados);
            this.Controls.Add(this.labelHorariosAgendados);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBoxAgendamento);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelFuncionario);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAgenda";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.groupBoxAgendamento.ResumeLayout(false);
            this.groupBoxAgendamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.GroupBox groupBoxAgendamento;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.CheckBox checkBoxAtendido;
        private System.Windows.Forms.ComboBox comboBoxServico;
        private System.Windows.Forms.Label labelServiço;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelHorariosAgendados;
        private System.Windows.Forms.DataGridView dataGridViewAgendados;
        private System.Windows.Forms.DataGridView dataGridViewLivres;
        private System.Windows.Forms.Label labelHorariosLivres;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxFuncionario;
        private System.Windows.Forms.Button buttonFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipAgenda;
    }
}