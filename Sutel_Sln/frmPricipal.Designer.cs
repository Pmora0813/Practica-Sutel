namespace Sutel_Sln
{
    partial class frmPricipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnmovistar = new System.Windows.Forms.RadioButton();
            this.rbtnClaro = new System.Windows.Forms.RadioButton();
            this.rbtnkolbi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.npdMinutos = new System.Windows.Forms.NumericUpDown();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdMinutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnmovistar);
            this.groupBox1.Controls.Add(this.rbtnClaro);
            this.groupBox1.Controls.Add(this.rbtnkolbi);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // rbtnmovistar
            // 
            this.rbtnmovistar.AutoSize = true;
            this.rbtnmovistar.Location = new System.Drawing.Point(339, 45);
            this.rbtnmovistar.Name = "rbtnmovistar";
            this.rbtnmovistar.Size = new System.Drawing.Size(90, 22);
            this.rbtnmovistar.TabIndex = 2;
            this.rbtnmovistar.TabStop = true;
            this.rbtnmovistar.Text = "Movistar";
            this.rbtnmovistar.UseVisualStyleBackColor = true;
            // 
            // rbtnClaro
            // 
            this.rbtnClaro.AutoSize = true;
            this.rbtnClaro.Location = new System.Drawing.Point(188, 45);
            this.rbtnClaro.Name = "rbtnClaro";
            this.rbtnClaro.Size = new System.Drawing.Size(63, 22);
            this.rbtnClaro.TabIndex = 1;
            this.rbtnClaro.TabStop = true;
            this.rbtnClaro.Text = "Claro";
            this.rbtnClaro.UseVisualStyleBackColor = true;
            // 
            // rbtnkolbi
            // 
            this.rbtnkolbi.AutoSize = true;
            this.rbtnkolbi.Location = new System.Drawing.Point(41, 45);
            this.rbtnkolbi.Name = "rbtnkolbi";
            this.rbtnkolbi.Size = new System.Drawing.Size(60, 22);
            this.rbtnkolbi.TabIndex = 0;
            this.rbtnkolbi.TabStop = true;
            this.rbtnkolbi.Text = "kolbi";
            this.rbtnkolbi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.npdMinutos);
            this.groupBox2.Controls.Add(this.mskNumero);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Telefono";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(327, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 33);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(113, 74);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 33);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // npdMinutos
            // 
            this.npdMinutos.Location = new System.Drawing.Point(394, 25);
            this.npdMinutos.Name = "npdMinutos";
            this.npdMinutos.Size = new System.Drawing.Size(62, 26);
            this.npdMinutos.TabIndex = 3;
            this.npdMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(122, 19);
            this.mskNumero.Mask = "99999999";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(112, 26);
            this.mskNumero.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTelefonos);
            this.groupBox3.Location = new System.Drawing.Point(24, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 154);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teléfonos";
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTelefonos.Enabled = false;
            this.dgvTelefonos.Location = new System.Drawing.Point(3, 22);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.Size = new System.Drawing.Size(519, 129);
            this.dgvTelefonos.TabIndex = 0;
            // 
            // frmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sutel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdMinutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnmovistar;
        private System.Windows.Forms.RadioButton rbtnClaro;
        private System.Windows.Forms.RadioButton rbtnkolbi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.NumericUpDown npdMinutos;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTelefonos;
    }
}

