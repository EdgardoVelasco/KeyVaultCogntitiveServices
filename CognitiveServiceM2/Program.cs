using System;
using CognitiveServiceM2.cognitive;

namespace CognitiveServiceM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-.-.-.-.Detectando Idioma-.-.-.");
            Console.WriteLine("Escribe un texto: ");
            var texto = Console.ReadLine();

            /*Nos conectamos al servicio cognitivo*/
            var cliente = TextClient.Cliente;

            /*Utilizando el servicio cognitivo detectamos el idioma*/
            var deteccion = cliente.DetectLanguage(texto);

            /*Extraemos la información retornada*/
            Console.WriteLine($"Nombre idioma: {deteccion.Value.Name}");
            Console.WriteLine($"ISO6391: {deteccion.Value.Iso6391Name}");
            Console.WriteLine($"Score: {deteccion.Value.ConfidenceScore}");
            Console.ReadKey();
        }
    }
}
