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

namespace DevelopmentChallenge.Data.Classes
{
    public class TraductorItaliano : ITraductor
    {

        private readonly Dictionary<string, string> _diccionario = new Dictionary<string, string>()
        {
            { "Circulo", "Cerchio" },
            { "Cuadrado", "Piazza" },
            { "Triangulo", "Triangolo" },
            { "Trapecio", "Trapezio" },

            { "Circulos", "Cerchi" },
            { "Cuadrados", "Piazze" },
            { "Triangulos", "Triangoli" },
            { "Trapecios", "Trapezio" },

            { "msgListaVacia", "Elenco vuoto di forme" },
            { "msgHeader", "Rapporto sulle forme" },
            { "TOTAL", "TOTALE" },
            { "formas", "forme" },
            { "Perimetro", "Perimetro" },
            { "Area", "Zona" }

        };

        public string Traducir(string palabra)
        {
            return _diccionario.ContainsKey(palabra) ? _diccionario[palabra] : palabra;
        }
    }
}
