namespace CapaPresentacion
{
    partial class FrmWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWarning));
            this.BtnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.FadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(45)))));
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
            this.BtnAceptar.Location = new System.Drawing.Point(35, 256);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(45)))));
            this.BtnAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.BtnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAceptar.selected = false;
            this.BtnAceptar.Size = new System.Drawing.Size(196, 39);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAceptar.Textcolor = System.Drawing.Color.White;
            this.BtnAceptar.TextFont = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LabelMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 211);
            this.panel1.TabIndex = 3;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.White;
            this.LabelMessage.Location = new System.Drawing.Point(12, 99);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(236, 100);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "Mensaje";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pictureBox1.Location = new System.Drawing.Point(71, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 300);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWarning";
            this.Load += new System.EventHandler(this.FrmWarning_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelMessage;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FadeTransition;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}