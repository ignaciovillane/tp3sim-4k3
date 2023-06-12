namespace tp3Montecarlo
{
    partial class Form1
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
            this.dgvFrecuencias = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFrecuenciaAusentismo = new System.Windows.Forms.Button();
            this.dgvAusentismo = new System.Windows.Forms.DataGridView();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.cbxNomina = new System.Windows.Forms.ComboBox();
            this.lblNomina = new System.Windows.Forms.Label();
            this.lblDiasASimular = new System.Windows.Forms.Label();
            this.numericUpDownDiasASimular = new System.Windows.Forms.NumericUpDown();
            this.lblVentas = new System.Windows.Forms.Label();
            this.numericUpDownVentas = new System.Windows.Forms.NumericUpDown();
            this.lblProduccion = new System.Windows.Forms.Label();
            this.numericUpDownProduccion = new System.Windows.Forms.NumericUpDown();
            this.lblRemuneracion = new System.Windows.Forms.Label();
            this.numericUpDownRemuneracion = new System.Windows.Forms.NumericUpDown();
            this.btnSimular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAusentismo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiasASimular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemuneracion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrecuencias
            // 
            this.dgvFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencias.Location = new System.Drawing.Point(457, 12);
            this.dgvFrecuencias.Name = "dgvFrecuencias";
            this.dgvFrecuencias.RowHeadersWidth = 62;
            this.dgvFrecuencias.RowTemplate.Height = 28;
            this.dgvFrecuencias.Size = new System.Drawing.Size(737, 217);
            this.dgvFrecuencias.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(256, 239);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(319, 239);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 2;
            // 
            // btnFrecuenciaAusentismo
            // 
            this.btnFrecuenciaAusentismo.Location = new System.Drawing.Point(22, 274);
            this.btnFrecuenciaAusentismo.Name = "btnFrecuenciaAusentismo";
            this.btnFrecuenciaAusentismo.Size = new System.Drawing.Size(292, 35);
            this.btnFrecuenciaAusentismo.TabIndex = 3;
            this.btnFrecuenciaAusentismo.Text = "Cambiar Frecuencia Ausentismo";
            this.btnFrecuenciaAusentismo.UseVisualStyleBackColor = true;
            this.btnFrecuenciaAusentismo.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAusentismo
            // 
            this.dgvAusentismo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAusentismo.Location = new System.Drawing.Point(22, 12);
            this.dgvAusentismo.Name = "dgvAusentismo";
            this.dgvAusentismo.RowHeadersWidth = 62;
            this.dgvAusentismo.RowTemplate.Height = 28;
            this.dgvAusentismo.Size = new System.Drawing.Size(415, 217);
            this.dgvAusentismo.TabIndex = 4;
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Location = new System.Drawing.Point(65, 416);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.RowHeadersWidth = 62;
            this.dgvSimulacion.RowTemplate.Height = 28;
            this.dgvSimulacion.Size = new System.Drawing.Size(1187, 182);
            this.dgvSimulacion.TabIndex = 5;
            // 
            // cbxNomina
            // 
            this.cbxNomina.FormattingEnabled = true;
            this.cbxNomina.Location = new System.Drawing.Point(97, 344);
            this.cbxNomina.Name = "cbxNomina";
            this.cbxNomina.Size = new System.Drawing.Size(121, 28);
            this.cbxNomina.TabIndex = 6;
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.Location = new System.Drawing.Point(28, 344);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(63, 20);
            this.lblNomina.TabIndex = 7;
            this.lblNomina.Text = "Nomina";
            // 
            // lblDiasASimular
            // 
            this.lblDiasASimular.AutoSize = true;
            this.lblDiasASimular.Location = new System.Drawing.Point(224, 344);
            this.lblDiasASimular.Name = "lblDiasASimular";
            this.lblDiasASimular.Size = new System.Drawing.Size(108, 20);
            this.lblDiasASimular.TabIndex = 8;
            this.lblDiasASimular.Text = "Dias a simular";
            // 
            // numericUpDownDiasASimular
            // 
            this.numericUpDownDiasASimular.Location = new System.Drawing.Point(338, 346);
            this.numericUpDownDiasASimular.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDiasASimular.Name = "numericUpDownDiasASimular";
            this.numericUpDownDiasASimular.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDiasASimular.TabIndex = 9;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(464, 353);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(60, 20);
            this.lblVentas.TabIndex = 10;
            this.lblVentas.Text = "Ventas";
            // 
            // numericUpDownVentas
            // 
            this.numericUpDownVentas.Location = new System.Drawing.Point(530, 352);
            this.numericUpDownVentas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownVentas.Name = "numericUpDownVentas";
            this.numericUpDownVentas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownVentas.TabIndex = 11;
            this.numericUpDownVentas.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // lblProduccion
            // 
            this.lblProduccion.AutoSize = true;
            this.lblProduccion.Location = new System.Drawing.Point(656, 355);
            this.lblProduccion.Name = "lblProduccion";
            this.lblProduccion.Size = new System.Drawing.Size(88, 20);
            this.lblProduccion.TabIndex = 13;
            this.lblProduccion.Text = "Produccion";
            // 
            // numericUpDownProduccion
            // 
            this.numericUpDownProduccion.Location = new System.Drawing.Point(750, 354);
            this.numericUpDownProduccion.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownProduccion.Name = "numericUpDownProduccion";
            this.numericUpDownProduccion.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownProduccion.TabIndex = 14;
            this.numericUpDownProduccion.Value = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            // 
            // lblRemuneracion
            // 
            this.lblRemuneracion.AutoSize = true;
            this.lblRemuneracion.Location = new System.Drawing.Point(890, 358);
            this.lblRemuneracion.Name = "lblRemuneracion";
            this.lblRemuneracion.Size = new System.Drawing.Size(113, 20);
            this.lblRemuneracion.TabIndex = 15;
            this.lblRemuneracion.Text = "Remuneracion";
            // 
            // numericUpDownRemuneracion
            // 
            this.numericUpDownRemuneracion.Location = new System.Drawing.Point(1009, 358);
            this.numericUpDownRemuneracion.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRemuneracion.Name = "numericUpDownRemuneracion";
            this.numericUpDownRemuneracion.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownRemuneracion.TabIndex = 16;
            this.numericUpDownRemuneracion.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(1153, 349);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 38);
            this.btnSimular.TabIndex = 17;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 598);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.numericUpDownRemuneracion);
            this.Controls.Add(this.lblRemuneracion);
            this.Controls.Add(this.numericUpDownProduccion);
            this.Controls.Add(this.lblProduccion);
            this.Controls.Add(this.numericUpDownVentas);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.numericUpDownDiasASimular);
            this.Controls.Add(this.lblDiasASimular);
            this.Controls.Add(this.lblNomina);
            this.Controls.Add(this.cbxNomina);
            this.Controls.Add(this.dgvSimulacion);
            this.Controls.Add(this.dgvAusentismo);
            this.Controls.Add(this.btnFrecuenciaAusentismo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvFrecuencias);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAusentismo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiasASimular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemuneracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrecuencias;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFrecuenciaAusentismo;
        private System.Windows.Forms.DataGridView dgvAusentismo;
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.ComboBox cbxNomina;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label lblDiasASimular;
        private System.Windows.Forms.NumericUpDown numericUpDownDiasASimular;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.NumericUpDown numericUpDownVentas;
        private System.Windows.Forms.Label lblProduccion;
        private System.Windows.Forms.NumericUpDown numericUpDownProduccion;
        private System.Windows.Forms.Label lblRemuneracion;
        private System.Windows.Forms.NumericUpDown numericUpDownRemuneracion;
        private System.Windows.Forms.Button btnSimular;
    }
}

