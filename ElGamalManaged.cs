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
            // create the random number generator
            Random x_random_generator = new Random();

            // create the large prime number, P
            key_struct.P = BigInteger.genPseudoPrime(p_key_strength,
                16, x_random_generator);

            // create the two random numbers, which are smaller than P
            key_struct.X = new BigInteger();
            key_struct.X.genRandomBits(p_key_strength - 1, x_random_generator);
            key_struct.G = new BigInteger();
            key_struct.G.genRandomBits(p_key_strength - 1, x_random_generator);

            // compute Y
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
            // obtain the  big integer values from the byte parameter values
            key_struct.P = new BigInteger(p_parameters.P);
            key_struct.G = new BigInteger(p_parameters.G);
            key_struct.Y = new BigInteger(p_parameters.Y);
            if (p_parameters.X != null && p_parameters.X.Length > 0)
            {
                key_struct.X = new BigInteger(p_parameters.X);
            }
            // set the length of the key based on the import
            KeySizeValue = key_struct.P.bitCount();
        }

        public override ElGamalParametros ExportarParametros(bool
        p_include_private_params)
        {

            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }

            // create the parameter set
            ElGamalParametros x_params = new ElGamalParametros();
            // set the public values of the parameters
            x_params.P = key_struct.P.getBytes();
            x_params.G = key_struct.G.getBytes();
            x_params.Y = key_struct.Y.getBytes();

            // if required, include the private value, X
            if (p_include_private_params)
            {
                x_params.X = key_struct.X.getBytes();
            }
            else
            {
                // ensure that we zero the value
                x_params.X = new byte[1];
            }
            // return the parameter set
            return x_params;
        }



        public override byte[] EncriptarData(byte[] p_data)
        {
            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }
            // encrypt the data
            ElGamalEncryptor x_enc = new ElGamalEncryptor(key_struct);
            return x_enc.ProcessData(p_data);
        }

        public override byte[] DesencriptarData(byte[] p_data)
        {
            if (NeedToGenerateKey())
            {
                // we need to create a new key before we can export 
                CreateKeyPair(KeySizeValue);
            }
            // encrypt the data
            ElGamalDecryptor x_enc = new ElGamalDecryptor(key_struct);
            return x_enc.ProcessData(p_data);
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
            // do nothing - no unmanaged resources to release
        }

    }
}
