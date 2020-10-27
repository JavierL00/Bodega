namespace CapaPresentación
{
    partial class FrmFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFamilia));
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Data_listado = new System.Windows.Forms.DataGridView();
            this.Titulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(79, 449);
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(207, 20);
            this.Txt_Nombre.TabIndex = 24;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Location = new System.Drawing.Point(79, 379);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(207, 20);
            this.Txt_Tipo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(76, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(76, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "TIPO";
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
            this.Data_listado.Location = new System.Drawing.Point(388, 89);
            this.Data_listado.Name = "Data_listado";
            this.Data_listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Data_listado.Size = new System.Drawing.Size(564, 425);
            this.Data_listado.TabIndex = 20;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Coral;
            this.Titulo.Location = new System.Drawing.Point(200, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(519, 59);
            this.Titulo.TabIndex = 29;
            this.Titulo.Text = "VALENTINA MARKET";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.ButtonText = "ELIMINAR FAMILIA";
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
            this.BtnEliminar.Location = new System.Drawing.Point(57, 102);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(254, 48);
            this.BtnEliminar.TabIndex = 30;
            this.BtnEliminar.Text = "ELIMINAR FAMILIA";
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
            this.BtnEditar.ButtonText = "EDITAR FAMILIA";
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
            this.BtnEditar.Location = new System.Drawing.Point(57, 188);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(254, 48);
            this.BtnEditar.TabIndex = 31;
            this.BtnEditar.Text = "EDITAR FAMILIA";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Textcolor = System.Drawing.Color.White;
            this.BtnEditar.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "GUARDAR FAMILIA";
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
            this.BtnGuardar.Location = new System.Drawing.Point(57, 275);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(254, 48);
            this.BtnGuardar.TabIndex = 32;
            this.BtnGuardar.Text = "GUARDAR FAMILIA";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(38, 9);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 34;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentación.Properties.Resources._069_multiply;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(964, 526);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data_listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFamilia";
            this.Text = "FrmFamilia";
            this.Load += new System.EventHandler(this.FrmFamilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Data_listado;
        private Bunifu.Framework.UI.BunifuCustomLabel Titulo;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}