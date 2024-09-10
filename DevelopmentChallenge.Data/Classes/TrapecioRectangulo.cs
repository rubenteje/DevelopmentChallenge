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

namespace DevelopmentChallenge.Data.Classes
{
    public class TrapecioRectangulo : IFormaGeometrica
    {
        private readonly decimal _basePrincipal;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _ladoOblicuo;

        public TrapecioRectangulo(decimal basePrincipal, decimal baseMenor, decimal altura, decimal ladoOblicuo)
        {
            _basePrincipal = basePrincipal;
            _baseMenor = baseMenor;
            _altura = altura;
            _ladoOblicuo = ladoOblicuo;
        }
        public decimal CalcularArea()
        {
            return ((decimal)((_basePrincipal + _baseMenor) * _altura) / 2);
        }
        public decimal CalcularPerimetro()
        {
            return _basePrincipal + _baseMenor + _ladoOblicuo + _altura;
        }

        public string ObtenerNombre()
        {
            return "Trapecio";
        }
    }
}
