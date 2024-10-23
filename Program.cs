namespace Gestion_de_viajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

         float costoPorKilometro,peaje;
         uint kilometrajeMinimo, distanciaRecorida,cont=0;
         string dominio;

            CViaje viaje, viajeMax=null;

            Console.WriteLine("Ingrese El costo por kilometro");
            costoPorKilometro = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el kilometraje minimo");
            kilometrajeMinimo = uint.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Dominio del Auto");
            dominio = Console.ReadLine().ToUpper();

            while (dominio != "FIN")
            {

                Console.WriteLine("Ingrese la distancia recorida por el auto");
                distanciaRecorida= uint.Parse(Console.ReadLine());

                viaje = new CViaje(dominio,distanciaRecorida);

                if(cont == 0)
                {
                    viajeMax= viaje;
                }

                if (viaje.MayorViaje(viajeMax) == 1) { viajeMax = viaje; }

                cont++;
                Console.WriteLine("Ingrese el Dominio del Auto");
                dominio = Console.ReadLine().ToUpper();
            }


            if(cont == 0)
            {
                Console.WriteLine("No se ingreso  un valor valido");
            }
            else
            {
                Console.WriteLine($"El mayor viaje es {viajeMax.DarDatos()}");
            }
         }
    }
}
