namespace libreriaDiscos_app
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaDiscos = new System.Windows.Forms.DataGridView();
            this.ptbTapaDisco = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnElimFisica = new System.Windows.Forms.Button();
            this.BtnElimLogica = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTapaDisco)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaDiscos
            // 
            this.dgvListaDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDiscos.Location = new System.Drawing.Point(282, 59);
            this.dgvListaDiscos.Name = "dgvListaDiscos";
            this.dgvListaDiscos.Size = new System.Drawing.Size(506, 379);
            this.dgvListaDiscos.TabIndex = 0;
            this.dgvListaDiscos.SelectionChanged += new System.EventHandler(this.dgvListaDiscos_SelectionChanged);
            // 
            // ptbTapaDisco
            // 
            this.ptbTapaDisco.Location = new System.Drawing.Point(123, 59);
            this.ptbTapaDisco.Name = "ptbTapaDisco";
            this.ptbTapaDisco.Size = new System.Drawing.Size(153, 153);
            this.ptbTapaDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTapaDisco.TabIndex = 1;
            this.ptbTapaDisco.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnElimFisica);
            this.panel1.Controls.Add(this.BtnElimLogica);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 454);
            this.panel1.TabIndex = 2;
            // 
            // btnElimFisica
            // 
            this.btnElimFisica.Location = new System.Drawing.Point(31, 160);
            this.btnElimFisica.Name = "btnElimFisica";
            this.btnElimFisica.Size = new System.Drawing.Size(75, 39);
            this.btnElimFisica.TabIndex = 3;
            this.btnElimFisica.Text = "Eliminar Física";
            this.btnElimFisica.UseVisualStyleBackColor = true;
            // 
            // BtnElimLogica
            // 
            this.BtnElimLogica.Location = new System.Drawing.Point(31, 118);
            this.BtnElimLogica.Name = "BtnElimLogica";
            this.BtnElimLogica.Size = new System.Drawing.Size(75, 36);
            this.BtnElimLogica.TabIndex = 2;
            this.BtnElimLogica.Text = "Eliminar Lógica";
            this.BtnElimLogica.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(31, 89);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbTapaDisco);
            this.Controls.Add(this.dgvListaDiscos);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreria Discos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTapaDisco)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDiscos;
        private System.Windows.Forms.PictureBox ptbTapaDisco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnElimFisica;
        private System.Windows.Forms.Button BtnElimLogica;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

