# FiguresWF

  public override double Square()
{
      return Base * Height / 2;
}

 public override double Perimetr
{
      get { return Side1 + Side2 + Side3; }
}//расчет периметра и площади треугольник



  public override double Square()
{
    return (Base1 + Base2) * Height / 2;
}

public override double Perimetr
{
    get { return Base1 + Base2 + Side1 + Side2; }
}//расчет периметра и площади трапеции


public override double Square()
{
    return Side * Side;
}

public override double Perimetr
{
    get { return 4 * Side; }
}//расчет периметра и площади квадрата


 public override double Square()
 {
     return Length * Width;
 }

 public override double Perimetr
 {
     get { return 2 * (Length + Width); }
 }//расчет периметра и площади прямоугольника


  public override double Square()
 {
     return Math.PI * Radius * Radius;
 }

 public override double Perimetr
 {
     get { return 2 * Math.PI * Radius; }
 }//расчет периметра и площади квадрата
