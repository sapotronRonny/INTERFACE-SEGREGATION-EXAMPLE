public abstract class documento:imprimible {

public DateTime Fecha {get;set;}
public int Numero {get;set;}
    public documento (int numero,DateTime fecha){
        Numero = numero;
        Fecha = fecha;
    }

    public abstract void imprimir ();
    
}
