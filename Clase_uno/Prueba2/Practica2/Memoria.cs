using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;


//1° Crear metodo que nos regrese el resultado seleccionado.
//2° Utilizar el resultado en una nueva operacion.
//3° Guardar la nueva operacion en nuestra db.json.

namespace Practica2
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
            foreach ( var item in dbObject)
            {
                Console.WriteLine("Dato de Memoria: ");
                MemoriaData memoriaData = new MemoriaData(item.Key, item.Value["operacion"].ToString(), (float)item.Value["resultado"]);
                Console.WriteLine(memoriaData.Fecha.ToLongDateString());
                //DateTime OP = Convert.ToDateTime(key);
                //Console.WriteLine(memoriaData.Fecha.ToLongDateString());
                Console.WriteLine(memoriaData.Resultado.ToString());
                Console.WriteLine("\n");
                Console.WriteLine("------------------------------------");
            }
            //Console.WriteLine(result);
        }
    }

    class MemoriaData
    {
        public DateTime Fecha;
        public string Operacion;
        public float Resultado;

        public MemoriaData(string date, string operation, float res)
        {
            Fecha = DateTime.Parse(date);
            Operacion = operation;
            Resultado = res;
        }
    }

    class LLamado
    {
        public string aux;

        public LLamado(string Auxiliar)
        {
            string filepath = "../../../db.json";
            StreamReader reader = new StreamReader(filepath);
            var auxJSON = reader.ReadToEnd();
            var ObjJSON = JObject.Parse(auxJSON);
        }
    }

}
