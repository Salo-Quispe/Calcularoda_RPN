using RpnCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        private bool IsDarkMode;
        private Color TextColor;
        private Color ButtonBackgroundColor;
        private Color ButtonTextColor;

        public MainPage()
        {
            InitializeComponent();
            SizeChanged += (sender, args) => portrait.IsVisible = !(landscape.IsVisible = Width > Height);
        }

        private void OnDarkModeToggled(object sender, ToggledEventArgs e)
        {
            // Cambiar el estado del modo oscuro
            IsDarkMode = e.Value;

            // Lógica para cambiar el tema aquí
            if (IsDarkMode)
            {
                // Cambiar a modo oscuro
                BackgroundColor = Color.Black;
                TextColor = Color.White; // Puedes necesitar cambiar el color del texto
                ButtonBackgroundColor = Color.DarkGray; // Color de fondo del botón en modo oscuro
                ButtonTextColor = Color.White; // Color de texto del botón en modo oscuro
                                               // Otros ajustes de estilo para el modo oscuro
            }
            else
            {
                // Cambiar a modo claro
                BackgroundColor = Color.White;
                TextColor = Color.Black; // Puedes necesitar cambiar el color del texto
                ButtonBackgroundColor = Color.LightGray; // Color de fondo del botón en modo claro
                ButtonTextColor = Color.Black; // Color de texto del botón en modo claro
                                               // Restablecer los ajustes de estilo para el modo claro
            }
        }





    }
}
