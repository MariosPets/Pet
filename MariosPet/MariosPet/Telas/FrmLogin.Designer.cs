namespace MariosPet
{
    partial class FrmLogin
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.btmEntrar = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpLogin.Controls.Add(this.textSenha);
            this.grpLogin.Controls.Add(this.labelSenha);
            this.grpLogin.Controls.Add(this.labelUsuario);
            this.grpLogin.Controls.Add(this.textUsuario);
            this.grpLogin.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.grpLogin.Location = new System.Drawing.Point(301, 107);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(382, 199);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "   Login";
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.textSenha.Location = new System.Drawing.Point(142, 124);
            this.textSenha.MaxLength = 20;
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '•';
            this.textSenha.Size = new System.Drawing.Size(186, 31);
            this.textSenha.TabIndex = 2;
            this.toolTipLogin.SetToolTip(this.textSenha, "Insira a Senha");
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Verdana", 16F);
            this.labelSenha.Location = new System.Drawing.Point(55, 129);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(81, 26);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Verdana", 16F);
            this.labelUsuario.Location = new System.Drawing.Point(42, 63);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(94, 26);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuário";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.textUsuario.Location = new System.Drawing.Point(142, 58);
            this.textUsuario.MaxLength = 20;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(186, 31);
            this.textUsuario.TabIndex = 1;
            this.toolTipLogin.SetToolTip(this.textUsuario, "Insira o Login");
            // 
            // toolTipLogin
            // 
            this.toolTipLogin.AutomaticDelay = 100;
            this.toolTipLogin.IsBalloon = true;
            this.toolTipLogin.ShowAlways = true;
            // 
            // btmEntrar
            // 
            this.btmEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btmEntrar.FlatAppearance.BorderSize = 0;
            this.btmEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmEntrar.Image = global::MariosPet.Properties.Resources.botaoEntrarLaranja;
            this.btmEntrar.Location = new System.Drawing.Point(566, 312);
            this.btmEntrar.Name = "btmEntrar";
            this.btmEntrar.Size = new System.Drawing.Size(117, 48);
            this.btmEntrar.TabIndex = 2;
            this.toolTipLogin.SetToolTip(this.btmEntrar, "Entrar no sistema");
            this.btmEntrar.UseVisualStyleBackColor = false;
            this.btmEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // btmSair
            // 
            this.btmSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btmSair.FlatAppearance.BorderSize = 0;
            this.btmSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSair.Image = global::MariosPet.Properties.Resources.botaoSairVerde;
            this.btmSair.Location = new System.Drawing.Point(301, 312);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(123, 48);
            this.btmSair.TabIndex = 1;
            this.toolTipLogin.SetToolTip(this.btmSair, "Sair do sistema");
            this.btmSair.UseVisualStyleBackColor = false;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::MariosPet.Properties.Resources.logoRosa;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(71, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 215);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(727, 435);
            this.Controls.Add(this.btmEntrar);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip tiplogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.Button btmEntrar;
        private System.Windows.Forms.ToolTip toolTipLogin;
    }
}