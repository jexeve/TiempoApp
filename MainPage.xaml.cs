using TiempoApp.Services;

namespace TiempoApp
{
    public partial class MainPage : ContentPage
    {
        public string city;

        public MainPage()
        {
            InitializeComponent();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var result = await ApiService.getTiempo();

            string temperaturaConcatenada = result.hour_hour.hour1.temperature + " " + result.information.temperature;
            string iconName = $"clima{result.hour_hour.hour1.icon}.png";

            LblCiudad.Text = result.locality.name;
            LblTemperatura.Text = temperaturaConcatenada;
            LblPais.Text = result.locality.country;

            // Crear la ruta completa a la imagen en tu proyecto
            var imageSource = ImageSource.FromFile(iconName);

            // Asignar la imagen al control Image
            ImgClimaIcon.Source = imageSource;

        }

    }

}
