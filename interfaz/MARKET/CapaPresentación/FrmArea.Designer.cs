namespace CapaPresentación
{
    partial class FrmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArea));
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Data_listado = new System.Windows.Forms.DataGridView();
            this.Titulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEditarArea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminarArea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGuardarArea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(68, 457);
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(207, 20);
            this.Txt_Nombre.TabIndex = 13;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Location = new System.Drawing.Point(68, 377);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(207, 20);
            this.Txt_Tipo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(65, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 10;
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
            this.Data_listado.TabIndex = 9;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Coral;
            this.Titulo.Location = new System.Drawing.Point(200, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(519, 59);
            this.Titulo.TabIndex = 18;
            this.Titulo.Text = "VALENTINA MARKET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentación.Properties.Resources._069_multiply;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnEditarArea
            // 
            this.BtnEditarArea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditarArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditarArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditarArea.BorderRadius = 0;
            this.BtnEditarArea.ButtonText = "EDITAR AREA";
            this.BtnEditarArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarArea.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditarArea.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditarArea.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditarArea.Iconimage")));
            this.BtnEditarArea.Iconimage_right = null;
            this.BtnEditarArea.Iconimage_right_Selected = null;
            this.BtnEditarArea.Iconimage_Selected = null;
            this.BtnEditarArea.IconMarginLeft = 0;
            this.BtnEditarArea.IconMarginRight = 0;
            this.BtnEditarArea.IconRightVisible = true;
            this.BtnEditarArea.IconRightZoom = 0D;
            this.BtnEditarArea.IconVisible = true;
            this.BtnEditarArea.IconZoom = 90D;
            this.BtnEditarArea.IsTab = false;
            this.BtnEditarArea.Location = new System.Drawing.Point(57, 102);
            this.BtnEditarArea.Name = "BtnEditarArea";
            this.BtnEditarArea.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditarArea.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEditarArea.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditarArea.selected = false;
            this.BtnEditarArea.Size = new System.Drawing.Size(241, 48);
            this.BtnEditarArea.TabIndex = 21;
            this.BtnEditarArea.Text = "EDITAR AREA";
            this.BtnEditarArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarArea.Textcolor = System.Drawing.Color.White;
            this.BtnEditarArea.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarArea.Click += new System.EventHandler(this.BtnEditarArea_Click);
            // 
            // BtnEliminarArea
            // 
            this.BtnEliminarArea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminarArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminarArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarArea.BorderRadius = 0;
            this.BtnEliminarArea.ButtonText = "ELIMINAR AREA";
            this.BtnEliminarArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarArea.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminarArea.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarArea.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarArea.Iconimage")));
            this.BtnEliminarArea.Iconimage_right = null;
            this.BtnEliminarArea.Iconimage_right_Selected = null;
            this.BtnEliminarArea.Iconimage_Selected = null;
            this.BtnEliminarArea.IconMarginLeft = 0;
            this.BtnEliminarArea.IconMarginRight = 0;
            this.BtnEliminarArea.IconRightVisible = true;
            this.BtnEliminarArea.IconRightZoom = 0D;
            this.BtnEliminarArea.IconVisible = true;
            this.BtnEliminarArea.IconZoom = 90D;
            this.BtnEliminarArea.IsTab = false;
            this.BtnEliminarArea.Location = new System.Drawing.Point(57, 188);
            this.BtnEliminarArea.Name = "BtnEliminarArea";
            this.BtnEliminarArea.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEliminarArea.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEliminarArea.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminarArea.selected = false;
            this.BtnEliminarArea.Size = new System.Drawing.Size(241, 48);
            this.BtnEliminarArea.TabIndex = 22;
            this.BtnEliminarArea.Text = "ELIMINAR AREA";
            this.BtnEliminarArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarArea.Textcolor = System.Drawing.Color.White;
            this.BtnEliminarArea.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarArea.Click += new System.EventHandler(this.BtnEliminarArea_Click);
            // 
            // BtnGuardarArea
            // 
            this.BtnGuardarArea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardarArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardarArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardarArea.BorderRadius = 0;
            this.BtnGuardarArea.ButtonText = "GUARDAR AREA";
            this.BtnGuardarArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarArea.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardarArea.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardarArea.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardarArea.Iconimage")));
            this.BtnGuardarArea.Iconimage_right = null;
            this.BtnGuardarArea.Iconimage_right_Selected = null;
            this.BtnGuardarArea.Iconimage_Selected = null;
            this.BtnGuardarArea.IconMarginLeft = 0;
            this.BtnGuardarArea.IconMarginRight = 0;
            this.BtnGuardarArea.IconRightVisible = true;
            this.BtnGuardarArea.IconRightZoom = 0D;
            this.BtnGuardarArea.IconVisible = true;
            this.BtnGuardarArea.IconZoom = 90D;
            this.BtnGuardarArea.IsTab = false;
            this.BtnGuardarArea.Location = new System.Drawing.Point(57, 275);
            this.BtnGuardarArea.Name = "BtnGuardarArea";
            this.BtnGuardarArea.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardarArea.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnGuardarArea.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardarArea.selected = false;
            this.BtnGuardarArea.Size = new System.Drawing.Size(241, 48);
            this.BtnGuardarArea.TabIndex = 23;
            this.BtnGuardarArea.Text = "GUARDAR AREA";
            this.BtnGuardarArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarArea.Textcolor = System.Drawing.Color.White;
            this.BtnGuardarArea.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarArea.Click += new System.EventHandler(this.BtnGuardarArea_Click);
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
            this.BtnAtras.TabIndex = 24;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // FrmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(964, 526);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnGuardarArea);
            this.Controls.Add(this.BtnEliminarArea);
            this.Controls.Add(this.BtnEditarArea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data_listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArea";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmArea_Load);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditarArea;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminarArea;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardarArea;
        private System.Windows.Forms.Button BtnAtras;
    }
}

