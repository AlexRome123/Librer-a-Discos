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
            this.txbFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnElimFisica = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.ptbTapaDisco.Location = new System.Drawing.Point(123, 33);
            this.ptbTapaDisco.Name = "ptbTapaDisco";
            this.ptbTapaDisco.Size = new System.Drawing.Size(153, 153);
            this.ptbTapaDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTapaDisco.TabIndex = 1;
            this.ptbTapaDisco.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbFiltroRapido);
            this.panel1.Controls.Add(this.btnElimFisica);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 454);
            this.panel1.TabIndex = 2;
            // 
            // txbFiltroRapido
            // 
            this.txbFiltroRapido.Location = new System.Drawing.Point(20, 328);
            this.txbFiltroRapido.Name = "txbFiltroRapido";
            this.txbFiltroRapido.Size = new System.Drawing.Size(100, 20);
            this.txbFiltroRapido.TabIndex = 4;
            this.txbFiltroRapido.TextChanged += new System.EventHandler(this.txbFiltroRapido_TextChanged);
            // 
            // btnElimFisica
            // 
            this.btnElimFisica.Location = new System.Drawing.Point(20, 418);
            this.btnElimFisica.Name = "btnElimFisica";
            this.btnElimFisica.Size = new System.Drawing.Size(100, 21);
            this.btnElimFisica.TabIndex = 3;
            this.btnElimFisica.Text = "Eliminar";
            this.btnElimFisica.UseVisualStyleBackColor = true;
            this.btnElimFisica.Click += new System.EventHandler(this.btnElimFisica_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(20, 371);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(557, 32);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(137, 20);
            this.txtFiltroAvanzado.TabIndex = 3;
            this.txtFiltroAvanzado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroAvanzado_KeyPress);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(282, 32);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 4;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(420, 33);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 5;
            this.cmbCriterio.SelectedIndexChanged += new System.EventHandler(this.cmbCriterio_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.txtFiltroAvanzado);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDiscos;
        private System.Windows.Forms.PictureBox ptbTapaDisco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnElimFisica;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.Button btnBuscar;
    }
}

