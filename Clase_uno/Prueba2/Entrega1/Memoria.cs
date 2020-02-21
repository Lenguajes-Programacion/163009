using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Entrega1
{
    class Memoria
    {
        public void Guardar()
        {
            string filepath = "../db.json";
            StreamReader reader = new StreamReader(filepath);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
        }
    }
}
