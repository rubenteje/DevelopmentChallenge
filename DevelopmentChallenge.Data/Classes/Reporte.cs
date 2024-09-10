/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class Reporte : IReporte
    {
        private readonly FactoryTraductor _factoryTraductor;
        public Reporte(FactoryTraductor factoryTraductor)
        {
            _factoryTraductor = factoryTraductor;
        }

        public string Imprimir(List<IFormaGeometrica> formas, int idioma)
        {
            ITraductor traductor = _factoryTraductor.CrearTraductor(idioma);

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{traductor.Traducir("msgListaVacia")}!</h1>");
            }
            else
            {
                //Header
                sb.Append($"<h1>{traductor.Traducir("msgHeader")}</h1>");


                //Details
                int totalFormas = 0;
                decimal totalArea = 0;
                decimal totalPerimetro = 0;

                var grupoFormas = formas.GroupBy(f => f.ObtenerNombre());

                foreach (var grupo in grupoFormas)
                {
                    int cantidad = grupo.Count();
                    decimal areaTotal = grupo.Sum(f => f.CalcularArea());
                    decimal perimetroTotal = grupo.Sum(f => f.CalcularPerimetro());

                    totalFormas += cantidad;
                    totalArea += areaTotal;
                    totalPerimetro += perimetroTotal;


                    sb.Append(ObtenerLinea(cantidad, areaTotal, perimetroTotal, grupo.First()?.ObtenerNombre(), traductor));
                }

                //FOOTER
                sb.Append($"{traductor.Traducir("TOTAL")}:<br/>");
                sb.Append($"{totalFormas} {traductor.Traducir("formas")} ");
                sb.Append($"{traductor.Traducir("Perimetro")} {totalPerimetro.ToString("#.##")} ");
                sb.Append($"{traductor.Traducir("Area")} {totalArea.ToString("#.##")}");

            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, ITraductor idioma)
        {
            if (cantidad > 0)
            {
                string key = (cantidad > 1) ? tipo + "s" : tipo;
                return $"{cantidad} {idioma.Traducir(key)} | {idioma.Traducir("Area")} {area:#.##} | {idioma.Traducir("Perimetro")} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
