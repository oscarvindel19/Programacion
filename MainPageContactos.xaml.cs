using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Examen1
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       
        Models.Conexion Con = new Models.Conexion();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Insertar_Clicked(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                 
                await App.SaveContactos(Con);
            }

           

        }

        public  bool ValidarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(TxtNombres.Text))
            {

                respuesta = false;

            }
            else if (string.IsNullOrEmpty(TxtApellido.Text))
            {
                respuesta = true;
            }
            else if (string.IsNullOrEmpty(TxtEdad.Text))
            {
                respuesta = true;
            }
            else if (string.IsNullOrEmpty(TxtPais.Text))
            {
                respuesta = true;
            }
            else if (string.IsNullOrEmpty(Txtnota.Text))
            {
                respuesta = true;
            }
            else if (string.IsNullOrEmpty(Txtlatitud.Text))
            {
                respuesta = true;
            }
            else if (string.IsNullOrEmpty(Txtlongitud.Text))
            {
                respuesta = true;
            }
            else
            {
                respuesta = true;
                
            }
            return respuesta;




        }




    }


        

        }
    

