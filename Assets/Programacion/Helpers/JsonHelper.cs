using System;
using VirtualGift.Programacion.Models;
using UnityEngine;

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
            return JsonUtility.ToJson(o);
        }

        public static string Serialize(Envoltorio o)
        {
            /*
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(o,options);
            */
            return JsonUtility.ToJson(o);
        }

        public static string Serialize(Objeto o)
        {
            /*
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(o,options);
            */
            return JsonUtility.ToJson(o);
        }

        public static Envoltorio Deserialize(string json)
        {
            Envoltorio? en = JsonUtility.FromJson<Envoltorio>(json);
            return en;
        }

        public static Regalo DeserializeRegalo(string json)
        {
            Regalo? en = JsonUtility.FromJson<Regalo>(json);
            return en;
        }
    }

}
