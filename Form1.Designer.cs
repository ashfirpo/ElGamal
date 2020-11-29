namespace ElGamal
{
    partial class FormInicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.tabEncriptar = new System.Windows.Forms.TabControl();
            this.tabTexto = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncriptar = new System.Windows.Forms.TextBox();
            this.tabImagen = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTexto = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabXml = new System.Windows.Forms.TabPage();
            this.lblXml = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblComparacion = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCiphertext = new System.Windows.Forms.TextBox();
            this.tabTextos = new System.Windows.Forms.TabPage();
            this.tabImagenes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescifrado = new System.Windows.Forms.TextBox();
            this.lblOriginal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTexto = new System.Windows.Forms.Panel();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbDescifrado = new System.Windows.Forms.PictureBox();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tabEncriptar.SuspendLayout();
            this.tabTexto.SuspendLayout();
            this.tabImagen.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabXml.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabTextos.SuspendLayout();
            this.tabImagenes.SuspendLayout();
            this.panelTexto.SuspendLayout();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescifrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnEncriptar);
            this.groupBox1.Controls.Add(this.tabEncriptar);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de datos a encriptar";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Location = new System.Drawing.Point(415, 150);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar to&do";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncriptar.Location = new System.Drawing.Point(301, 150);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 5;
            this.btnEncriptar.Text = "&Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // tabEncriptar
            // 
            this.tabEncriptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEncriptar.Controls.Add(this.tabTexto);
            this.tabEncriptar.Controls.Add(this.tabImagen);
            this.tabEncriptar.Controls.Add(this.tabPage4);
            this.tabEncriptar.Location = new System.Drawing.Point(6, 19);
            this.tabEncriptar.Name = "tabEncriptar";
            this.tabEncriptar.SelectedIndex = 0;
            this.tabEncriptar.Size = new System.Drawing.Size(764, 116);
            this.tabEncriptar.TabIndex = 4;
            // 
            // tabTexto
            // 
            this.tabTexto.Controls.Add(this.label2);
            this.tabTexto.Controls.Add(this.txtEncriptar);
            this.tabTexto.Location = new System.Drawing.Point(4, 22);
            this.tabTexto.Name = "tabTexto";
            this.tabTexto.Padding = new System.Windows.Forms.Padding(3);
            this.tabTexto.Size = new System.Drawing.Size(756, 90);
            this.tabTexto.TabIndex = 0;
            this.tabTexto.Text = "Texto";
            this.tabTexto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar texto plano a encriptar:";
            // 
            // txtEncriptar
            // 
            this.txtEncriptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncriptar.Location = new System.Drawing.Point(168, 15);
            this.txtEncriptar.Multiline = true;
            this.txtEncriptar.Name = "txtEncriptar";
            this.txtEncriptar.Size = new System.Drawing.Size(560, 69);
            this.txtEncriptar.TabIndex = 3;
            // 
            // tabImagen
            // 
            this.tabImagen.Controls.Add(this.btnBuscar);
            this.tabImagen.Controls.Add(this.txtArchivo);
            this.tabImagen.Controls.Add(this.label3);
            this.tabImagen.Location = new System.Drawing.Point(4, 22);
            this.tabImagen.Name = "tabImagen";
            this.tabImagen.Padding = new System.Windows.Forms.Padding(3);
            this.tabImagen.Size = new System.Drawing.Size(756, 90);
            this.tabImagen.TabIndex = 1;
            this.tabImagen.Text = "Imágenes";
            this.tabImagen.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(577, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivo.Location = new System.Drawing.Point(168, 34);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(403, 20);
            this.txtArchivo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ruta de la imagen:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnTexto);
            this.tabPage4.Controls.Add(this.txtTexto);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(756, 90);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Archivos de texto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTexto
            // 
            this.btnTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTexto.Location = new System.Drawing.Point(569, 32);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(75, 23);
            this.btnTexto.TabIndex = 5;
            this.btnTexto.Text = "&Buscar";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTexto.Location = new System.Drawing.Point(160, 34);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(403, 20);
            this.txtTexto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ruta del archivo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 228);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabXml);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabTextos);
            this.tabControl1.Controls.Add(this.tabImagenes);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 203);
            this.tabControl1.TabIndex = 3;
            // 
            // tabXml
            // 
            this.tabXml.Controls.Add(this.lblXml);
            this.tabXml.Location = new System.Drawing.Point(4, 22);
            this.tabXml.Name = "tabXml";
            this.tabXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabXml.Size = new System.Drawing.Size(756, 177);
            this.tabXml.TabIndex = 0;
            this.tabXml.Text = "XML";
            this.tabXml.UseVisualStyleBackColor = true;
            // 
            // lblXml
            // 
            this.lblXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXml.Location = new System.Drawing.Point(6, 6);
            this.lblXml.Multiline = true;
            this.lblXml.Name = "lblXml";
            this.lblXml.ReadOnly = true;
            this.lblXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblXml.Size = new System.Drawing.Size(744, 165);
            this.lblXml.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblComparacion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 177);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comparación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblComparacion
            // 
            this.lblComparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComparacion.Location = new System.Drawing.Point(3, 3);
            this.lblComparacion.Multiline = true;
            this.lblComparacion.Name = "lblComparacion";
            this.lblComparacion.ReadOnly = true;
            this.lblComparacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblComparacion.Size = new System.Drawing.Size(750, 168);
            this.lblComparacion.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCiphertext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 177);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Datos encriptados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCiphertext.Location = new System.Drawing.Point(3, 3);
            this.lblCiphertext.Multiline = true;
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.ReadOnly = true;
            this.lblCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblCiphertext.Size = new System.Drawing.Size(747, 168);
            this.lblCiphertext.TabIndex = 0;
            // 
            // tabTextos
            // 
            this.tabTextos.Controls.Add(this.panelTexto);
            this.tabTextos.Controls.Add(this.label5);
            this.tabTextos.Location = new System.Drawing.Point(4, 22);
            this.tabTextos.Name = "tabTextos";
            this.tabTextos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextos.Size = new System.Drawing.Size(756, 177);
            this.tabTextos.TabIndex = 3;
            this.tabTextos.Text = "Diferencias de texto";
            this.tabTextos.UseVisualStyleBackColor = true;
            // 
            // tabImagenes
            // 
            this.tabImagenes.Controls.Add(this.panelImagen);
            this.tabImagenes.Controls.Add(this.label7);
            this.tabImagenes.Location = new System.Drawing.Point(4, 22);
            this.tabImagenes.Name = "tabImagenes";
            this.tabImagenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabImagenes.Size = new System.Drawing.Size(756, 177);
            this.tabImagenes.TabIndex = 4;
            this.tabImagenes.Text = "Diferencia de imágenes";
            this.tabImagenes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ElGamal";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "No se ha encriptado un archivo de texto";
            // 
            // lblDescifrado
            // 
            this.lblDescifrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescifrado.Location = new System.Drawing.Point(384, 24);
            this.lblDescifrado.Multiline = true;
            this.lblDescifrado.Name = "lblDescifrado";
            this.lblDescifrado.ReadOnly = true;
            this.lblDescifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblDescifrado.Size = new System.Drawing.Size(369, 145);
            this.lblDescifrado.TabIndex = 8;
            // 
            // lblOriginal
            // 
            this.lblOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOriginal.Location = new System.Drawing.Point(3, 24);
            this.lblOriginal.Multiline = true;
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.ReadOnly = true;
            this.lblOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblOriginal.Size = new System.Drawing.Size(375, 145);
            this.lblOriginal.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Descifrado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Original";
            // 
            // panelTexto
            // 
            this.panelTexto.Controls.Add(this.label6);
            this.panelTexto.Controls.Add(this.label9);
            this.panelTexto.Controls.Add(this.lblOriginal);
            this.panelTexto.Controls.Add(this.lblDescifrado);
            this.panelTexto.Location = new System.Drawing.Point(0, 0);
            this.panelTexto.Name = "panelTexto";
            this.panelTexto.Size = new System.Drawing.Size(756, 177);
            this.panelTexto.TabIndex = 8;
            this.panelTexto.Visible = false;
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.label8);
            this.panelImagen.Controls.Add(this.label10);
            this.panelImagen.Controls.Add(this.pbDescifrado);
            this.panelImagen.Controls.Add(this.pbOriginal);
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(756, 177);
            this.panelImagen.TabIndex = 0;
            this.panelImagen.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "No se ha encriptado una imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Original";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Descifrado";
            // 
            // pbDescifrado
            // 
            this.pbDescifrado.Location = new System.Drawing.Point(504, 4);
            this.pbDescifrado.Name = "pbDescifrado";
            this.pbDescifrado.Size = new System.Drawing.Size(192, 168);
            this.pbDescifrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDescifrado.TabIndex = 11;
            this.pbDescifrado.TabStop = false;
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(108, 4);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(192, 168);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOriginal.TabIndex = 10;
            this.pbOriginal.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(816, 526);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElGamal";
            this.groupBox1.ResumeLayout(false);
            this.tabEncriptar.ResumeLayout(false);
            this.tabTexto.ResumeLayout(false);
            this.tabTexto.PerformLayout();
            this.tabImagen.ResumeLayout(false);
            this.tabImagen.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabXml.ResumeLayout(false);
            this.tabXml.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabTextos.ResumeLayout(false);
            this.tabTextos.PerformLayout();
            this.tabImagenes.ResumeLayout(false);
            this.tabImagenes.PerformLayout();
            this.panelTexto.ResumeLayout(false);
            this.panelTexto.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescifrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TabControl tabEncriptar;
        private System.Windows.Forms.TabPage tabTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncriptar;
        private System.Windows.Forms.TabPage tabImagen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabXml;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabTextos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox lblXml;
        private System.Windows.Forms.TextBox lblComparacion;
        private System.Windows.Forms.TextBox lblCiphertext;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabImagenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTexto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblOriginal;
        private System.Windows.Forms.TextBox lblDescifrado;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbDescifrado;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.Label label7;
    }
}

