using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests

    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>();

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Castellano);

            //Assert
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", result.ToString());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {            
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>();

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Ingles);

            //Assert
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", result.ToString());

        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {            
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>() { new Cuadrado(5) };

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Castellano);

            //Assert
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", result.ToString());
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {            
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>() {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Ingles);

            //Assert
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", result.ToString());
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>() {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Ingles);

            //Assert
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                result.ToString());
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>() {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Castellano);

            //Assert
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                result.ToString());
        }

        /***/

        [TestCase]
        public void TestResumenListaVacia_IdiomaItaliano()
        {
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>();

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Italiano);

            //Assert
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>", result.ToString());
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>() { new TrapecioRectangulo(10, 6, 5, 7) };

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Castellano);

            //Assert
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 40 | Perimetro 28 <br/>TOTAL:<br/>1 formas Perimetro 28 Area 40", result.ToString());
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosEnIngles()
        {
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>() {
                new TrapecioRectangulo(10, 6, 5, 7),
                new TrapecioRectangulo(8, 4, 3, 5),
                new TrapecioRectangulo(12, 7, 6, 8)
            };

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Ingles);

            //Assert
            Assert.AreEqual("<h1>Shapes report</h1>3 Trapezes | Area 115 | Perimeter 81 <br/>TOTAL:<br/>3 shapes Perimeter 81 Area 115", result.ToString());
        }

        [TestCase]
        public void TestResumenListaConTodosLasFormasEnItaliano()
        {
            //Arrenge
            var factoryTraductor = new FactoryTraductor();
            var report = new Reporte(factoryTraductor);
            var formas = new List<IFormaGeometrica>() {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new TrapecioRectangulo(10, 6, 5, 7),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new TrapecioRectangulo(8, 4, 3, 5),                
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new TrapecioRectangulo(12, 7, 6, 8)
            };

            //Act
            var result = report.Imprimir(formas, FactoryTraductor.Italiano);

            //Assert
            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Piazze | Zona 29 | Perimetro 28 <br/>2 Cerchi | Zona 13,01 | Perimetro 18,06 <br/>3 Triangoli | Zona 49,64 | Perimetro 51,6 <br/>3 Trapezio | Zona 115 | Perimetro 81 <br/>TOTALE:<br/>10 forme Perimetro 178,66 Zona 206,65",
                result.ToString());
        }
    }
}
