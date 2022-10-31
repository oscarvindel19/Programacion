using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Examen1.Models
{
    public class Content_Page
    {
        [PrimaryKey,AutoIncrement ]
        public int Edad { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Pais { get; set; }
        public string Nota { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }





    }
}
