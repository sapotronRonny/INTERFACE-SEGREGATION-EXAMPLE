public class factura : documento{
public string CAI {get;set;}
    public factura (int numero,DateTime fecha): base (numero,fecha){}

    

    

    public override void imprimir()
    {
        Console.WriteLine ($"Imprimiendo la factura {Numero} del dia {Fecha} con CAI {CAI} ");
    }
}