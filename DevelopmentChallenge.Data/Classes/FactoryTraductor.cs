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

using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class FactoryTraductor
    {
        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        #endregion
        public ITraductor CrearTraductor(int idioma)
        {
            switch (idioma)
            {
                case 1:
                    return new TraductorEspañol();
                case 2:
                    return new TraductorIngles();
                case 3:
                    return new TraductorItaliano();
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
            };
        }
    }
}
