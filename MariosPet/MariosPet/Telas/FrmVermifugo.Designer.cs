namespace MariosPet.Telas
{
    partial class FrmVermifugo
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
            this.groupBoxVermifugo = new System.Windows.Forms.GroupBox();
            this.labelNomeAnimal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgVermifugo = new System.Windows.Forms.DataGridView();
            this.toolTipVermifugo = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxVermifugo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVermifugo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVermifugo
            // 
            this.groupBoxVermifugo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxVermifugo.BackgroundImage = global::MariosPet.Properties.Resources.pataAmareloMarromGrande;
            this.groupBoxVermifugo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxVermifugo.Controls.Add(this.labelNomeAnimal);
            this.groupBoxVermifugo.Controls.Add(this.btnCancelar);
            this.groupBoxVermifugo.Controls.Add(this.btnNovo);
            this.groupBoxVermifugo.Controls.Add(this.dtgVermifugo);
            this.groupBoxVermifugo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxVermifugo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxVermifugo.Location = new System.Drawing.Point(43, 54);
            this.groupBoxVermifugo.Name = "groupBoxVermifugo";
            this.groupBoxVermifugo.Size = new System.Drawing.Size(717, 263);
            this.groupBoxVermifugo.TabIndex = 7;
            this.groupBoxVermifugo.TabStop = false;
            this.groupBoxVermifugo.Text = "   Vermifugo";
            // 
            // labelNomeAnimal
            // 
            this.labelNomeAnimal.AutoSize = true;
            this.labelNomeAnimal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAnimal.Location = new System.Drawing.Point(6, 46);
            this.labelNomeAnimal.Name = "labelNomeAnimal";
            this.labelNomeAnimal.Size = new System.Drawing.Size(169, 23);
            this.labelNomeAnimal.TabIndex = 22;
            this.labelNomeAnimal.Text = "Nome do Animal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::MariosPet.Properties.Resources.botaoCancelarVerde;
            this.btnCancelar.Location = new System.Drawing.Point(435, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 31);
            this.btnCancelar.TabIndex = 1;
            this.toolTipVermifugo.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.btnNovo.Location = new System.Drawing.Point(567, 206);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 38);
            this.btnNovo.TabIndex = 2;
            this.toolTipVermifugo.SetToolTip(this.btnNovo, "Adicionar novo Vermífugo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtgVermifugo
            // 
            this.dtgVermifugo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgVermifugo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVermifugo.Location = new System.Drawing.Point(10, 91);
            this.dtgVermifugo.Name = "dtgVermifugo";
            this.dtgVermifugo.Size = new System.Drawing.Size(674, 97);
            this.dtgVermifugo.TabIndex = 0;
            this.toolTipVermifugo.SetToolTip(this.dtgVermifugo, "Vermífugos que o Animal já tomou.");
            // 
            // toolTipVermifugo
            // 
            this.toolTipVermifugo.AutomaticDelay = 100;
            this.toolTipVermifugo.IsBalloon = true;
            this.toolTipVermifugo.StripAmpersands = true;
            // 
            // FrmVermifugo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 371);
            this.Controls.Add(this.groupBoxVermifugo);
            this.Name = "FrmVermifugo";
            this.Text = "Vermifugo";
            this.groupBoxVermifugo.ResumeLayout(false);
            this.groupBoxVermifugo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVermifugo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVermifugo;
        private System.Windows.Forms.Label labelNomeAnimal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgVermifugo;
        private System.Windows.Forms.ToolTip toolTipVermifugo;

    }
}