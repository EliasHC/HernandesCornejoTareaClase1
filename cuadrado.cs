class cuadrado:Figura
{
public int ladosC;
public cuadrado(string FiNombre,string FiColor, int lasdosC):base(FiNombre, FiColor)
    {
        this.ladosC = lasdosC;
    }
public void ImprecionC()
    {
        Console.WriteLine("numero de la figura");
        Console.WriteLine(FiNombre);
        Console.WriteLine("color de la figura");
        Console.WriteLine(FiColor);
    }
public override void calculo_de_las_figuas()

    {
        int AreaC;
        AreaC= ladosC*ladosC;
        Console.WriteLine("area");
        Console.WriteLine(AreaC);
    }
} 