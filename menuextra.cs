class menuextra : OrdenBase
{
    protected OrdenBase orden;

    public menuextra (OrdenBase orden)
    {
        this.orden = orden;
    }
    public virtual double CalcularTotalPrecio
    {
        get
        {
            Console.WriteLine("Se calcula desde el  decorador");
            return orden.CalcularTotalPrecio;
        }
    }
}