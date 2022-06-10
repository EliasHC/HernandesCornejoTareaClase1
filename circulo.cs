class circulo:Figura
{
public double PIC,RadioCirculo;

public circulo(string FiNombre,string FiColor, double RadioCirculo, double PIC):base(FiNombre, FiColor)
    {
        this.RadioCirculo = RadioCirculo;
        this.PIC = PIC;
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
        double AreaC;
        double RadioCirculoElevado;
        RadioCirculoElevado= Math.Pow(RadioCirculo, 2);
        AreaC= RadioCirculoElevado*PIC;
        Console.WriteLine("area del circulo");
        Console.WriteLine(AreaC);
    }
}