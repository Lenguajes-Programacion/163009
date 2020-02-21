using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Entrega1
{
    class Memoria
    {
        public void LeerMemoria()
        {
            string filepath = "../../../db.json";
            StreamReader reader = new StreamReader(filepath);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            //¨Prueba de Lectura de archivo JSON
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
            //Lectura de JSON Iterable
            foreach(var item in dbObject)
            {
                Console.WriteLine("Dato de Memoria: ");
                Console.WriteLine(item.ToString());
            }
            //Console.WriteLine(result);
        }
    }
}
