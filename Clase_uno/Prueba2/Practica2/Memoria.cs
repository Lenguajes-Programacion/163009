using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;


//1° Crear metodo que nos regrese el resultado seleccionado. ------------------------
//2° Utilizar el resultado en una nueva operacion. ------------------------
//3° Guardar la nueva operacion en nuestra db.json.

namespace Practica2
{
    class Memoria
    {
        public List<MemoriaData> db = new List<MemoriaData>();
        public Memoria()
        {
            // Constructor de la clase Memoria, para inicializar nuestra lista
            db = new List<MemoriaData>();
        }
        /*
        public void ExtraLeerMemoria()
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
        */
        /*
        public void arreglo()
        {
            string[] Colores = { "Rojo", "Blanco", "Morado" };
            //List<string> colores = ["Rojo", "Blanco", "Morado"];
            //colores.Sort();
            Array.Reverse(Colores);
            Array.ForEach(Colores, (item) => {
                Console.WriteLine(item);
                Console.WriteLine("\n");
            });
            String color = Array.Find(Colores, (item) => {
                return item.Length > 4;
            });
            Console.WriteLine(color);
            Console.WriteLine("Accede tus colores y separalos con comas(,):");
            String colorUser = Console.ReadLine();
            // Un string se puede convertir en arreglo con su propiedad Split, dándole el patron.
            string[] newColors = colorUser.Split(' ');
            Console.WriteLine(newColors);
            Console.WriteLine("\n");
        }
        public void Bidimencional()
        {
            int[,] Dos = new int[5, 5];
            Console.WriteLine(Dos);
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                //Arreglo unidimencional
                Console.WriteLine("Arreglo Unidimencional");
                string[] Uno = { "Rojo", "Blanco", "Morado" };
                Console.WriteLine("[{0}]", string.Join(",", Uno));
                Console.WriteLine("\n");
                //--------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------
                //Arreglo Bidimencional
                Console.WriteLine("Arreglo Bidimencional");
                int[,] Dos = new int[5, 5];
                for (int i = 0; i < Dos.GetLength(0); i++)
                {
                    for (int x = 0; x < Dos.GetLength(1); x++)
                    {
                        Console.WriteLine("{0},{1}={2}", i,x,Dos[i,x]);
                    }
                }
                Console.WriteLine("\n");
                //--------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------
                //Arreglo Multidimencional
                Console.WriteLine("Arreglo Multidimencional");
                int[,,] Tres = new int[5, 5, 5];
                //Array.ForEach(array, Console.WriteLine());
                for (int i = 0; i < Tres.GetLength(0); i++)
                {
                    for (int x = 0; x < Tres.GetLength(1); x++)
                    {
                        for (int z = 0; z < Tres.GetLength(2); z++)
                        {
                            //Para sumar el valor con el otro
                            Tres[i, x, z] = i + x + z;
                            //Para imprimir el arreglo multidimencional
                            Console.WriteLine("{0},{1},{2}={3}", i, x, z, Tres[i, x, z]);
                        }
                    }
                }
                Console.WriteLine("\n");
                //Arreglo de 4 Dimenciones
                Console.WriteLine("Arreglo de 4 Dimenciones");
                int[,,,] Cuatro = new int[5, 5, 5, 5];
                for (int i = 0; i < Cuatro.GetLength(0); i++)
                {
                    for (int x = 0; x < Cuatro.GetLength(1); x++)
                    {
                        for (int z = 0; z < Cuatro.GetLength(2); z++)
                        {
                            for (int k = 0; k < Cuatro.GetLength(3); k++)
                            {
                                Console.WriteLine("{0},{1},{2},{3}={4}", i, x, z, k, Cuatro[i, x, z, k]);
                            }
                        }
                    }
                }
                //Console.WriteLine("[{0}]", string.Join(",",array));
                //--------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------
                //--------------------------------------------------------------------------------
                string op = Console.ReadLine();
                Console.WriteLine("\n");
                if (op == "y")
                {
                    salir = true;
                }
            }
        }
        */
        public void LeerMemoria()
        {
            ConsoleColor currentColor = Console.BackgroundColor;
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            // Prueba de lectura de archivo db.json
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
            // Lectura de json iterable
            int i = 0; // Indice creado manualmente para ubicar facilmente nuestros objetos dentro de la lista db.
            foreach (var item in dbObject)
            {
                // Iteración individual de cada grupo de datos del objeto json.
                MemoriaData memoriaData = new MemoriaData(item.Key.ToString(), item.Value["operacion"].ToString(), item.Value["resultado"].ToString());
                this.db.Add(memoriaData);
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0} - {1}", memoriaData.Fecha.ToLongDateString(),
                memoriaData.Fecha.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine("Operación: {0}", memoriaData.Operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.Resultado.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------- \n");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }
        public float GetMemoriaData(String key)
        {
            // Encontrar el dato deseado con indice manual en el parseo del json.
            int index = int.Parse(key);
            // Opción Nativa:  para buscar de manera nativa en nuestro List db. Con el indice autogenerado.
            // En tres lineas de código encontramos y reutilizamos el valor que se busca.
            MemoriaData data = db[index];
            // Opción para buscar por medio de indice manual:
            // MemoriaData data = db.Find(item => item.key == index); // Damos un indice para que lo busque y al encontrarlo nos regresa el objeto deseado.
            // Encontrar el dato deseado por la fecha. Accedemos al json nuevamente y buscamos por fecha. 
            // Ya que esta operación no asigna nuevos indices, respeta la estructura acutal.
            // string archivoDB = "../../../db.json";
            // StreamReader reader = new StreamReader(archivoDB);
            // var dbJSON = reader.ReadToEnd();
            // JObject dbObject = JObject.Parse(dbJSON);
            // JToken data = (dbObject as JObject)[key];
            // return (int)data["resultado"];
            return data.Resultado;
        }
        public void GuardarMemoria(MemoriaData data)
        {
            db.Add(data);
            int i = 0;
            db.ForEach((MemoriaData memoriaData) =>
            {
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} - {1}", memoriaData.Fecha.ToLongDateString(),
                memoriaData.Fecha.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine("Operación: {0}", memoriaData.Operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.Resultado.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------- \n");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            });
            string json = JsonConvert.SerializeObject(db.ToArray(), Formatting.Indented);
            string archivoDB = "../../../db.json";
            File.WriteAllText(archivoDB, json);
        }
    }

    class MemoriaData
    {
        public DateTime Fecha;
        public string Operacion;
        public float Resultado;

        public MemoriaData(string date, string operation, String res)
        {
            Fecha = DateTime.Parse(date);
            Operacion = operation;
            Resultado = float.Parse(res);
        }
    }
    /*
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
    */
}
