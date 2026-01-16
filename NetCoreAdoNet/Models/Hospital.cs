using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Models
{
    public class Hospital
    {
        public int IdHos { get; set; }
        public string Nombre { get; set; }
        public string Direccion  { get; set; }
        public string Telefono  { get; set; }
        public int NumCamas  { get; set; }
    }
}
