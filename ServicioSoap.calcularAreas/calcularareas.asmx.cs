using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServicioSoap.calcularAreas.clases;

namespace ServicioSoap.calcularAreas
{
    /// <summary>
    /// Descripción breve de calcularareas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class calcularareas : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod(Description = "Este metodo calcula el area de un cuadrado")]
        public decimal Areacuadrado(int lado)
        {
            CalcularAreas calcular = new CalcularAreas();
            calcular.dato1 = lado;
            calcular.Acuadrado();
            return calcular.Acuadrado();
        }

        [WebMethod(Description = "Este metodo calcula el area de un triangulo")]
        public decimal Areatriangulo(decimal Base, decimal Altura)
        {
            CalcularAreas calcular = new CalcularAreas();
            calcular.dato1 = Base;
            calcular.dato2 = Altura;
            calcular.Atriangulo();
            return calcular.Atriangulo();

        }
        [WebMethod(Description = "Este metodo calcula el area de un circulo")]
        public string Acirculo(double radio)
        {
            CalcularAreas calcular = new CalcularAreas();
            return calcular.Acirculo(radio).ToString();

        }
    }
}
