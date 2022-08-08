class SinChile:menuextra
{
    public SinChile(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio => base.CalcularTotalPrecio + 0.00;
}