namespace MariosPet.Telas
{
    partial class FrmReceituario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceituario));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeVeterinario = new System.Windows.Forms.TextBox();
            this.txtPrescricao = new System.Windows.Forms.RichTextBox();
            this.toolTipReceituario = new System.Windows.Forms.ToolTip(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(600, 15);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(175, 44);
            this.btnSalvar.TabIndex = 2;
            this.toolTipReceituario.SetToolTip(this.btnSalvar, "Salvar Receituário");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeVeterinario
            // 
            this.txtNomeVeterinario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtNomeVeterinario.Location = new System.Drawing.Point(192, 156);
            this.txtNomeVeterinario.Name = "txtNomeVeterinario";
            this.txtNomeVeterinario.Size = new System.Drawing.Size(260, 27);
            this.txtNomeVeterinario.TabIndex = 0;
            this.toolTipReceituario.SetToolTip(this.txtNomeVeterinario, "Insira a Identificação do Veterinário");
            // 
            // txtPrescricao
            // 
            this.txtPrescricao.Location = new System.Drawing.Point(21, 330);
            this.txtPrescricao.Name = "txtPrescricao";
            this.txtPrescricao.Size = new System.Drawing.Size(524, 482);
            this.txtPrescricao.TabIndex = 1;
            this.txtPrescricao.Text = "";
            this.toolTipReceituario.SetToolTip(this.txtPrescricao, "Insira a Prescrição");
            // 
            // toolTipReceituario
            // 
            this.toolTipReceituario.AutomaticDelay = 100;
            this.toolTipReceituario.IsBalloon = true;
            this.toolTipReceituario.StripAmpersands = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarLaranja;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(633, 68);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 44);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmReceituario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::MariosPet.Properties.Resources.receituario1038X574;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(993, 733);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtPrescricao);
            this.Controls.Add(this.txtNomeVeterinario);
            this.Controls.Add(this.btnSalvar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmReceituario";
            this.Text = "FrmReceituario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeVeterinario;
        private System.Windows.Forms.RichTextBox txtPrescricao;
        private System.Windows.Forms.ToolTip toolTipReceituario;
        private System.Windows.Forms.Button btnVoltar;
    }
}