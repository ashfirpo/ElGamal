using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElGamal
{
    public abstract class ElGamalAbstractCipher
    {
        protected int block_size;
        protected int plaintext_blocksize;
        protected int ciphertext_blocksize;
        protected ElGamalKeyStruct key_struct;

        public ElGamalAbstractCipher(ElGamalKeyStruct p_key_struct)
        {
            // set the key details
            key_struct = p_key_struct;

            // calculate the blocksizes
            plaintext_blocksize = (p_key_struct.P.bitCount() - 1) / 8;
            ciphertext_blocksize = ((p_key_struct.P.bitCount() + 7) / 8) * 2;

            // set the default block for plaintext, which is suitable for encryption
            block_size = plaintext_blocksize;
        }

        protected abstract byte[] ProcessDataBlock(byte[] p_block);
        protected abstract byte[] ProcessFinalDataBlock(byte[] p_final_block);



        public byte[] ProcessData(byte[] p_data)
        {

            // create a stream backed by a memory array
            MemoryStream x_stream = new MemoryStream();
            // determine how many complete blocks there are
            int x_complete_blocks = p_data.Length / block_size;

            // create an array which will hold a block
            /*byte[] x_block = new Byte[block_size];

            // run through and process the complete blocks
            int i = 0;
            
            for (; i < x_complete_blocks; i++)
            {
                // copy the block and create the big integer
                Array.Copy(p_data, i * block_size, x_block, 0, block_size);
                // process the block
                byte[] x_result = ProcessDataBlock(x_block);
                // write the processed data into the stream
                x_stream.Write(x_result, 0, x_result.Length);
            }*/


            ConcurrentDictionary<int, byte[]> resultados = new ConcurrentDictionary<int, byte[]>();
            Parallel.For(0, x_complete_blocks, i =>
            {
                byte[] x_block = new byte[block_size];
                Array.Copy(p_data, i * block_size, x_block, 0, block_size);
                byte[] x_result = ProcessDataBlock(x_block);
                resultados.TryAdd(i, x_result);
            });

            foreach (var res in resultados)
            {
                x_stream.Write(res.Value, 0, res.Value.Length);
            }

            byte[] x_final_block = new Byte[p_data.Length - (x_complete_blocks * block_size)];
            Array.Copy(p_data, (x_complete_blocks) * block_size, x_final_block, 0, x_final_block.Length);

             // process the final block
             byte[] x_final_result = ProcessFinalDataBlock(x_final_block);

            // write the final data bytes into the stream
            x_stream.Write(x_final_result, 0, x_final_result.Length);

            // return the contents of the stream as a byte array
            return x_stream.ToArray();
        }
    }
}
