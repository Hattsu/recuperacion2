
class Chile:menuextra
{
    public Chile(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio => base.CalcularTotalPrecio + 0.55;
}