using System;

namespace HernandesCornejoTareaClase
{
class Program
{
    static void Main(string[] args)
    {

        cuadrado Icuadrado = new cuadrado("1", "morado", 85);
        Icuadrado.ImprecionC();

        rectangulo IRectangulo = new rectangulo("2", "azul marino", 32, 8);
        IRectangulo.ImprecionR();

        circulo Icirculo = new circulo("3", "castaño", 5.123, 3.14);
        Icirculo.ImprecionC();

        List<Figura> figuras_en_Listas = new List<Figura>();
        foreach(Figura item in figuras_en_Listas)
        {
        item.calculo_de_las_figuas();
        }
        figuras_en_Listas.Add(Icuadrado);
        figuras_en_Listas.Add(IRectangulo);
        figuras_en_Listas.Add(Icirculo);
    }
    }
}