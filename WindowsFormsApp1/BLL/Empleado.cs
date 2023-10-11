using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    public class Empleado
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Departamentos { get; set; }
        public string Correo {  get; set; }
        public byte[] FotoEmpleado { get; set; }


    }
}
