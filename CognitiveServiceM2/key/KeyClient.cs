using System;
using System.Collections.Generic;
using System.Text;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace CognitiveServiceM2.key
{
    /*Esta clase se va a conectar al azure AD y mediante una auth va 
     * a conectarse al servicio de Azure Keyvault
     */
    class KeyClient
    {
        /*Creación de constantes*/
        private static readonly string CLIENT_ID = "321df824-6b8b-4ebc-b251-031f5463133d";
        private static readonly string TENANT_ID = "8f801786-dcd2-4f6b-b81e-f961ea9a9e20";
        private static readonly string SECRET = "Ijl3I2-cY6i-4-b~53ebOMhRBcR4TL4bWD";
        private static readonly string VAULT_URI = "https://vaultenvef.vault.azure.net/";

        /*Atributo que usaremos para obtener los secretos de Azure KeyVault*/
        public static SecretClient Secret { get; private set; }

        /*constructor estático*/
        static KeyClient() { InitVault(); }

        /*Método usado para la conexión con Azure KeyVault*/
        private static void InitVault() {
            if (Secret == null) {
                var credencial = new ClientSecretCredential(TENANT_ID,CLIENT_ID, SECRET);
                Secret = new SecretClient(new Uri(VAULT_URI), credencial);
            }
        }
    }
}
