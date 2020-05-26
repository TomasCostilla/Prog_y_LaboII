namespace WindowsFormsApp1
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.barra1 = new ControlCantina.Barra();
            this.RCerveza = new System.Windows.Forms.RadioButton();
            this.RAgua = new System.Windows.Forms.RadioButton();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelCapacidad = new System.Windows.Forms.Label();
            this.numericUpDownCap = new System.Windows.Forms.NumericUpDown();
            this.labelContenido = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelBotTipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(590, 374);
            this.barra1.TabIndex = 0;
            // 
            // RCerveza
            // 
            this.RCerveza.AutoSize = true;
            this.RCerveza.Location = new System.Drawing.Point(12, 437);
            this.RCerveza.Name = "RCerveza";
            this.RCerveza.Size = new System.Drawing.Size(64, 17);
            this.RCerveza.TabIndex = 1;
            this.RCerveza.TabStop = true;
            this.RCerveza.Text = "Cerveza";
            this.RCerveza.UseVisualStyleBackColor = true;
            // 
            // RAgua
            // 
            this.RAgua.AutoSize = true;
            this.RAgua.Location = new System.Drawing.Point(12, 476);
            this.RAgua.Name = "RAgua";
            this.RAgua.Size = new System.Drawing.Size(50, 17);
            this.RAgua.TabIndex = 2;
            this.RAgua.TabStop = true;
            this.RAgua.Text = "Agua";
            this.RAgua.UseVisualStyleBackColor = true;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(130, 419);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(133, 436);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(202, 20);
            this.textBoxMarca.TabIndex = 4;
            // 
            // labelCapacidad
            // 
            this.labelCapacidad.AutoSize = true;
            this.labelCapacidad.Location = new System.Drawing.Point(130, 481);
            this.labelCapacidad.Name = "labelCapacidad";
            this.labelCapacidad.Size = new System.Drawing.Size(58, 13);
            this.labelCapacidad.TabIndex = 5;
            this.labelCapacidad.Text = "Capacidad";
            // 
            // numericUpDownCap
            // 
            this.numericUpDownCap.Location = new System.Drawing.Point(133, 507);
            this.numericUpDownCap.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCap.Name = "numericUpDownCap";
            this.numericUpDownCap.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownCap.TabIndex = 6;
            this.numericUpDownCap.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Location = new System.Drawing.Point(267, 480);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(55, 13);
            this.labelContenido.TabIndex = 7;
            this.labelContenido.Text = "Contenido";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(270, 507);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelBotTipo
            // 
            this.labelBotTipo.AutoSize = true;
            this.labelBotTipo.Location = new System.Drawing.Point(372, 419);
            this.labelBotTipo.Name = "labelBotTipo";
            this.labelBotTipo.Size = new System.Drawing.Size(63, 13);
            this.labelBotTipo.TabIndex = 9;
            this.labelBotTipo.Text = "Botella Tipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(375, 436);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(141, 21);
            this.comboBoxTipo.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(375, 470);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 57);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 553);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelBotTipo);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.labelContenido);
            this.Controls.Add(this.numericUpDownCap);
            this.Controls.Add(this.labelCapacidad);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.RAgua);
            this.Controls.Add(this.RCerveza);
            this.Controls.Add(this.barra1);
            this.Name = "FrmCantina";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.RadioButton RCerveza;
        private System.Windows.Forms.RadioButton RAgua;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelCapacidad;
        private System.Windows.Forms.NumericUpDown numericUpDownCap;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelBotTipo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button btnAgregar;
    }
}

