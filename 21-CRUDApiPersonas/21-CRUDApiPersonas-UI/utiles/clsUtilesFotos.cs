using _21_CRUDApiPersonas_ENTITIES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace _21_CRUDApiPersonas_UI.utiles
{
    public class clsUtilesFotos
    {

        public async Task<Byte[]> ConvertToByteArray(object sender)
        {
            //call this when selecting an image from the picker  
            FileOpenPicker picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".bmp");
            picker.FileTypeFilter.Add(".png");
            picker.FileTypeFilter.Add(".jpg");
            StorageFile file = await picker.PickSingleFileAsync();
            Image imagen = (Image)sender;

            if (file != null)
            {
                // Ensure the stream is disposed once the image is loaded
                using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap
                    BitmapImage bitmapImage = new BitmapImage();

                    await bitmapImage.SetSourceAsync(fileStream);
                    imagen.Source = bitmapImage;
                }
}
            using (var inputStream = await file.OpenSequentialReadAsync())
            {
                var readStream = inputStream.AsStreamForRead();
                byte[] buffer = new byte[readStream.Length];
                await readStream.ReadAsync(buffer, 0, buffer.Length);
                return buffer;
            }

        }

        public async Task<BitmapImage> ConvertoToBitMap(clsPersona persona)
{
    using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
    {
        using (DataWriter writer = new DataWriter(stream.GetOutputStreamAt(0)))
        {
            writer.WriteBytes(persona.Foto);
            await writer.StoreAsync();
        }
        BitmapImage image = new BitmapImage();
        await image.SetSourceAsync(stream);
        return image;
    }
}
    }
}
