namespace ArticulosTecnologia
{
    partial class AltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaArticulo));
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxImagenUrl = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label1Codigo = new System.Windows.Forms.Label();
            this.label2Nombre = new System.Windows.Forms.Label();
            this.label4ImagenUrl = new System.Windows.Forms.Label();
            this.label5Descripcion = new System.Windows.Forms.Label();
            this.label6Precio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(118, 71);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(151, 20);
            this.textBoxCodigo.TabIndex = 0;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(118, 97);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(151, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxImagenUrl
            // 
            this.textBoxImagenUrl.Location = new System.Drawing.Point(118, 125);
            this.textBoxImagenUrl.Name = "textBoxImagenUrl";
            this.textBoxImagenUrl.Size = new System.Drawing.Size(151, 20);
            this.textBoxImagenUrl.TabIndex = 2;
            this.textBoxImagenUrl.Leave += new System.EventHandler(this.textBoxImagenUrl_Leave);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(118, 177);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(151, 20);
            this.textBoxPrecio.TabIndex = 4;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(118, 151);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(151, 20);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // label1Codigo
            // 
            this.label1Codigo.AutoSize = true;
            this.label1Codigo.Location = new System.Drawing.Point(68, 74);
            this.label1Codigo.Name = "label1Codigo";
            this.label1Codigo.Size = new System.Drawing.Size(43, 13);
            this.label1Codigo.TabIndex = 7;
            this.label1Codigo.Text = "Codigo:";
            // 
            // label2Nombre
            // 
            this.label2Nombre.AutoSize = true;
            this.label2Nombre.Location = new System.Drawing.Point(65, 100);
            this.label2Nombre.Name = "label2Nombre";
            this.label2Nombre.Size = new System.Drawing.Size(47, 13);
            this.label2Nombre.TabIndex = 8;
            this.label2Nombre.Text = "Nombre:";
            // 
            // label4ImagenUrl
            // 
            this.label4ImagenUrl.AutoSize = true;
            this.label4ImagenUrl.Location = new System.Drawing.Point(51, 128);
            this.label4ImagenUrl.Name = "label4ImagenUrl";
            this.label4ImagenUrl.Size = new System.Drawing.Size(61, 13);
            this.label4ImagenUrl.TabIndex = 10;
            this.label4ImagenUrl.Text = "Imagen Url:";
            // 
            // label5Descripcion
            // 
            this.label5Descripcion.AutoSize = true;
            this.label5Descripcion.Location = new System.Drawing.Point(49, 154);
            this.label5Descripcion.Name = "label5Descripcion";
            this.label5Descripcion.Size = new System.Drawing.Size(66, 13);
            this.label5Descripcion.TabIndex = 11;
            this.label5Descripcion.Text = "Descripcion:";
            // 
            // label6Precio
            // 
            this.label6Precio.AutoSize = true;
            this.label6Precio.Location = new System.Drawing.Point(76, 180);
            this.label6Precio.Name = "label6Precio";
            this.label6Precio.Size = new System.Drawing.Size(40, 13);
            this.label6Precio.TabIndex = 12;
            this.label6Precio.Text = "Precio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(287, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.Location = new System.Drawing.Point(89, 284);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button1Aceptar.TabIndex = 5;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = true;
            this.button1Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "Articulos";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(72, 211);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 18;
            this.labelMarca.Text = "Marca:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(56, 233);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(55, 13);
            this.labelCategoria.TabIndex = 19;
            this.labelCategoria.Text = "Categoria:";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(118, 203);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(151, 21);
            this.comboMarca.TabIndex = 20;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(118, 230);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(151, 21);
            this.comboBoxCategoria.TabIndex = 21;
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 319);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6Precio);
            this.Controls.Add(this.label5Descripcion);
            this.Controls.Add(this.label4ImagenUrl);
            this.Controls.Add(this.label2Nombre);
            this.Controls.Add(this.label1Codigo);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxImagenUrl);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxImagenUrl;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label1Codigo;
        private System.Windows.Forms.Label label2Nombre;
        private System.Windows.Forms.Label label4ImagenUrl;
        private System.Windows.Forms.Label label5Descripcion;
        private System.Windows.Forms.Label label6Precio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
    }
}