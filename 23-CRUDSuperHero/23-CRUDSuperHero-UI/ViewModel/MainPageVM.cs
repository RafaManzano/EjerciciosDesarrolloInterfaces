using _23_CRUDSuperHero_BL.Handlers;
using _23_CRUDSuperHero_BL.Lists;
using _23_CRUDSuperHero_ENTITIES;
using _23_CRUDSuperHero_UI.Utiles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;

namespace _23_CRUDSuperHero_UI.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private ObservableCollection<clsCompanhia> companhias;
        private ObservableCollection<clsSuperhero> superheroes;
        private clsCompanhia companhiaSeleccionada;
        private clsSuperhero superheroSeleccionado;
        private String textoError;
        private String textoBuscado;
        private BitmapImage imagen;
        private DelegateCommand eliminarComando;
        private DelegateCommand filtrarComando;
        private DelegateCommand nuevoComando;
        private DelegateCommand recargarComando;
        private DelegateCommand guardarComando;
        private clsListadoCompanhiaBL clist = new clsListadoCompanhiaBL();
        private clsListadoSuperheroBL slist = new clsListadoSuperheroBL();
        private clsManejadorasBL smanejadoras = new clsManejadorasBL();

        public MainPageVM()
        {
            this.companhias = new ObservableCollection<clsCompanhia>(clist.listadoCompanhias());
            eliminarComando = new DelegateCommand(Eliminar, () => superheroSeleccionado != null );
            filtrarComando = new DelegateCommand(Filtrar, () => companhiaSeleccionada != null);
            recargarComando = new DelegateCommand(Recargar);
            nuevoComando = new DelegateCommand(Nuevo);
            guardarComando = new DelegateCommand(Guardar, () => superheroSeleccionado != null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string TextoError
        {
            get
            {
                return textoError;
            }

            set
            {
                textoError = value;
            }
        }

        public ObservableCollection<clsCompanhia> Companhias
        {
            get
            {
                return companhias;
            }
        }

        public ObservableCollection<clsSuperhero> Superheroes
        {
            get
            {
                return superheroes;
            }
        }

        public clsSuperhero SuperheroSeleccionado
        {
            get
            {
                return superheroSeleccionado;
            }

            set
            {
                superheroSeleccionado = value;
                eliminarComando.RaiseCanExecuteChanged();
                eliminarComando.CanExecute(superheroSeleccionado);
                guardarComando.RaiseCanExecuteChanged();
                guardarComando.CanExecute(superheroSeleccionado);
                NotifyPropertyChanged("SuperheroSeleccionado");
            }
        }

        public BitmapImage Imagen
        {
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }


        public clsCompanhia CompanhiaSeleccionada
        {
            get
            {
                return companhiaSeleccionada;
            }

            set
            {
                companhiaSeleccionada = value;
                superheroes = new ObservableCollection<clsSuperhero>(slist.listadoSuperheroesporCompanhia(Convert.ToInt16(companhiaSeleccionada.ID)));
                filtrarComando.RaiseCanExecuteChanged();
                filtrarComando.CanExecute(companhiaSeleccionada);
                NotifyPropertyChanged("Superheroes");
            }
        }

        public DelegateCommand EliminarComando
        {
            get
            {
                return eliminarComando;
            }
        }

        
        public DelegateCommand FiltrarComando
        {
            get
            {
                return filtrarComando;
            }
        }
        

        public async void Eliminar()
        {
            if(superheroSeleccionado.Nombre != "" && superheroSeleccionado.Apellidos != "" || superheroSeleccionado.Apodo != "")
            {
                ContentDialog subscribeDialog = new ContentDialog
                {
                    Title = "¿Estas seguro que quiere eliminar?",
                    PrimaryButtonText = "Aceptar",
                    SecondaryButtonText = "Cancelar",
                    DefaultButton = ContentDialogButton.Secondary
                };

                ContentDialogResult result = await subscribeDialog.ShowAsync();
                if (result == ContentDialogResult.Primary)
                {

                    textoError = "";
                    NotifyPropertyChanged("TextoError");
                    smanejadoras.borrarPersona(Convert.ToInt16(superheroSeleccionado.ID));
                    Recargar();
                    //NotifyPropertyChanged("Superheroes");
                }
            }
            else
            {
                textoError = "No se puede eliminar de la BBDD porque no se han escrito todos los campos requeridos (NOMBRE, APELLIDOS, APODO Y COMPANHIA)";
                NotifyPropertyChanged("TextoError");
            }
            
        }

        
        public void Filtrar()
        {
            if (String.IsNullOrWhiteSpace(TextoBuscado))
            {
                superheroes = new ObservableCollection<clsSuperhero>(slist.listadoSuperheroesporCompanhia(Convert.ToInt16(companhiaSeleccionada.ID)));
                NotifyPropertyChanged("Superheroes");

            }
            else
            {
                //Esto no es lo mas correcto puesto que se llama a la BBDD cada vez que se usa
                ObservableCollection<clsSuperhero> list = new ObservableCollection<clsSuperhero>(slist.listadoSuperheroesporCompanhia(Convert.ToInt16(companhiaSeleccionada.ID)).FindAll(a => a.Apodo.Contains(TextoBuscado)).ToList<clsSuperhero>());
                //ListadoPersonaFiltrada = ListadoPersonaFiltrada.ToList().FindAll(a => a.Nombre.Contains(TextoBuscado));
                superheroes = list;
                NotifyPropertyChanged("Superheroes");
            }
        }

        public String TextoBuscado
        {
            get
            {
                return textoBuscado;
            }

            set
            {
                this.textoBuscado = value;
                filtrarComando.Execute(null);
                filtrarComando.RaiseCanExecuteChanged();
                NotifyPropertyChanged("Superheroes");
            }
        }
        

        public DelegateCommand NuevoComando
        {
            get
            {
                return nuevoComando;
            }
        }

        public void Nuevo()
        {
            superheroSeleccionado = new clsSuperhero();
            eliminarComando.RaiseCanExecuteChanged();
            eliminarComando.CanExecute(superheroSeleccionado);
            guardarComando.RaiseCanExecuteChanged();
            guardarComando.CanExecute(superheroSeleccionado);
            NotifyPropertyChanged("SuperheroSeleccionado");
        }

        public DelegateCommand RecargarComando
        {
            get
            {
                return recargarComando;
            }
        }

        public void Recargar()
        {
            superheroes = new ObservableCollection<clsSuperhero>(new List<clsSuperhero>());
            NotifyPropertyChanged("Superheroes");
        }

        public DelegateCommand GuardarComando
        {
            get
            {
                return guardarComando;
            }
        }

        public async void Guardar()
        {
            if (superheroSeleccionado.Nombre != "" && superheroSeleccionado.Apellidos != "" || superheroSeleccionado.Apodo != "")
            {

                if (smanejadoras.estoyenBBDD(superheroSeleccionado))
                {
                    ContentDialog subscribeDialog = new ContentDialog
                    {
                        Title = "Actualizado correctamente en la BBDD",
                        PrimaryButtonText = "Perfecto",
                        DefaultButton = ContentDialogButton.Primary
                    };
                    ContentDialogResult result = await subscribeDialog.ShowAsync();
                    textoError = "";
                    NotifyPropertyChanged("TextoError");
                    smanejadoras.actualizarSuperhero(superheroSeleccionado);
                    Recargar();
                }
                else
                {
                    ContentDialog subscribeDialog = new ContentDialog
                    {
                        Title = "Creado correctamente en la BBDD",
                        PrimaryButtonText = "Perfecto",
                        DefaultButton = ContentDialogButton.Primary
                    };
                    ContentDialogResult result = await subscribeDialog.ShowAsync();
                    textoError = "";
                    NotifyPropertyChanged("TextoError");
                    smanejadoras.crearSuperhero(superheroSeleccionado);
                    Recargar();
                }
            }
            else
            {
                textoError = "No se puede guardar en la BBDD porque no se han escrito todos los campos requeridos (NOMBRE, APELLIDOS, APODO Y COMPANHIA)";
                NotifyPropertyChanged("TextoError");
            }
        }

        /// <summary>
        /// Comentario: Este evento nos permite abrir un selector de archivos que admite
        /// los siguientes formatos de imagen: png, jpg, jpge o bmp. Al elegir una imagen
        /// de los archivos se colocará en nuestra etiqueta imagen del tipo Image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void PersonPicture01_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PersonPicture imagen = (PersonPicture)sender;

            if (superheroSeleccionado != null && superheroSeleccionado.Foto != null && superheroSeleccionado.Foto.Length != 0)//Si el heroe seleccionado no es null y ya tiene una imagen
            {
                // Set the image source to the selected bitmap
                BitmapImage bitmapImage = new BitmapImage();

                bitmapImage = await clsConvertirFotos.byteArrayToBitmapAsync(superheroSeleccionado.Foto);
                imagen.ProfilePicture = bitmapImage;
            }
            else//Sino sacamos una imagen del selector de archivos
            {
                var fileOpenPicker = new FileOpenPicker();
                fileOpenPicker.ViewMode = PickerViewMode.Thumbnail;
                fileOpenPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
                fileOpenPicker.FileTypeFilter.Add(".png");
                fileOpenPicker.FileTypeFilter.Add(".jpg");
                fileOpenPicker.FileTypeFilter.Add(".jpeg");
                fileOpenPicker.FileTypeFilter.Add(".bmp");

                var storageFile = await fileOpenPicker.PickSingleFileAsync();

                if (storageFile != null)
                {
                    // Ensure the stream is disposed once the image is loaded
                    using (IRandomAccessStream fileStream = await storageFile.OpenAsync(Windows.Storage.FileAccessMode.Read))
                    {
                        // Set the image source to the selected bitmap
                        BitmapImage bitmapImage = new BitmapImage();

                        await bitmapImage.SetSourceAsync(fileStream);
                        imagen.ProfilePicture = bitmapImage;
                    }

                    //Almacenamos la imagen en la persona seleccionada
                    superheroSeleccionado.Foto = await clsConvertirFotos.fileToByteArrayAsync(storageFile);
                    NotifyPropertyChanged("SuperheroeSeleccionado");
                }

            }
        }

        /// <summary>
        /// Comentario: Este método nos permite cargar la imagen de una persona al seleccionarla
        /// en la aplicación.
        /// </summary>
        public void cargarImagen()
        {
            using (InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream())
            {
                // Writes the image byte array in an InMemoryRandomAccessStream
                // that is needed to set the source of BitmapImage.
                using (DataWriter writer = new DataWriter(ms.GetOutputStreamAt(0)))
                {
                    writer.WriteBytes((byte[])superheroSeleccionado.Foto);

                    // The GetResults here forces to wait until the operation completes
                    // (i.e., it is executed synchronously), so this call can block the UI.
                    writer.StoreAsync().GetResults();
                }

                var image = new BitmapImage();
                image.SetSource(ms);
                imagen = image;
            }
            NotifyPropertyChanged("Imagen");
        }
    }
}
