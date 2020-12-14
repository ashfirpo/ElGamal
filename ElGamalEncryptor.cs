using System;

namespace ElGamal
{
    public class ElGamalEncryptor : ElGamalAbstractCipher
    {
        Random random;

        public ElGamalEncryptor(ElGamalKeyStruct p_struct) : base(p_struct)
        {
            random = new Random();
        }


        protected override byte[] ProcessDataBlock(byte[] p_block)
        {
            //Creamos el número aleatorio K
            BigInteger K;
            //Buscamos que sea coprimo con P
            do
            {
                K = new BigInteger();
                K.genRandomBits(key_struct.P.bitCount() - 1, random);
            } while (K.gcd(key_struct.P - 1) != 1);

            //Computamos los valores de A y B
            BigInteger A = key_struct.G.modPow(K, key_struct.P);
            BigInteger B = (key_struct.Y.modPow(K, key_struct.P) * new BigInteger(p_block)) % (key_struct.P);

            //Creamos un array que contenga el cifrado
            byte[] x_result = new byte[ciphertext_blocksize];
            //Copiamos A y B en el array del resultado
            byte[] x_a_bytes = A.getBytes();
            Array.Copy(x_a_bytes, 0, x_result, ciphertext_blocksize / 2 - x_a_bytes.Length, x_a_bytes.Length);
            byte[] x_b_bytes = B.getBytes();
            Array.Copy(x_b_bytes, 0, x_result, ciphertext_blocksize - x_b_bytes.Length, x_b_bytes.Length);
            
            return x_result;
        }


        protected override byte[] ProcessFinalDataBlock(byte[] p_final_block)
        {
            if (p_final_block.Length > 0)
            {
                if (p_final_block.Length < block_size)
                {
                    //Creamos un nuevo bloque del tamaño correspondiente y llenamos el espacio
                    //sobrante con ceros
                    byte[] x_padded = new byte[block_size];
                    Array.Copy(p_final_block, 0, x_padded, 0, p_final_block.Length);
                    return ProcessDataBlock(x_padded);
                }
                else
                {
                    return ProcessDataBlock(p_final_block);
                }
            }
            else
            {
                return new byte[0];
            }
        }

    }
}
