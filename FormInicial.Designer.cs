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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.tabEncriptar = new System.Windows.Forms.TabControl();
            this.tabTexto = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncriptar = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTexto = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabImagen = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabXml = new System.Windows.Forms.TabPage();
            this.lblXml = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelPlano = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlanoCifrado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTextoPlano = new System.Windows.Forms.TextBox();
            this.txtPlanoDescifrado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabTextos = new System.Windows.Forms.TabPage();
            this.panelTexto = new System.Windows.Forms.TableLayoutPanel();
            this.txtArchivoOriginal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtArchivoCifrado = new System.Windows.Forms.TextBox();
            this.txtArchivoDescifrado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabImagenes = new System.Windows.Forms.TabPage();
            this.panelImagen = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImagenCifrada = new System.Windows.Forms.TextBox();
            this.pbDescifrado = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tabEncriptar.SuspendLayout();
            this.tabTexto.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabImagen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabXml.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelPlano.SuspendLayout();
            this.tabTextos.SuspendLayout();
            this.panelTexto.SuspendLayout();
            this.tabImagenes.SuspendLayout();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescifrado)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnEncriptar);
            this.groupBox1.Controls.Add(this.tabEncriptar);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de datos a encriptar";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrar.Location = new System.Drawing.Point(411, 130);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar to&do";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEncriptar.Location = new System.Drawing.Point(297, 130);
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
            this.tabEncriptar.Controls.Add(this.tabPage4);
            this.tabEncriptar.Controls.Add(this.tabImagen);
            this.tabEncriptar.Location = new System.Drawing.Point(6, 19);
            this.tabEncriptar.Name = "tabEncriptar";
            this.tabEncriptar.SelectedIndex = 0;
            this.tabEncriptar.Size = new System.Drawing.Size(770, 106);
            this.tabEncriptar.TabIndex = 4;
            // 
            // tabTexto
            // 
            this.tabTexto.Controls.Add(this.label2);
            this.tabTexto.Controls.Add(this.txtEncriptar);
            this.tabTexto.Location = new System.Drawing.Point(4, 23);
            this.tabTexto.Name = "tabTexto";
            this.tabTexto.Padding = new System.Windows.Forms.Padding(3);
            this.tabTexto.Size = new System.Drawing.Size(762, 79);
            this.tabTexto.TabIndex = 0;
            this.tabTexto.Text = "Texto plano";
            this.tabTexto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar texto plano a encriptar:";
            // 
            // txtEncriptar
            // 
            this.txtEncriptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncriptar.Location = new System.Drawing.Point(184, 6);
            this.txtEncriptar.Multiline = true;
            this.txtEncriptar.Name = "txtEncriptar";
            this.txtEncriptar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncriptar.Size = new System.Drawing.Size(572, 69);
            this.txtEncriptar.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnTexto);
            this.tabPage4.Controls.Add(this.txtTexto);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 79);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Archivos de texto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTexto
            // 
            this.btnTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTexto.Location = new System.Drawing.Point(598, 28);
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
            this.txtTexto.Location = new System.Drawing.Point(183, 29);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(409, 22);
            this.txtTexto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ruta del archivo:";
            // 
            // tabImagen
            // 
            this.tabImagen.Controls.Add(this.btnBuscar);
            this.tabImagen.Controls.Add(this.txtArchivo);
            this.tabImagen.Controls.Add(this.label3);
            this.tabImagen.Location = new System.Drawing.Point(4, 23);
            this.tabImagen.Name = "tabImagen";
            this.tabImagen.Padding = new System.Windows.Forms.Padding(3);
            this.tabImagen.Size = new System.Drawing.Size(762, 79);
            this.tabImagen.TabIndex = 1;
            this.tabImagen.Text = "Imágenes";
            this.tabImagen.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(602, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivo.Location = new System.Drawing.Point(187, 29);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(409, 22);
            this.txtArchivo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ruta de la imagen:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(368, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ElGamal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 248);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabXml);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabTextos);
            this.tabControl1.Controls.Add(this.tabImagenes);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 223);
            this.tabControl1.TabIndex = 10;
            // 
            // tabXml
            // 
            this.tabXml.Controls.Add(this.lblXml);
            this.tabXml.Location = new System.Drawing.Point(4, 23);
            this.tabXml.Name = "tabXml";
            this.tabXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabXml.Size = new System.Drawing.Size(762, 196);
            this.tabXml.TabIndex = 0;
            this.tabXml.Text = "Set de Claves";
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
            this.lblXml.Size = new System.Drawing.Size(750, 184);
            this.lblXml.TabIndex = 2;
            this.lblXml.Text = "No se han generado claves aún";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelPlano);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 196);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Diferencias de texto plano";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelPlano
            // 
            this.panelPlano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlano.ColumnCount = 3;
            this.panelPlano.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelPlano.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelPlano.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelPlano.Controls.Add(this.txtPlanoCifrado, 0, 1);
            this.panelPlano.Controls.Add(this.label6, 2, 0);
            this.panelPlano.Controls.Add(this.label9, 1, 0);
            this.panelPlano.Controls.Add(this.label11, 0, 0);
            this.panelPlano.Controls.Add(this.txtTextoPlano, 0, 1);
            this.panelPlano.Controls.Add(this.txtPlanoDescifrado, 2, 1);
            this.panelPlano.Location = new System.Drawing.Point(0, 0);
            this.panelPlano.Name = "panelPlano";
            this.panelPlano.RowCount = 2;
            this.panelPlano.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelPlano.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPlano.Size = new System.Drawing.Size(762, 196);
            this.panelPlano.TabIndex = 15;
            this.panelPlano.Visible = false;
            // 
            // txtPlanoCifrado
            // 
            this.txtPlanoCifrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanoCifrado.Location = new System.Drawing.Point(256, 23);
            this.txtPlanoCifrado.Multiline = true;
            this.txtPlanoCifrado.Name = "txtPlanoCifrado";
            this.txtPlanoCifrado.ReadOnly = true;
            this.txtPlanoCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlanoCifrado.Size = new System.Drawing.Size(248, 170);
            this.txtPlanoCifrado.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Descifrado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cifrado";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Original";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTextoPlano
            // 
            this.txtTextoPlano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextoPlano.Location = new System.Drawing.Point(3, 23);
            this.txtTextoPlano.Multiline = true;
            this.txtTextoPlano.Name = "txtTextoPlano";
            this.txtTextoPlano.ReadOnly = true;
            this.txtTextoPlano.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextoPlano.Size = new System.Drawing.Size(247, 170);
            this.txtTextoPlano.TabIndex = 22;
            // 
            // txtPlanoDescifrado
            // 
            this.txtPlanoDescifrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanoDescifrado.Location = new System.Drawing.Point(510, 23);
            this.txtPlanoDescifrado.Multiline = true;
            this.txtPlanoDescifrado.Name = "txtPlanoDescifrado";
            this.txtPlanoDescifrado.ReadOnly = true;
            this.txtPlanoDescifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlanoDescifrado.Size = new System.Drawing.Size(249, 170);
            this.txtPlanoDescifrado.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Location = new System.Drawing.Point(-4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(766, 196);
            this.label15.TabIndex = 14;
            this.label15.Text = "No se ha encriptado un texto plano";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabTextos
            // 
            this.tabTextos.Controls.Add(this.panelTexto);
            this.tabTextos.Controls.Add(this.label5);
            this.tabTextos.Location = new System.Drawing.Point(4, 23);
            this.tabTextos.Name = "tabTextos";
            this.tabTextos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextos.Size = new System.Drawing.Size(762, 196);
            this.tabTextos.TabIndex = 3;
            this.tabTextos.Text = "Diferencias de archivos de texto";
            this.tabTextos.UseVisualStyleBackColor = true;
            // 
            // panelTexto
            // 
            this.panelTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTexto.ColumnCount = 3;
            this.panelTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelTexto.Controls.Add(this.txtArchivoOriginal, 0, 1);
            this.panelTexto.Controls.Add(this.label17, 2, 0);
            this.panelTexto.Controls.Add(this.label18, 1, 0);
            this.panelTexto.Controls.Add(this.label19, 0, 0);
            this.panelTexto.Controls.Add(this.txtArchivoCifrado, 1, 1);
            this.panelTexto.Controls.Add(this.txtArchivoDescifrado, 2, 1);
            this.panelTexto.Location = new System.Drawing.Point(0, 0);
            this.panelTexto.Name = "panelTexto";
            this.panelTexto.RowCount = 2;
            this.panelTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTexto.Size = new System.Drawing.Size(762, 196);
            this.panelTexto.TabIndex = 10;
            this.panelTexto.Visible = false;
            // 
            // txtArchivoOriginal
            // 
            this.txtArchivoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivoOriginal.Location = new System.Drawing.Point(3, 23);
            this.txtArchivoOriginal.Multiline = true;
            this.txtArchivoOriginal.Name = "txtArchivoOriginal";
            this.txtArchivoOriginal.ReadOnly = true;
            this.txtArchivoOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArchivoOriginal.Size = new System.Drawing.Size(247, 170);
            this.txtArchivoOriginal.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(510, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Descifrado";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(256, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(248, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Cifrado";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(247, 20);
            this.label19.TabIndex = 17;
            this.label19.Text = "Original";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArchivoCifrado
            // 
            this.txtArchivoCifrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivoCifrado.Location = new System.Drawing.Point(256, 23);
            this.txtArchivoCifrado.Multiline = true;
            this.txtArchivoCifrado.Name = "txtArchivoCifrado";
            this.txtArchivoCifrado.ReadOnly = true;
            this.txtArchivoCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArchivoCifrado.Size = new System.Drawing.Size(248, 170);
            this.txtArchivoCifrado.TabIndex = 22;
            // 
            // txtArchivoDescifrado
            // 
            this.txtArchivoDescifrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivoDescifrado.Location = new System.Drawing.Point(510, 23);
            this.txtArchivoDescifrado.Multiline = true;
            this.txtArchivoDescifrado.Name = "txtArchivoDescifrado";
            this.txtArchivoDescifrado.ReadOnly = true;
            this.txtArchivoDescifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArchivoDescifrado.Size = new System.Drawing.Size(249, 170);
            this.txtArchivoDescifrado.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(762, 196);
            this.label5.TabIndex = 9;
            this.label5.Text = "No se ha encriptado un archivo de texto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabImagenes
            // 
            this.tabImagenes.Controls.Add(this.panelImagen);
            this.tabImagenes.Controls.Add(this.label7);
            this.tabImagenes.Location = new System.Drawing.Point(4, 23);
            this.tabImagenes.Name = "tabImagenes";
            this.tabImagenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabImagenes.Size = new System.Drawing.Size(762, 196);
            this.tabImagenes.TabIndex = 4;
            this.tabImagenes.Text = "Diferencia de imágenes";
            this.tabImagenes.UseVisualStyleBackColor = true;
            // 
            // panelImagen
            // 
            this.panelImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImagen.ColumnCount = 3;
            this.panelImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelImagen.Controls.Add(this.label16, 2, 0);
            this.panelImagen.Controls.Add(this.label10, 1, 0);
            this.panelImagen.Controls.Add(this.pbOriginal, 0, 1);
            this.panelImagen.Controls.Add(this.label8, 0, 0);
            this.panelImagen.Controls.Add(this.txtImagenCifrada, 1, 1);
            this.panelImagen.Controls.Add(this.pbDescifrado, 2, 1);
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.RowCount = 2;
            this.panelImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelImagen.Size = new System.Drawing.Size(762, 196);
            this.panelImagen.TabIndex = 2;
            this.panelImagen.Visible = false;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(510, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(249, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Descifrado";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cifrado";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbOriginal
            // 
            this.pbOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOriginal.Location = new System.Drawing.Point(3, 23);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(247, 170);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 16;
            this.pbOriginal.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Original";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImagenCifrada
            // 
            this.txtImagenCifrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagenCifrada.Location = new System.Drawing.Point(256, 23);
            this.txtImagenCifrada.Multiline = true;
            this.txtImagenCifrada.Name = "txtImagenCifrada";
            this.txtImagenCifrada.ReadOnly = true;
            this.txtImagenCifrada.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtImagenCifrada.Size = new System.Drawing.Size(248, 170);
            this.txtImagenCifrada.TabIndex = 18;
            // 
            // pbDescifrado
            // 
            this.pbDescifrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDescifrado.Location = new System.Drawing.Point(510, 23);
            this.pbDescifrado.Name = "pbDescifrado";
            this.pbDescifrado.Size = new System.Drawing.Size(249, 170);
            this.pbDescifrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDescifrado.TabIndex = 19;
            this.pbDescifrado.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(759, 193);
            this.label7.TabIndex = 1;
            this.label7.Text = "No se ha encriptado una imagen";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBarStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 17);
            this.lblStatus.Text = "Listo";
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(100, 16);
            this.progressBarStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarStatus.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElGamal";
            this.groupBox1.ResumeLayout(false);
            this.tabEncriptar.ResumeLayout(false);
            this.tabTexto.ResumeLayout(false);
            this.tabTexto.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabImagen.ResumeLayout(false);
            this.tabImagen.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabXml.ResumeLayout(false);
            this.tabXml.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panelPlano.ResumeLayout(false);
            this.panelPlano.PerformLayout();
            this.tabTextos.ResumeLayout(false);
            this.panelTexto.ResumeLayout(false);
            this.panelTexto.PerformLayout();
            this.tabImagenes.ResumeLayout(false);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescifrado)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabEncriptar;
        private System.Windows.Forms.TabPage tabTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncriptar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabImagen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabXml;
        private System.Windows.Forms.TabPage tabTextos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabImagenes;
        private System.Windows.Forms.TableLayoutPanel panelImagen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImagenCifrada;
        private System.Windows.Forms.PictureBox pbDescifrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel panelPlano;
        private System.Windows.Forms.TextBox txtPlanoDescifrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTextoPlano;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel panelTexto;
        private System.Windows.Forms.TextBox txtArchivoOriginal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtArchivoCifrado;
        private System.Windows.Forms.TextBox txtArchivoDescifrado;
        private System.Windows.Forms.TextBox txtPlanoCifrado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBarStatus;
        private System.Windows.Forms.TextBox lblXml;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

