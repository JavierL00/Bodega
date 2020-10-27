namespace CapaPresentación
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.Titulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNuevoProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Coral;
            this.Titulo.Location = new System.Drawing.Point(200, 8);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(519, 59);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "VALENTINA MARKET";
            // 
            // DGV1
            // 
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(298, 128);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(638, 347);
            this.DGV1.TabIndex = 9;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "MÁS OPCIONES";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(30, 358);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton4.TabIndex = 7;
            this.bunifuFlatButton4.Text = "MÁS OPCIONES";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.ButtonText = "ELIMINAR PRODUCTO";
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
            this.BtnEliminar.Location = new System.Drawing.Point(30, 285);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(241, 48);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "ELIMINAR PRODUCTO";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Textcolor = System.Drawing.Color.Black;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.BorderRadius = 0;
            this.BtnEditar.ButtonText = "EDITAR PRODUCTO";
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
            this.BtnEditar.Location = new System.Drawing.Point(30, 207);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(241, 48);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "EDITAR PRODUCTO";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Textcolor = System.Drawing.Color.Black;
            this.BtnEditar.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNuevoProducto
            // 
            this.BtnNuevoProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevoProducto.BorderRadius = 0;
            this.BtnNuevoProducto.ButtonText = "NUEVO PRODUCTO";
            this.BtnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoProducto.DisabledColor = System.Drawing.Color.Gray;
            this.BtnNuevoProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNuevoProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevoProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnNuevoProducto.Iconimage")));
            this.BtnNuevoProducto.Iconimage_right = null;
            this.BtnNuevoProducto.Iconimage_right_Selected = null;
            this.BtnNuevoProducto.Iconimage_Selected = null;
            this.BtnNuevoProducto.IconMarginLeft = 0;
            this.BtnNuevoProducto.IconMarginRight = 0;
            this.BtnNuevoProducto.IconRightVisible = true;
            this.BtnNuevoProducto.IconRightZoom = 0D;
            this.BtnNuevoProducto.IconVisible = true;
            this.BtnNuevoProducto.IconZoom = 90D;
            this.BtnNuevoProducto.IsTab = false;
            this.BtnNuevoProducto.Location = new System.Drawing.Point(30, 128);
            this.BtnNuevoProducto.Name = "BtnNuevoProducto";
            this.BtnNuevoProducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnNuevoProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnNuevoProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnNuevoProducto.selected = false;
            this.BtnNuevoProducto.Size = new System.Drawing.Size(241, 48);
            this.BtnNuevoProducto.TabIndex = 4;
            this.BtnNuevoProducto.Text = "NUEVO PRODUCTO";
            this.BtnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoProducto.Textcolor = System.Drawing.Color.Black;
            this.BtnNuevoProducto.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoProducto.Click += new System.EventHandler(this.BtnNuevoProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentación.Properties.Resources._069_multiply;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(532, 101);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(389, 20);
            this.TxtBuscar.TabIndex = 10;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(313, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "PRODUCTO A BUSCAR: ";
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(38, 8);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 26;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(948, 487);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevoProducto);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducto";
            this.Text = "FrmEleccionProducto";
            this.Load += new System.EventHandler(this.FrmEleccionProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel Titulo;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevoProducto;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAtras;
    }
}