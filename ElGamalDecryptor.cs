using System;
using System.Security.Cryptography;

namespace ElGamal
{
    public class ElGamalDecryptor : ElGamalAbstractCipher
    {
        public ElGamalDecryptor(ElGamalKeyStruct p_struct) : base(p_struct)
        {
            // set the default block size to be ciphertext
            block_size = ciphertext_blocksize;
        }


        protected override byte[] ProcessDataBlock(byte[] p_block)
        {
            // extract the byte arrays that represent A and B
            byte[] x_a_bytes = new byte[ciphertext_blocksize / 2];
            Array.Copy(p_block, 0, x_a_bytes, 0, x_a_bytes.Length);
            byte[] x_b_bytes = new Byte[ciphertext_blocksize / 2];
            Array.Copy(p_block, x_a_bytes.Length, x_b_bytes, 0, x_b_bytes.Length);
            // create big integers from the byte arrays
            BigInteger A = new BigInteger(x_a_bytes);
            BigInteger B = new BigInteger(x_b_bytes);
            // calculate the value M
            BigInteger M = (B *
                A.modPow(key_struct.X, key_struct.P).modInverse(key_struct.P))
                % key_struct.P;
            // return the result - take care to ensure that we create
            // a result which is the correct length
            byte[] x_m_bytes = M.getBytes();
            // we may end up with results which are short some leading
            // bytes - add these are required
            if (x_m_bytes.Length < plaintext_blocksize)
            {
                byte[] x_full_result = new byte[plaintext_blocksize];
                Array.Copy(x_m_bytes, 0, x_full_result,
                    plaintext_blocksize - x_m_bytes.Length, x_m_bytes.Length);
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
