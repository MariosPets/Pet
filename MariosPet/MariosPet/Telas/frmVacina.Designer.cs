namespace MariosPet.Telas
{
    partial class frmVacina
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxVacina = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgVacina = new System.Windows.Forms.DataGridView();
            this.labelNomeAnimal = new System.Windows.Forms.Label();
            this.groupBoxVacina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVacina
            // 
            this.groupBoxVacina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxVacina.BackgroundImage = global::MariosPet.Properties.Resources.pataAmareloMarromGrande;
            this.groupBoxVacina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxVacina.Controls.Add(this.labelNomeAnimal);
            this.groupBoxVacina.Controls.Add(this.btnCancelar);
            this.groupBoxVacina.Controls.Add(this.btnNovo);
            this.groupBoxVacina.Controls.Add(this.dtgVacina);
            this.groupBoxVacina.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxVacina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxVacina.Location = new System.Drawing.Point(37, 34);
            this.groupBoxVacina.Name = "groupBoxVacina";
            this.groupBoxVacina.Size = new System.Drawing.Size(717, 263);
            this.groupBoxVacina.TabIndex = 6;
            this.groupBoxVacina.TabStop = false;
            this.groupBoxVacina.Text = "   Vacina";
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
            this.btnCancelar.TabIndex = 20;
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
            this.btnNovo.TabIndex = 3;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dtgVacina
            // 
            this.dtgVacina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVacina.Location = new System.Drawing.Point(10, 91);
            this.dtgVacina.Name = "dtgVacina";
            this.dtgVacina.Size = new System.Drawing.Size(674, 97);
            this.dtgVacina.TabIndex = 2;
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
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1034, 733);
            this.Controls.Add(this.groupBoxVacina);
            this.Name = "frmVacina";
            this.Text = "Vacina ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxVacina.ResumeLayout(false);
            this.groupBoxVacina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBoxVacina;
        private System.Windows.Forms.Label labelNomeAnimal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgVacina;

    }
}