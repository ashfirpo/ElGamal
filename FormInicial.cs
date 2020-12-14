using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ElGamal
{
    public partial class FormInicio : Form
    {
        private byte[] imagen;
        private byte[] txt;
        private byte[] cifrado;
        private Stopwatch watch = new Stopwatch();

        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            switch (tabEncriptar.SelectedIndex)
            {
                case 0:
                    //Texto plano
                    if (txtEncriptar.Text == string.Empty)
                        MessageBox.Show("Se tiene que ingresar un texto a encriptar.", "Campo incompleto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                    {
                        lblStatus.Text = "Procesando...";
                        encriptarTexto(txtEncriptar.Text);
                        visibilidad(true, false, false);
                        informarProgreso();
                    }
                    break;

                case 2:
                    //Imagen
                    if (txtArchivo.Text == string.Empty)
                        MessageBox.Show("Se tiene que seleccionar un archivo a encriptar.", "Archivo no seleccionado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                    {
                        lblStatus.Text = "Procesando...";
                        encriptarImagen();
                        visibilidad(false, false, true);
                        informarProgreso();
                    }
                    break;

                case 1:
                    //Archivo txt
                    if (txtTexto.Text == string.Empty)
                        MessageBox.Show("Se tiene que seleccionar un archivo a encriptar.", "Archivo no seleccionado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                    {
                        lblStatus.Text = "Procesando...";
                        encriptarTxt();
                        visibilidad(false, true, false);
                        informarProgreso();
                    }
                    break;

                default:
                    break;
            }
        }

        private void visibilidad(bool plano, bool archivo, bool imagen)
        {
            panelPlano.Visible = plano;
            panelTexto.Visible = archivo;
            panelImagen.Visible = imagen;           
        }

        private void informarProgreso()
        {
            lblStatus.Text = "Listo: Fin del proceso - Tiempo transcurrido: " + watch.Elapsed.Minutes + " min., " + watch.Elapsed.Seconds + " seg., " + watch.Elapsed.Milliseconds + " ms.";
        }


        private byte[] encriptar(byte[] plaintext)
        {
            //Instanciamos al algoritmo
            ElGamal gamal = new ElGamalManaged();

            //Seteamos el tamaño de las keys
            gamal.KeySize = 384;
            //Extraemos y printeamos el string xml
            //esto va a generar un nuevo par de keys
            string xml_string = gamal.ToXmlString(true);
            lblXml.Text = xml_string;


            //Ahora que ya generamos claves, pasamos a encriptar
            ElGamal encriptar = new ElGamalManaged();
            encriptar.FromXmlString(gamal.ToXmlString(false));
            Console.WriteLine("--- Encriptado ---");

            //Tomamos el tiempo (opcional)
            watch.Start();
            cifrado = gamal.EncriptarData(plaintext);


            //Creamos una nueva instancia para desencriptar
            ElGamal desencriptar = new ElGamalManaged();
            desencriptar.FromXmlString(gamal.ToXmlString(true));
            Console.WriteLine("--- Desencriptado ---");
            byte[] plaintext_candidato = desencriptar.DesencriptarData(cifrado);

            watch.Stop();
            Console.WriteLine("--- FIN DEL PROCESO ---");
            //Console.WriteLine("Tiempo transcurrido: " + watch.Elapsed.ToString());

            return plaintext_candidato;
        }


        private void encriptarTexto(string texto)
        {
            //Tomamos los bytes del texto plano
            byte[] plaintext = Encoding.Default.GetBytes(texto);
            //Encriptamos
            byte[] plaintext_candidato = encriptar(plaintext);

            //Mostramos toda la info
            txtTextoPlano.Text = texto;
            txtPlanoCifrado.Text = Encoding.Default.GetString(cifrado);
            txtPlanoDescifrado.Text = Encoding.Default.GetString(plaintext_candidato);
        }


        private void encriptarImagen()
        {
            byte[] imagen_candidato = encriptar(imagen);
            //Mostramos los 3 resultados
            arrayAImagen(imagen, imagen_candidato);
            txtImagenCifrada.Text = Encoding.Default.GetString(cifrado);
        }


        private void encriptarTxt()
        {
            byte[] txt_candidato = encriptar(txt);

            txtArchivoOriginal.Text = Encoding.UTF8.GetString(txt);
            txtArchivoCifrado.Text = Encoding.Default.GetString(cifrado);
            txtArchivoDescifrado.Text = Encoding.UTF8.GetString(txt_candidato);
        }


        private void arrayAImagen(byte[] original, byte[] candidato)
        {
            try
            {
                pbOriginal.Image = (Bitmap)((new ImageConverter()).ConvertFrom(original));
                pbDescifrado.Image = (Bitmap)((new ImageConverter()).ConvertFrom(candidato));
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion: " + e.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";
            ofd.FilterIndex = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                Image img = Image.FromFile(ofd.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Position = 0;
                    img.Save(ms, img.RawFormat);
                    imagen = ms.ToArray();
                }

                txtArchivo.Text = path;
            }
        }


        private void btnTexto_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            OpenFileDialog ofd_txt = new OpenFileDialog();
            ofd_txt.RestoreDirectory = true;
            ofd_txt.Filter = "Archivos de texto|*.txt";
            ofd_txt.FilterIndex = 0;

            if (ofd_txt.ShowDialog() == DialogResult.OK)
            {
                path = ofd_txt.FileName;
                txt = File.ReadAllBytes(ofd_txt.FileName);

                txtTexto.Text = path;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();
            txtEncriptar.Clear();
            txtTexto.Clear();
            txtTextoPlano.Clear();
            txtPlanoDescifrado.Clear();
            txtPlanoCifrado.Clear();
            txtArchivoCifrado.Clear();
            txtArchivoDescifrado.Clear();
            txtArchivoOriginal.Clear();
            txtImagenCifrada.Clear();
            lblXml.Clear();
            lblStatus.Text = "Listo";
            panelPlano.Visible = panelTexto.Visible = panelImagen.Visible = false;
        }
    }
}
