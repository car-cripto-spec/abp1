using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace abp1
{
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        private void OnRegistrarClicked(object sender, EventArgs e)
        {
            // Guardar datos en Preferences
            Preferences.Set("Nombre", EntryNombre.Text);
            Preferences.Set("Apellido", EntryApellido.Text);
            Preferences.Set("FechaNacimiento", datePickerNacimiento.Date.ToString("yyyy-MM-dd"));
            Preferences.Set("Telefono", EntryTelefono.Text);
            Preferences.Set("Correo", EntryCorreo.Text);
            Preferences.Set("Contrasena", EntryContrasena.Text);
            Preferences.Set("Descripcion", EntryDescripcion.Text);

            DisplayAlert("Registro", "Datos guardados exitosamente.", "OK");
        }
    }
}
