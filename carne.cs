//usamos la clase carne 
class carne:menuextra
{
    public carne(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio => base.CalcularTotalPrecio + 0.30;
}