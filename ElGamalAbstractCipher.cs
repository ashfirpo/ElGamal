using System;
using System.Collections.Concurrent;
using System.IO;
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
            //Setemos las keys
            key_struct = p_key_struct;

            //Calculamos el tamaño de los bloques
            plaintext_blocksize = (p_key_struct.P.bitCount() - 1) / 8;
            ciphertext_blocksize = ((p_key_struct.P.bitCount() + 7) / 8) * 2;

            //Seteamos el tamaño por defecto del bloque a encriptar
            block_size = plaintext_blocksize;

        }

        protected abstract byte[] ProcessDataBlock(byte[] p_block);
        protected abstract byte[] ProcessFinalDataBlock(byte[] p_final_block);



        public byte[] ProcessData(byte[] p_data)
        {
            MemoryStream x_stream = new MemoryStream();
            //Calculamos la cantidad de bloques completos que necesitamos
            int x_complete_blocks = p_data.Length / block_size;


            Console.WriteLine("Procesando " + x_complete_blocks + 1 + " bloques...");
            ConcurrentDictionary<int, byte[]> resultados = new ConcurrentDictionary<int, byte[]>();
            //Procesamos cada uno de los bloques
            Parallel.For(0, x_complete_blocks, i =>
            {
                byte[] x_block = new byte[block_size];
                Array.Copy(p_data, i * block_size, x_block, 0, block_size);
                byte[] x_result = ProcessDataBlock(x_block);
                resultados.TryAdd(i, x_result);
            });

            //Unimos todos los resultados en un mismo espacio de memoria
            foreach (var res in resultados)
            {
                x_stream.Write(res.Value, 0, res.Value.Length);
            }

            //Calculamos el tamaño del ultimo bloque (que es menor al tamaño completo) y lo procesamos
            byte[] x_final_block = new Byte[p_data.Length - (x_complete_blocks * block_size)];
            Array.Copy(p_data, (x_complete_blocks) * block_size, x_final_block, 0, x_final_block.Length);

            byte[] x_final_result = ProcessFinalDataBlock(x_final_block);

            //Escribimos el resultado del último bloque procesado junto al resto
            x_stream.Write(x_final_result, 0, x_final_result.Length);

            //Retornamos todo procesado
            return x_stream.ToArray();
        }
    }
}
