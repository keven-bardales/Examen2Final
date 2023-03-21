using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2Progra2.Models
{
    public class SerializadorJson
    {

        public static string Serializar(object objeto)
        {
            return JsonConvert.SerializeObject(objeto);
        }

        public static T Deserializar<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
