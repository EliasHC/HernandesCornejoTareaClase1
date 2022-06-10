using System;
abstract class Figura
{
public abstract void calculo_de_las_figuas();
public string FiNombre, FiColor;
public Figura(string FiNombre,string FiColor)
    {this.FiNombre = FiNombre;this.FiColor = FiColor;}
}