class rectangulo:Figura
{
public int alturarectangulo, baserectangulo;
public rectangulo(string FiNombre,string FiColor, int alturarectangulo, int baserectangulo):base(FiNombre, FiColor)
    {
        this.alturarectangulo = alturarectangulo;
        this.baserectangulo = baserectangulo;
    }
    
public void ImprecionR()
    {
        Console.WriteLine("numero de la figura");
        Console.WriteLine(FiNombre);
        Console.WriteLine("color de la figura");
        Console.WriteLine(FiColor);
    }
public override void calculo_de_las_figuas()
    {
        int RectanguloA;
        RectanguloA= baserectangulo*alturarectangulo;
        Console.WriteLine("area");
        Console.WriteLine(RectanguloA);
    }
    
}