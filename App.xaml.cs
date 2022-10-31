using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace Examen1
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
 




















        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        internal static Task SaveContactos(object edad)
        {
            throw new NotImplementedException();
        }
    }
}
