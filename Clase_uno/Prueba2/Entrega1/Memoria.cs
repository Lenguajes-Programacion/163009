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
            foreach ((var key, var item) in dbObject)
            {
                Console.WriteLine("Dato de Memoria: ");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now, item["operacion"].ToString(),(int) item["resultado"]);
                DateTime OP = Convert.ToDateTime(key);
                Console.WriteLine(key.ToString());
                Console.WriteLine(memoriaData.Resultado.ToString());
                Console.WriteLine("\n");
            }
            //Console.WriteLine(result);
        }
    }

    class MemoriaData
    {
        public DateTime Fecha;
        public string Operacion;
        public int Resultado;

        public MemoriaData(DateTime date, string operation, int res)
        {
            Fecha = date;
            Operacion = operation;
            Resultado = res;
        }
    }

}
