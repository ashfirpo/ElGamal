using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ElGamal
{
    [Serializable]
    public struct ElGamalParametros
    {
        public byte[] P;
        public byte[] G;
        public byte[] Y;
        [NonSerialized] public byte[] X;
    }

    public abstract class ElGamal : AsymmetricAlgorithm
    {
        public abstract void ImportarParametros(ElGamalParametros parametros);
        public abstract ElGamalParametros ExportarParametros(bool p_params);
        public abstract byte[] EncriptarData(byte[] p_data);
        public abstract byte[] DesencriptarData(byte[] p_data);
        public abstract byte[] Sign(byte[] p_hashcode);
        public abstract bool VerifySignature(byte[] p_hashcode, byte[] p_signature);


        public override string ToXmlString(bool p_include_private)
        {
            ElGamalParametros x_params = ExportarParametros(p_include_private);
            //Creamos un string builder
            StringBuilder x_sb = new StringBuilder();
            //Agregamos el header
            x_sb.Append("<ElGamalKeyValue>");
            //Agregamos los elementos públicos de los parámetros
            x_sb.Append("<P>" + Convert.ToBase64String(x_params.P) + "</P>");
            x_sb.Append("<G>" + Convert.ToBase64String(x_params.G) + "</G>");
            x_sb.Append("<Y>" + Convert.ToBase64String(x_params.Y) + "</Y>");
            if (p_include_private)
            {
                //Agregamos X, que es parte de la clave privada
                x_sb.Append("<X>" + Convert.ToBase64String(x_params.X) + "</X>");
            }
            //Cerramos el header
            x_sb.Append("</ElGamalKeyValue>");
            return x_sb.ToString();
        }

        public override void FromXmlString(String p_string)
        {
            ElGamalParametros x_params = new ElGamalParametros();
            XmlTextReader x_reader = new XmlTextReader(new System.IO.StringReader(p_string));

            //Recorremos los elementos
            while (x_reader.Read())
            {
                //Vemos solamente los nodos iniciales
                if (true || x_reader.IsStartElement())
                {
                    switch (x_reader.Name)
                    {
                        case "P":
                            //Setemos el valor de P
                            x_params.P = Convert.FromBase64String(x_reader.ReadString());
                            break;
                        case "G":
                            //Setemos el valor de G
                            x_params.G = Convert.FromBase64String(x_reader.ReadString());
                            break;
                        case "Y":
                            //Setemos el valor de Y
                            x_params.Y =Convert.FromBase64String(x_reader.ReadString());
                            break;
                        case "X":
                            //Seteamos el valor de X
                            x_params.X = Convert.FromBase64String(x_reader.ReadString());
                            break;
                    }
                }
            }
            //Importamos el resultado
            ImportarParametros(x_params);
        }
    }
}
