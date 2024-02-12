using ejecicio2;
using System;


public class Automovil : Vehiculo
{
    private int puertas;

    
    public Automovil(string marca, string modelo, int puertas) : base(marca, modelo)
    {
        this.puertas = puertas;
    }

  
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Número de puertas: {puertas}");
    }
}


public class Garaje
{
    private Vehiculo vehiculo;

    public Garaje(Vehiculo vehiculo)
    {
        this.vehiculo = vehiculo;
    }

 
    public void MostrarVehiculoEnGaraje()
    {
        Console.WriteLine("Vehículo en el garaje:");
        vehiculo.MostrarInformacion();
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Automovil miAutomovil = new Automovil("Toyota", "Corolla", 4);

        
        Vehiculo.MensajeGenerico();

        miAutomovil.MostrarInformacion();

       
        Garaje miGaraje = new Garaje(miAutomovil);

      
        miGaraje.MostrarVehiculoEnGaraje();
    }
}