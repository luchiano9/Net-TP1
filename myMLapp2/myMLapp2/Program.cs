using System;
using MyMLapp2ML.Model;

namespace myMLapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Add input data
            var input = new ModelInput();
            Console.WriteLine("Ingrese codigo de vendedor: (CMT o VTS)");
            input.Vendor_id = Console.ReadLine();
            input.Rate_code = 1 ;
            Console.WriteLine("Ingrese Metodo de pago: (CRD o CSH)");
            input.Payment_type = Console.ReadLine();
            Console.WriteLine("Ingrese cantidad de pasajeros");
            input.Passenger_count = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tiempo del viaje en Segundos");
            input.Trip_time_in_secs = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese distancia del viaje en kilometros");
            input.Trip_distance = float.Parse(Console.ReadLine());


            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"El costo del Taxi es de: ${result.Score}");

            Console.ReadKey();
        }
    }
}
