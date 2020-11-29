using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal
{
    public partial class FormInicio : Form
    {
        private byte[] imagen;
        private byte[] txt;
        Bitmap img;
        private BitmapData bmpData;
        private IntPtr ptr;
        private int bytes;

        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            switch (tabEncriptar.SelectedIndex)
            {
                case 0:
                    //texto
                    if (txtEncriptar.Text == string.Empty)
                        MessageBox.Show("Se tiene que ingresar un texto a encriptar.", "Campo incompleto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                        encriptarTexto(txtEncriptar.Text);
                    break;

                case 1:
                    //imagen
                    if (txtArchivo.Text == string.Empty)
                        MessageBox.Show("Se tiene que seleccionar un archivo a encriptar.", "Archivo no seleccionado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                    {
                        encriptarImagen();
                        panelTexto.Visible = false;
                        panelImagen.Visible = true;
                    }
                    break;

                case 2:
                    //txt
                    if (txtTexto.Text == string.Empty)
                        MessageBox.Show("Se tiene que seleccionar un archivo a encriptar.", "Archivo no seleccionado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                    {
                        encriptarTxt();
                        panelTexto.Visible = true;
                        panelImagen.Visible = false;
                    }
                    break;

                default:
                    break;
            }
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
            byte[] ciphertext = gamal.EncriptarData(plaintext);


            //Creamos una nueva instancia para desencriptar
            ElGamal desencriptar = new ElGamalManaged();
            desencriptar.FromXmlString(gamal.ToXmlString(true));
            //Restauramos el texto plano
            byte[] plaintext_candidato = desencriptar.DesencriptarData(ciphertext);

            return plaintext_candidato;
        }


        private void encriptarTexto(string texto)
        {
            //Tomamos los bytes del texto plano
            byte[] plaintext = Encoding.Default.GetBytes(texto);

            byte[] plaintext_candidato = encriptar(plaintext);

            lblCiphertext.Text = "Array: " + plaintext_candidato.ToString() + "\n" +
                Encoding.Default.GetString(plaintext_candidato);

            lblComparacion.Text = "Encriptacion basica:\n\n";
            compararArrays(plaintext, plaintext_candidato);
            lblDescifrado.Text = Encoding.Default.GetString(plaintext_candidato);
            lblOriginal.Text = Encoding.Default.GetString(plaintext);
        }


        private void encriptarImagen()
        {
            byte[] imagen_candidato = encriptar(imagen);

            lblCiphertext.Text = "Array: " + imagen_candidato.ToString();

            lblComparacion.Text = "Encriptacion basica:\n\n";
            compararArrays(imagen, imagen_candidato);
            
            arrayAImagen(imagen, imagen_candidato);
        }


        private void encriptarTxt()
        {
            //Restauramos el texto plano
            byte[] txt_candidato = encriptar(txt);

            lblCiphertext.Text = "Array: " + txt_candidato.ToString() + "\n\n" +
                Encoding.Default.GetString(txt_candidato);

            lblComparacion.Text = "Encriptacion basica:\n\n";
            compararArrays(txt, txt_candidato);
            lblDescifrado.Text = Encoding.Default.GetString(txt_candidato);
            lblOriginal.Text = Encoding.Default.GetString(txt);
        }


        private bool compararArrays(byte[] arr1, byte[] arr2)
        {
            Parallel.For(0, arr1.Length, i =>
            {
                if (arr1[i] != arr2[i])
                {
                    lblComparacion.Text += "Item " + i + ": " + arr1[i] + " --> " + arr2[i];
                    lblComparacion.Text += " = FALSE\n\n";
                }
            });

            lblComparacion.Text += "\n\n\nTODO OK";
            return true;
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
            lblCiphertext.Clear();
            lblComparacion.Clear();
            lblDescifrado.Clear();
            lblOriginal.Clear();
            lblXml.Clear();
            panelTexto.Visible = false;
            panelImagen.Visible = false;
        }
    }
}
