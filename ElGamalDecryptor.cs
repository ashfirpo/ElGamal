using System;
using System.Security.Cryptography;

namespace ElGamal
{
    public class ElGamalDecryptor : ElGamalAbstractCipher
    {
        public ElGamalDecryptor(ElGamalKeyStruct p_struct) : base(p_struct)
        {
            //Seteamos el tamaño del bloque con el tamaño del bloque cifrado
            block_size = ciphertext_blocksize;
        }


        protected override byte[] ProcessDataBlock(byte[] p_block)
        {
            //Extraemos los arrays que representan a A y a B
            byte[] x_a_bytes = new byte[ciphertext_blocksize / 2];
            Array.Copy(p_block, 0, x_a_bytes, 0, x_a_bytes.Length);
            byte[] x_b_bytes = new Byte[ciphertext_blocksize / 2];
            Array.Copy(p_block, x_a_bytes.Length, x_b_bytes, 0, x_b_bytes.Length);
            
            //Creamos A y B a partir de lo extraido en sus arrays de arriba
            BigInteger A = new BigInteger(x_a_bytes);
            BigInteger B = new BigInteger(x_b_bytes);
            
            //Calculamos el valor de M
            BigInteger M = (B *
                A.modPow(key_struct.X, key_struct.P).modInverse(key_struct.P))
                % key_struct.P;

            //Verificamos que tenga la longitud correcta
            byte[] x_m_bytes = M.getBytes();

            if (x_m_bytes.Length < plaintext_blocksize)
            {
                byte[] x_full_result = new byte[plaintext_blocksize];
                Array.Copy(x_m_bytes, 0, x_full_result, plaintext_blocksize - x_m_bytes.Length, x_m_bytes.Length);
                x_m_bytes = x_full_result;
            }
            return x_m_bytes;
        }


        protected override byte[] ProcessFinalDataBlock(byte[] p_final_block)
        {
            if (p_final_block.Length > 0)
            {
                return ProcessDataBlock(p_final_block);
            }
            else
            {
                return new byte[0];
            }
        }
    }
}
