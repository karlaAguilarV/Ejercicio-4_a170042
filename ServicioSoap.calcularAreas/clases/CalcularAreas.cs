using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioSoap.calcularAreas.clases
{
    public class CalcularAreas
    {
        #region propiedades
        public decimal dato1 { get; set; }
        public decimal dato2 { get; set; }
        
        #endregion
        public decimal Acuadrado()
        {
            return dato1 * dato1;
        }
        public decimal Atriangulo()
        {
            return (dato1 * dato2) / 2;
        }
        public string Acirculo(double dato1)
        {
            double pi = 3.1416;
            return ((dato1 * dato1) *pi).ToString();
        }

    }
}