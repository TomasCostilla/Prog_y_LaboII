namespace WindowsForm
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
            this.Mostrar = new System.Windows.Forms.Button();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.Label();
            this.TextEdad = new System.Windows.Forms.TextBox();
            this.FechNac = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboGen = new System.Windows.Forms.ComboBox();
            this.genero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(125, 366);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(280, 102);
            this.Mostrar.TabIndex = 0;
            this.Mostrar.Text = "Mostrar Datos";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(194, 44);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(190, 20);
            this.TextNombre.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(122, 47);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(62, 17);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre:";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(122, 87);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(62, 17);
            this.apellido.TabIndex = 3;
            this.apellido.Text = "Apellido:";
            // 
            // TextApellido
            // 
            this.TextApellido.Location = new System.Drawing.Point(194, 84);
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(188, 20);
            this.TextApellido.TabIndex = 4;
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(139, 293);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(45, 17);
            this.edad.TabIndex = 5;
            this.edad.Text = "Edad:";
            // 
            // TextEdad
            // 
            this.TextEdad.Location = new System.Drawing.Point(194, 290);
            this.TextEdad.Name = "TextEdad";
            this.TextEdad.Size = new System.Drawing.Size(30, 20);
            this.TextEdad.TabIndex = 6;
            // 
            // FechNac
            // 
            this.FechNac.Location = new System.Drawing.Point(194, 116);
            this.FechNac.Name = "FechNac";
            this.FechNac.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // ComboGen
            // 
            this.ComboGen.FormattingEnabled = true;
            this.ComboGen.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.ComboGen.Location = new System.Drawing.Point(194, 329);
            this.ComboGen.Name = "ComboGen";
            this.ComboGen.Size = new System.Drawing.Size(75, 21);
            this.ComboGen.TabIndex = 9;
            // 
            // genero
            // 
            this.genero.AutoSize = true;
            this.genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero.Location = new System.Drawing.Point(124, 329);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(60, 17);
            this.genero.TabIndex = 10;
            this.genero.Text = "Genero:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 480);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.ComboGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechNac);
            this.Controls.Add(this.TextEdad);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.TextApellido);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.Mostrar);
            this.Name = "Form1";
            this.Text = "Windows Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.TextBox TextApellido;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.TextBox TextEdad;
        private System.Windows.Forms.MonthCalendar FechNac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboGen;
        private System.Windows.Forms.Label genero;
    }
}

