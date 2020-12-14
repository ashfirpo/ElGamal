using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    public struct ElGamalKeyStruct
    {
        public BigInteger P;
        public BigInteger G;
        public BigInteger Y;
        public BigInteger X;
    }

    public class ElGamalManaged : ElGamal
    {
        private ElGamalKeyStruct key_struct;

        public ElGamalManaged()
        {
            key_struct = new ElGamalKeyStruct();
            key_struct.G = new BigInteger(0);
            key_struct.P = new BigInteger(0);
            key_struct.X = new BigInteger(0);
            key_struct.Y = new BigInteger(0);

            KeySizeValue = 1024;
            LegalKeySizesValue = new KeySizes[] { new KeySizes(384, 1088, 8) };
        }

        public override string SignatureAlgorithm
        {
            get
            {
                return "ElGamal";
            }
        }

        public override string KeyExchangeAlgorithm
        {
            get
            {
                return "ElGamal";
            }
        }


        private void CreateKeyPair(int p_key_strength)
        {
            //Creamos el generador random
            Random x_random_generator = new Random();

            //Creamos un número primo P grande
            key_struct.P = BigInteger.genPseudoPrime(p_key_strength, 16, x_random_generator);

            //Creamos dos números aleatorios, menores a P
            key_struct.X = new BigInteger();
            key_struct.X.genRandomBits(p_key_strength - 1, x_random_generator);
            key_struct.G = new BigInteger();
            key_struct.G.genRandomBits(p_key_strength - 1, x_random_generator);

            //Computa Y
            key_struct.Y = key_struct.G.modPow(key_struct.X, key_struct.P);
        }

        private bool NeedToGenerateKey()
        {
            return key_struct.P == 0 && key_struct.G == 0 && key_struct.Y == 0;
        }

        public ElGamalKeyStruct KeyStruct
        {
            get
            {
                if (NeedToGenerateKey())
                {
                    CreateKeyPair(KeySizeValue);
                }
                return key_struct;
            }
            set
            {
                key_struct = value;
            }
        }

        public override void ImportarParametros(ElGamalParametros p_parameters)
        {
            //Seteamos los valores
            key_struct.P = new BigInteger(p_parameters.P);
            key_struct.G = new BigInteger(p_parameters.G);
            key_struct.Y = new BigInteger(p_parameters.Y);
            if (p_parameters.X != null && p_parameters.X.Length > 0)
            {
                key_struct.X = new BigInteger(p_parameters.X);
            }

            KeySizeValue = key_struct.P.bitCount();
        }

        public override ElGamalParametros ExportarParametros(bool
        p_include_private_params)
        {

            if (NeedToGenerateKey())
            {
                CreateKeyPair(KeySizeValue);
            }

            ElGamalParametros x_params = new ElGamalParametros();
            //Seteamos loa valores públicos de los parámetros
            x_params.P = key_struct.P.getBytes();
            x_params.G = key_struct.G.getBytes();
            x_params.Y = key_struct.Y.getBytes();


            if (p_include_private_params)
            {
                x_params.X = key_struct.X.getBytes();
            }
            else
            {
                //Nos aseguramos de setearlo en cero
                x_params.X = new byte[1];
            }

            return x_params;
        }



        public override byte[] EncriptarData(byte[] p_data)
        {
            if (NeedToGenerateKey())
            {
                //Si no se crearon las claves, primero las crea
                CreateKeyPair(KeySizeValue);
            }
            //Instanciamos y procedemos a encriptar
            ElGamalEncryptor encriptar = new ElGamalEncryptor(key_struct);
            return encriptar.ProcessData(p_data);
        }

        public override byte[] DesencriptarData(byte[] p_data)
        {
            if (NeedToGenerateKey())
            {
                CreateKeyPair(KeySizeValue);
            }
            //Instanciamos y procedemos a desencriptar
            ElGamalDecryptor desencriptar= new ElGamalDecryptor(key_struct);
            return desencriptar.ProcessData(p_data);
        }



        public override byte[] Sign(byte[] p_hashcode)
        {
            throw new System.NotImplementedException();
        }

        public override bool VerifySignature(byte[] p_hashcode, byte[] p_signature)
        {
            throw new System.NotImplementedException();
        }


        protected override void Dispose(bool p_bool)
        {

        }

    }
}
