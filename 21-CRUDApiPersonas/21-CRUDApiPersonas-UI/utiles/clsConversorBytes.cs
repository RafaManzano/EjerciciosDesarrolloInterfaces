using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace _21_CRUDApiPersonas_UI.utiles
{
    public class clsConversorBytes
    {
        /// <summary>
        /// Convierte un array de bytes en BitmapImage.
        /// El array de bytes debe ser una imagen.
        /// </summary>
        /// <param name="imagenEnBytes">El array de bytes que contiene los datos de una imagen.</param>
        /// <returns>El Task que contendrá el BitmapImage.</returns>
        public async Task<BitmapImage> ArrayBytesToBitmapImage(byte[] imagenEnBytes)
        {
            //Crea un nuevo stream de salida de acceso aleatorio.
            using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                //Crea un nuevo writer a partir del stream anterior.
                using (DataWriter writer = new DataWriter(stream.GetOutputStreamAt(0)))
                {
                    //Escribe el aray de bytes en el stream con el writer.
                    writer.WriteBytes(imagenEnBytes);

                    //Confirma los datos y los almacena en el stream.
                    await writer.StoreAsync();
                }

                //Crea el objeto BitmapImage que se devolverá.
                var image = new BitmapImage();

                //Establece la imagen a partir de la fuente de datos, que será el stream definido anteriormente y cargado con el array de bytes.
                await image.SetSourceAsync(stream);

                return image;
            }
        }

        /// <summary>
        /// Convierte un StorageFile en un array de bytes.
        /// </summary>
        /// <param name="file">El StorageFile a convertir.</param>
        /// <returns>El Task que contendrá el array de bytes convertido.</returns>
        public async Task<Byte[]> StorageFileToByteArray(StorageFile file)
        {
            //Crea un flujo de entrada sobre el StorageFile dado.
            using (var inputStream = await file.OpenSequentialReadAsync())
            {
                var readStream = inputStream.AsStreamForRead();

                //Crea un array de bytes con el tamaño del stream de lectura.
                var byteArray = new byte[readStream.Length];

                //Lee la secuencia de bytes del readStream (creo?) y lo va guardando en el array byteArray definido arriba.
                await readStream.ReadAsync(byteArray, 0, byteArray.Length);

                return byteArray;
            }
        }
    }
}
