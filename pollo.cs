class pollo:menuextra
{
    public pollo(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio => base.CalcularTotalPrecio + 0.50;
}