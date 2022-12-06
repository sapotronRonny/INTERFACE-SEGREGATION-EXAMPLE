internal class Program
{
    private static void Main(string[] args)
    {
        factura factura = new factura (1234, DateTime.Now);
        factura.CAI = "23456";

        facturaelectronica facturae = new facturaelectronica (1235, DateTime.Now);
        facturae.CAE = "3242335";

        facturae.imprimir ();
        facturae.enviarporemail ();
        factura.imprimir ();
        //factura.evniarporemail (); //No se puede enviar por email

        Console.ReadKey ();
    }
}