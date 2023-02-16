using System;
using VirtualGift.Programacion.Models;
using UnityEngine;
using Newtonsoft.Json;

namespace VirtualGift.Programacion.Helper
{
    public class JsonHelper
    {
        public static string Serialize(Regalo o)
        {
            /*
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(o,options);
            */
           
            return JsonConvert.SerializeObject(o);
        }

        public static string Serialize(Envoltorio o)
        {
            /*
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(o,options);
            */
            return JsonConvert.SerializeObject(o);
        }

        public static string Serialize(Objeto o)
        {
            /*
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(o,options);
            */
            return JsonConvert.SerializeObject(o);
        }
        //Deserializa el Json y lo asigna a ProgramaHelper.regalo
        public static void Deserialize(string json)
        {
            ProgramaHelper.regalo = JsonConvert.DeserializeObject<Envoltorio>(json);
            
        }

        public static Regalo DeserializeRegalo(string json)
        {
            Regalo? en = JsonUtility.FromJson<Regalo>(json);
            return en;
        }
    }

}
