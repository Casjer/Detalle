namespace DetalleRegistro.UI.Registro
{
    partial class rPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefonosdataGridView = new System.Windows.Forms.DataGridView();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ELiminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.TelfonotextBox = new System.Windows.Forms.TextBox();
            this.TipodetelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "personaId";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(30, 65);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "F.Nacimiento";
            // 
            // FNacimientodateTimePicker
            // 
            this.FNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FNacimientodateTimePicker.Location = new System.Drawing.Point(383, 120);
            this.FNacimientodateTimePicker.Name = "FNacimientodateTimePicker";
            this.FNacimientodateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FNacimientodateTimePicker.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Direccion";
            // 
            // TelefonosdataGridView
            // 
            this.TelefonosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelefonosdataGridView.Location = new System.Drawing.Point(93, 189);
            this.TelefonosdataGridView.Name = "TelefonosdataGridView";
            this.TelefonosdataGridView.Size = new System.Drawing.Size(341, 137);
            this.TelefonosdataGridView.TabIndex = 13;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(117, 25);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.IdnumericUpDown.TabIndex = 15;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::DetalleRegistro.Properties.Resources.icons8_New_Window_32;
            this.Agregarbutton.Location = new System.Drawing.Point(235, 156);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(36, 27);
            this.Agregarbutton.TabIndex = 4;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ELiminarbutton
            // 
            this.ELiminarbutton.Image = global::DetalleRegistro.Properties.Resources.icons8_Delete_Document_32;
            this.ELiminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ELiminarbutton.Location = new System.Drawing.Point(383, 383);
            this.ELiminarbutton.Name = "ELiminarbutton";
            this.ELiminarbutton.Size = new System.Drawing.Size(75, 55);
            this.ELiminarbutton.TabIndex = 3;
            this.ELiminarbutton.Text = "Eliminar";
            this.ELiminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ELiminarbutton.UseVisualStyleBackColor = true;
            this.ELiminarbutton.Click += new System.EventHandler(this.ELiminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::DetalleRegistro.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(258, 383);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::DetalleRegistro.Properties.Resources.icons8_Save_as_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(117, 383);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 1;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::DetalleRegistro.Properties.Resources.icons8_Search_321;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(181, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(76, 33);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(117, 58);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(387, 20);
            this.NombretextBox.TabIndex = 17;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(117, 85);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(387, 20);
            this.DirecciontextBox.TabIndex = 18;
            // 
            // TelfonotextBox
            // 
            this.TelfonotextBox.Location = new System.Drawing.Point(383, 161);
            this.TelfonotextBox.Name = "TelfonotextBox";
            this.TelfonotextBox.Size = new System.Drawing.Size(124, 20);
            this.TelfonotextBox.TabIndex = 21;
            // 
            // TipodetelefonomaskedTextBox
            // 
            this.TipodetelefonomaskedTextBox.Location = new System.Drawing.Point(117, 160);
            this.TipodetelefonomaskedTextBox.Mask = "(999) 000-0000";
            this.TipodetelefonomaskedTextBox.Name = "TipodetelefonomaskedTextBox";
            this.TipodetelefonomaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TipodetelefonomaskedTextBox.TabIndex = 22;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(117, 112);
            this.CedulamaskedTextBox.Mask = "000-00-0000";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CedulamaskedTextBox.TabIndex = 23;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(93, 332);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 24;
            this.RemoveButton.Text = "Remove ";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.TipodetelefonomaskedTextBox);
            this.Controls.Add(this.TelfonotextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.TelefonosdataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FNacimientodateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.ELiminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "rPersona";
            this.Text = "rPersona";
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button ELiminarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FNacimientodateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView TelefonosdataGridView;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox TelfonotextBox;
        private System.Windows.Forms.MaskedTextBox TipodetelefonomaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}