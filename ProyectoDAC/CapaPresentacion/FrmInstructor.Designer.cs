namespace CapaPresentacion
{
    partial class FrmInstructor
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
            Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstructor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopFrm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarPic = new System.Windows.Forms.PictureBox();
            this.BuscarPic = new System.Windows.Forms.PictureBox();
            this.Buscartxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InstructoresData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NuevoBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Apellidotxt = new System.Windows.Forms.TextBox();
            this.contactotxt = new System.Windows.Forms.TextBox();
            this.Correotxt = new System.Windows.Forms.TextBox();
            this.Grupocmbx = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstructoresData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = this.TopFrm;
            bunifuDragControl1.Vertical = true;
            // 
            // TopFrm
            // 
            this.TopFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.TopFrm.Controls.Add(this.label1);
            this.TopFrm.Controls.Add(this.CerrarPic);
            this.TopFrm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFrm.Location = new System.Drawing.Point(0, 0);
            this.TopFrm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TopFrm.Name = "TopFrm";
            this.TopFrm.Size = new System.Drawing.Size(1057, 29);
            this.TopFrm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "INSTRUCTORES";
            // 
            // CerrarPic
            // 
            this.CerrarPic.Image = ((System.Drawing.Image)(resources.GetObject("CerrarPic.Image")));
            this.CerrarPic.Location = new System.Drawing.Point(1031, 2);
            this.CerrarPic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CerrarPic.Name = "CerrarPic";
            this.CerrarPic.Size = new System.Drawing.Size(26, 24);
            this.CerrarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CerrarPic.TabIndex = 1;
            this.CerrarPic.TabStop = false;
            this.CerrarPic.Click += new System.EventHandler(this.CerrarPic_Click);
            this.CerrarPic.MouseLeave += new System.EventHandler(this.CerrarPic_MouseLeave);
            this.CerrarPic.MouseHover += new System.EventHandler(this.CerrarPic_MouseHover);
            // 
            // BuscarPic
            // 
            this.BuscarPic.Image = ((System.Drawing.Image)(resources.GetObject("BuscarPic.Image")));
            this.BuscarPic.Location = new System.Drawing.Point(46, 77);
            this.BuscarPic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BuscarPic.Name = "BuscarPic";
            this.BuscarPic.Size = new System.Drawing.Size(38, 34);
            this.BuscarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuscarPic.TabIndex = 7;
            this.BuscarPic.TabStop = false;
            // 
            // Buscartxt
            // 
            this.Buscartxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Buscartxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Buscartxt.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscartxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.Buscartxt.Location = new System.Drawing.Point(89, 77);
            this.Buscartxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Buscartxt.Name = "Buscartxt";
            this.Buscartxt.Size = new System.Drawing.Size(259, 32);
            this.Buscartxt.TabIndex = 8;
            this.Buscartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Buscartxt.TextChanged += new System.EventHandler(this.Buscartxt_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 66);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(455, 468);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1048, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 479);
            this.panel1.TabIndex = 11;
            // 
            // InstructoresData
            // 
            this.InstructoresData.AllowUserToAddRows = false;
            this.InstructoresData.AllowUserToDeleteRows = false;
            this.InstructoresData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InstructoresData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InstructoresData.BackgroundColor = System.Drawing.Color.White;
            this.InstructoresData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructoresData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstructoresData.ColumnHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InstructoresData.DefaultCellStyle = dataGridViewCellStyle16;
            this.InstructoresData.Location = new System.Drawing.Point(36, 180);
            this.InstructoresData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InstructoresData.Name = "InstructoresData";
            this.InstructoresData.ReadOnly = true;
            this.InstructoresData.RowHeadersVisible = false;
            this.InstructoresData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InstructoresData.Size = new System.Drawing.Size(374, 186);
            this.InstructoresData.TabIndex = 12;
            this.InstructoresData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstructoresData_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "NOMBRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(145, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "APELLIDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(628, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "GRUPO";
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.NuevoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.NuevoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NuevoBtn.BorderRadius = 7;
            this.NuevoBtn.ButtonText = "LIMPIAR";
            this.NuevoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoBtn.DisabledColor = System.Drawing.Color.Gray;
            this.NuevoBtn.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.NuevoBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("NuevoBtn.Iconimage")));
            this.NuevoBtn.Iconimage_right = null;
            this.NuevoBtn.Iconimage_right_Selected = null;
            this.NuevoBtn.Iconimage_Selected = null;
            this.NuevoBtn.IconMarginLeft = 0;
            this.NuevoBtn.IconMarginRight = 0;
            this.NuevoBtn.IconRightVisible = true;
            this.NuevoBtn.IconRightZoom = 0D;
            this.NuevoBtn.IconVisible = true;
            this.NuevoBtn.IconZoom = 25D;
            this.NuevoBtn.IsTab = false;
            this.NuevoBtn.Location = new System.Drawing.Point(901, 306);
            this.NuevoBtn.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.NuevoBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.NuevoBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.NuevoBtn.selected = false;
            this.NuevoBtn.Size = new System.Drawing.Size(125, 38);
            this.NuevoBtn.TabIndex = 15;
            this.NuevoBtn.Text = "LIMPIAR";
            this.NuevoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoBtn.Textcolor = System.Drawing.Color.White;
            this.NuevoBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoBtn.Click += new System.EventHandler(this.NuevoBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 479);
            this.panel2.TabIndex = 12;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.BorderRadius = 7;
            this.BtnEditar.ButtonText = "MODIFICAR";
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditar.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnEditar.IconZoom = 25D;
            this.BtnEditar.IsTab = false;
            this.BtnEditar.Location = new System.Drawing.Point(901, 373);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(125, 38);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "MODIFICAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Textcolor = System.Drawing.Color.White;
            this.BtnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 7;
            this.BtnEliminar.ButtonText = "ELIMINAR";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminar.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnEliminar.IconZoom = 25D;
            this.BtnEliminar.IsTab = false;
            this.BtnEliminar.Location = new System.Drawing.Point(744, 373);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(125, 38);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Textcolor = System.Drawing.Color.White;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(628, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "NOMBRES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(628, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "APELLIDOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(266, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "GRUPO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(624, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "CONTACTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(628, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "CORREO";
            // 
            // Nombretxt
            // 
            this.Nombretxt.BackColor = System.Drawing.Color.White;
            this.Nombretxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombretxt.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombretxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.Nombretxt.Location = new System.Drawing.Point(756, 49);
            this.Nombretxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(259, 32);
            this.Nombretxt.TabIndex = 23;
            this.Nombretxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombretxt.TextChanged += new System.EventHandler(this.Nombretxt_TextChanged);
            this.Nombretxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombretxt_KeyPress);
            // 
            // Apellidotxt
            // 
            this.Apellidotxt.BackColor = System.Drawing.Color.White;
            this.Apellidotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellidotxt.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.Apellidotxt.Location = new System.Drawing.Point(756, 97);
            this.Apellidotxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Apellidotxt.Name = "Apellidotxt";
            this.Apellidotxt.Size = new System.Drawing.Size(259, 32);
            this.Apellidotxt.TabIndex = 24;
            this.Apellidotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apellidotxt.TextChanged += new System.EventHandler(this.Apellidotxt_TextChanged);
            this.Apellidotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellidotxt_KeyPress);
            // 
            // contactotxt
            // 
            this.contactotxt.BackColor = System.Drawing.Color.White;
            this.contactotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactotxt.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.contactotxt.Location = new System.Drawing.Point(756, 195);
            this.contactotxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.contactotxt.Name = "contactotxt";
            this.contactotxt.Size = new System.Drawing.Size(259, 32);
            this.contactotxt.TabIndex = 25;
            this.contactotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contactotxt.TextChanged += new System.EventHandler(this.contactotxt_TextChanged);
            this.contactotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactotxt_KeyPress);
            // 
            // Correotxt
            // 
            this.Correotxt.BackColor = System.Drawing.Color.White;
            this.Correotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correotxt.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.Correotxt.Location = new System.Drawing.Point(756, 241);
            this.Correotxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Correotxt.Name = "Correotxt";
            this.Correotxt.Size = new System.Drawing.Size(259, 32);
            this.Correotxt.TabIndex = 26;
            this.Correotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Correotxt.TextChanged += new System.EventHandler(this.Correotxt_TextChanged);
            // 
            // Grupocmbx
            // 
            this.Grupocmbx.BackColor = System.Drawing.Color.White;
            this.Grupocmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grupocmbx.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupocmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.Grupocmbx.FormattingEnabled = true;
            this.Grupocmbx.Location = new System.Drawing.Point(761, 150);
            this.Grupocmbx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Grupocmbx.Name = "Grupocmbx";
            this.Grupocmbx.Size = new System.Drawing.Size(250, 29);
            this.Grupocmbx.TabIndex = 27;
            this.Grupocmbx.SelectedIndexChanged += new System.EventHandler(this.Grupocmbx_SelectedIndexChanged);
            this.Grupocmbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grupocmbx_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.BorderRadius = 7;
            this.BtnAgregar.ButtonText = "AGREGAR";
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAgregar.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Iconimage")));
            this.BtnAgregar.Iconimage_right = null;
            this.BtnAgregar.Iconimage_right_Selected = null;
            this.BtnAgregar.Iconimage_Selected = null;
            this.BtnAgregar.IconMarginLeft = 0;
            this.BtnAgregar.IconMarginRight = 0;
            this.BtnAgregar.IconRightVisible = true;
            this.BtnAgregar.IconRightZoom = 0D;
            this.BtnAgregar.IconVisible = true;
            this.BtnAgregar.IconZoom = 25D;
            this.BtnAgregar.IsTab = false;
            this.BtnAgregar.Location = new System.Drawing.Point(744, 306);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.BtnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(162)))), ((int)(((byte)(80)))));
            this.BtnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAgregar.selected = false;
            this.BtnAgregar.Size = new System.Drawing.Size(125, 38);
            this.BtnAgregar.TabIndex = 28;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Textcolor = System.Drawing.Color.White;
            this.BtnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(9, 499);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 9);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(744, 43);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(282, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(744, 91);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(282, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(744, 188);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(282, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 33;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(744, 235);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(282, 41);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(744, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorProv
            // 
            this.ErrorProv.ContainerControl = this;
            // 
            // FrmInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.Grupocmbx);
            this.Controls.Add(this.Correotxt);
            this.Controls.Add(this.contactotxt);
            this.Controls.Add(this.Apellidotxt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BuscarPic);
            this.Controls.Add(this.NuevoBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstructoresData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Buscartxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TopFrm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmInstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInstructor";
            this.Load += new System.EventHandler(this.FrmInstructor_Load);
            this.TopFrm.ResumeLayout(false);
            this.TopFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstructoresData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopFrm;
        private System.Windows.Forms.PictureBox CerrarPic;
        private System.Windows.Forms.PictureBox BuscarPic;
        private System.Windows.Forms.TextBox Buscartxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView InstructoresData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton NuevoBtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Apellidotxt;
        private System.Windows.Forms.TextBox contactotxt;
        private System.Windows.Forms.TextBox Correotxt;
        private System.Windows.Forms.ComboBox Grupocmbx;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider ErrorProv;
    }
}