namespace CapaPresentación
{
    partial class FrmTamaño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTamaño));
            this.BtnAtras = new System.Windows.Forms.Button();
            this.Titulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtMedida = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Data_listado = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(40, 10);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 35;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Coral;
            this.Titulo.Location = new System.Drawing.Point(202, 11);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(519, 59);
            this.Titulo.TabIndex = 30;
            this.Titulo.Text = "VALENTINA MARKET";
            // 
            // TxtMedida
            // 
            this.TxtMedida.Location = new System.Drawing.Point(70, 459);
            this.TxtMedida.Multiline = true;
            this.TxtMedida.Name = "TxtMedida";
            this.TxtMedida.Size = new System.Drawing.Size(207, 20);
            this.TxtMedida.TabIndex = 29;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(70, 379);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(207, 20);
            this.TxtCodigo.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "MEDIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(67, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "CODIGO";
            // 
            // Data_listado
            // 
            this.Data_listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Data_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_listado.GridColor = System.Drawing.Color.SteelBlue;
            this.Data_listado.Location = new System.Drawing.Point(390, 91);
            this.Data_listado.Name = "Data_listado";
            this.Data_listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Data_listado.Size = new System.Drawing.Size(564, 425);
            this.Data_listado.TabIndex = 25;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "GUARDAR TAMAÑO";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Iconimage")));
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 90D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(59, 277);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(241, 48);
            this.BtnGuardar.TabIndex = 34;
            this.BtnGuardar.Text = "GUARDAR TAMAÑO";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.ButtonText = "ELIMINAR TAMAÑO";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Iconimage")));
            this.BtnEliminar.Iconimage_right = null;
            this.BtnEliminar.Iconimage_right_Selected = null;
            this.BtnEliminar.Iconimage_Selected = null;
            this.BtnEliminar.IconMarginLeft = 0;
            this.BtnEliminar.IconMarginRight = 0;
            this.BtnEliminar.IconRightVisible = true;
            this.BtnEliminar.IconRightZoom = 0D;
            this.BtnEliminar.IconVisible = true;
            this.BtnEliminar.IconZoom = 90D;
            this.BtnEliminar.IsTab = false;
            this.BtnEliminar.Location = new System.Drawing.Point(59, 190);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(241, 48);
            this.BtnEliminar.TabIndex = 33;
            this.BtnEliminar.Text = "ELIMINAR TAMAÑO";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Textcolor = System.Drawing.Color.White;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.BorderRadius = 0;
            this.BtnEditar.ButtonText = "EDITAR TAMAÑO";
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Iconimage")));
            this.BtnEditar.Iconimage_right = null;
            this.BtnEditar.Iconimage_right_Selected = null;
            this.BtnEditar.Iconimage_Selected = null;
            this.BtnEditar.IconMarginLeft = 0;
            this.BtnEditar.IconMarginRight = 0;
            this.BtnEditar.IconRightVisible = true;
            this.BtnEditar.IconRightZoom = 0D;
            this.BtnEditar.IconVisible = true;
            this.BtnEditar.IconZoom = 90D;
            this.BtnEditar.IsTab = false;
            this.BtnEditar.Location = new System.Drawing.Point(59, 104);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(241, 48);
            this.BtnEditar.TabIndex = 32;
            this.BtnEditar.Text = "EDITAR TAMAÑO";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Textcolor = System.Drawing.Color.White;
            this.BtnEditar.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentación.Properties.Resources._069_multiply;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmTamaño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(964, 526);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxtMedida);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data_listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTamaño";
            this.Text = "FrmTamaño";
            this.Load += new System.EventHandler(this.FrmTamaño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel Titulo;
        private System.Windows.Forms.TextBox TxtMedida;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Data_listado;
    }
}