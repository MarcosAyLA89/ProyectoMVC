namespace CapaPresentacion
{
    partial class FrmSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuccess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mensaje = new System.Windows.Forms.Label();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.BtnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LabelMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 188);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mensaje
            // 
            this.mensaje.BackColor = System.Drawing.Color.Transparent;
            this.mensaje.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.ForeColor = System.Drawing.Color.SeaGreen;
            this.mensaje.Location = new System.Drawing.Point(35, 191);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(196, 57);
            this.mensaje.TabIndex = 0;
            this.mensaje.Tag = "";
            this.mensaje.Text = "Accion completada correctamente";
            this.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.White;
            this.LabelMessage.Location = new System.Drawing.Point(12, 70);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(236, 118);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "Mensaje";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMessage.Click += new System.EventHandler(this.LabelMessage_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.BorderRadius = 0;
            this.BtnAceptar.ButtonText = "ACEPTAR";
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAceptar.Iconimage = null;
            this.BtnAceptar.Iconimage_right = null;
            this.BtnAceptar.Iconimage_right_Selected = null;
            this.BtnAceptar.Iconimage_Selected = null;
            this.BtnAceptar.IconMarginLeft = 0;
            this.BtnAceptar.IconMarginRight = 0;
            this.BtnAceptar.IconRightVisible = true;
            this.BtnAceptar.IconRightZoom = 0D;
            this.BtnAceptar.IconVisible = true;
            this.BtnAceptar.IconZoom = 90D;
            this.BtnAceptar.IsTab = false;
            this.BtnAceptar.Location = new System.Drawing.Point(35, 251);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAceptar.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.BtnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAceptar.selected = false;
            this.BtnAceptar.Size = new System.Drawing.Size(196, 39);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAceptar.Textcolor = System.Drawing.Color.White;
            this.BtnAceptar.TextFont = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FadeTransition
            // 
            this.FadeTransition.Delay = 0;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 30;
            this.Elipse.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 300);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuccess";
            this.Load += new System.EventHandler(this.FrmSuccess_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label mensaje;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAceptar;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FadeTransition;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}