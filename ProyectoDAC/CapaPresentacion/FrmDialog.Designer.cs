namespace CapaPresentacion
{
    partial class FrmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDialog));
            this.LabelMessage = new System.Windows.Forms.Label();
            this.BtnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMessage
            // 
            this.LabelMessage.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.White;
            this.LabelMessage.Location = new System.Drawing.Point(7, 132);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(241, 42);
            this.LabelMessage.TabIndex = 4;
            this.LabelMessage.Text = "Mensaje";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnAceptar.Location = new System.Drawing.Point(12, 259);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAceptar.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.BtnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAceptar.selected = false;
            this.BtnAceptar.Size = new System.Drawing.Size(104, 39);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAceptar.Textcolor = System.Drawing.Color.White;
            this.BtnAceptar.TextFont = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LabelMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 188);
            this.panel1.TabIndex = 2;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Activecolor = System.Drawing.Color.IndianRed;
            this.ButtonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCancel.BorderRadius = 0;
            this.ButtonCancel.ButtonText = "CANCELAR";
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonCancel.Iconimage = null;
            this.ButtonCancel.Iconimage_right = null;
            this.ButtonCancel.Iconimage_right_Selected = null;
            this.ButtonCancel.Iconimage_Selected = null;
            this.ButtonCancel.IconMarginLeft = 0;
            this.ButtonCancel.IconMarginRight = 0;
            this.ButtonCancel.IconRightVisible = true;
            this.ButtonCancel.IconRightZoom = 0D;
            this.ButtonCancel.IconVisible = true;
            this.ButtonCancel.IconZoom = 90D;
            this.ButtonCancel.IsTab = false;
            this.ButtonCancel.Location = new System.Drawing.Point(128, 259);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Normalcolor = System.Drawing.Color.IndianRed;
            this.ButtonCancel.OnHovercolor = System.Drawing.Color.DarkRed;
            this.ButtonCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonCancel.selected = false;
            this.ButtonCancel.Size = new System.Drawing.Size(120, 39);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "CANCELAR";
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCancel.Textcolor = System.Drawing.Color.White;
            this.ButtonCancel.TextFont = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(7, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Confirmar acción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDialog";
            this.Load += new System.EventHandler(this.FrmDialog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelMessage;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAceptar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonCancel;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FadeTransition;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}