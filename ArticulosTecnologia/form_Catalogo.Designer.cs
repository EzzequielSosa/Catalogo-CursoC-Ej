namespace ArticulosTecnologia
{
    partial class form_Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Catalogo));
            this.dataGridViewListaArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBoxCatalogo = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonVerLista = new System.Windows.Forms.Button();
            this.buttonEliminarFisico = new System.Windows.Forms.Button();
            this.labelfiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.button1Filtro = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaArticulos
            // 
            this.dataGridViewListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaArticulos.Location = new System.Drawing.Point(3, 61);
            this.dataGridViewListaArticulos.Name = "dataGridViewListaArticulos";
            this.dataGridViewListaArticulos.Size = new System.Drawing.Size(648, 280);
            this.dataGridViewListaArticulos.TabIndex = 3;
            this.dataGridViewListaArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaArticulos_CellContentClick);
            this.dataGridViewListaArticulos.SelectionChanged += new System.EventHandler(this.dataGridViewListaArticulos_SelectionChanged);
            // 
            // pictureBoxCatalogo
            // 
            this.pictureBoxCatalogo.Location = new System.Drawing.Point(657, 61);
            this.pictureBoxCatalogo.Name = "pictureBoxCatalogo";
            this.pictureBoxCatalogo.Size = new System.Drawing.Size(354, 280);
            this.pictureBoxCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCatalogo.TabIndex = 1;
            this.pictureBoxCatalogo.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(109, 359);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(98, 48);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(211, 359);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(98, 48);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonVerLista
            // 
            this.buttonVerLista.Location = new System.Drawing.Point(7, 359);
            this.buttonVerLista.Name = "buttonVerLista";
            this.buttonVerLista.Size = new System.Drawing.Size(98, 48);
            this.buttonVerLista.TabIndex = 0;
            this.buttonVerLista.Text = "Ver Lista";
            this.buttonVerLista.UseVisualStyleBackColor = true;
            this.buttonVerLista.Click += new System.EventHandler(this.buttonVerLista_Click);
            // 
            // buttonEliminarFisico
            // 
            this.buttonEliminarFisico.Location = new System.Drawing.Point(315, 359);
            this.buttonEliminarFisico.Name = "buttonEliminarFisico";
            this.buttonEliminarFisico.Size = new System.Drawing.Size(98, 48);
            this.buttonEliminarFisico.TabIndex = 4;
            this.buttonEliminarFisico.Text = "Eliminar";
            this.buttonEliminarFisico.UseVisualStyleBackColor = true;
            this.buttonEliminarFisico.Click += new System.EventHandler(this.buttonEliminarFisico_Click);
            // 
            // labelfiltro
            // 
            this.labelfiltro.AutoSize = true;
            this.labelfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfiltro.Location = new System.Drawing.Point(12, 23);
            this.labelfiltro.Name = "labelfiltro";
            this.labelfiltro.Size = new System.Drawing.Size(37, 15);
            this.labelfiltro.TabIndex = 5;
            this.labelfiltro.Text = "Filtro:";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(56, 23);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(181, 20);
            this.textBoxFiltro.TabIndex = 6;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // button1Filtro
            // 
            this.button1Filtro.Location = new System.Drawing.Point(243, 15);
            this.button1Filtro.Name = "button1Filtro";
            this.button1Filtro.Size = new System.Drawing.Size(93, 34);
            this.button1Filtro.TabIndex = 7;
            this.button1Filtro.Text = "Buscar";
            this.button1Filtro.UseVisualStyleBackColor = true;
            this.button1Filtro.Click += new System.EventHandler(this.button1Filtro_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(419, 358);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(98, 48);
            this.buttonCerrar.TabIndex = 8;
            this.buttonCerrar.Text = "Cancelar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // form_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 422);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.button1Filtro);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelfiltro);
            this.Controls.Add(this.buttonEliminarFisico);
            this.Controls.Add(this.buttonVerLista);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxCatalogo);
            this.Controls.Add(this.dataGridViewListaArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Catalogo";
            this.Load += new System.EventHandler(this.form_Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaArticulos;
        private System.Windows.Forms.PictureBox pictureBoxCatalogo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonVerLista;
        private System.Windows.Forms.Button buttonEliminarFisico;
        private System.Windows.Forms.Label labelfiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button button1Filtro;
        private System.Windows.Forms.Button buttonCerrar;
    }
}