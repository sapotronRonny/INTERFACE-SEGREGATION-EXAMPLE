public class facturaelectronica:documento, emaileable{
    public facturaelectronica (int numero,DateTime fecha):base (numero, fecha){

    }

    public string CAE {get;set;}

    public void enviarporemail()
    {
        Console.WriteLine ($"Enviando por email la factura {Numero} del dia {Fecha} con CAE {CAE} ");
    }

    public override void imprimir()
    {
        Console.WriteLine ($"Imprimiendo la factura electronica {Numero} del dia {Fecha} con CAE {CAE} ");
    }
}