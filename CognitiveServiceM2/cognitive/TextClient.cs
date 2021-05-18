using System;
using System.Collections.Generic;
using System.Text;
using Azure.AI.TextAnalytics;
using CognitiveServiceM2.key;

namespace CognitiveServiceM2.cognitive
{
    /* Esta clase se conecta al CognitiveService de Azure.
     * La información que necesita es la siguiente:
     * 1.- APIKEY=d85b853b4c244fc483ace48c73cd8c34
     * 2.- ENDPOINT=https://cognitivevefed.cognitiveservices.azure.com/
     */
    class TextClient
    {
        /*se crean dos constantes*/
        //private static readonly string API_KEY = "d85b853b4c244fc483ace48c73cd8c34";
        private static readonly string ENDPOINT = "https://cognitivevefed.cognitiveservices.azure.com/";

        /*se crea el atributo que utilizaremos para conectarnos al servicio*/
        /*traducción: cualquiera puede obtener el valor de Cliente, pero no puede ser
         modificado fuera de la clase*/
        public static TextAnalyticsClient Cliente { get; private set; }

        /*Constructor estático*/
        /*Definición: Inicializa los atributos de una clase*/
        /*Sólo se ejecuta 1 vez*/
        static TextClient() { InitText(); }

        private static void InitText() {
            /*Si no hay conexíón al servicio Cognitivo*/
            if (Cliente==null) {
                /*Creamos una llave*/
                var API_KEY = KeyClient.Secret.GetSecret("apikeycsk1").Value.Value;
                var credencial = new Azure.AzureKeyCredential(API_KEY);
                /*nos conectamos al servicio cognitivo*/
                Cliente = new TextAnalyticsClient(new Uri(ENDPOINT), credencial);
            }
        }


    }
}
