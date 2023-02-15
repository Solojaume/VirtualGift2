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

        public static void Deserialize(string json)
        {
            JsonUtility.FromJsonOverwrite(json,ProgramaHelper.regalo);
            //return en;
        }

        public static Regalo DeserializeRegalo(string json)
        {
            Regalo? en = JsonUtility.FromJson<Regalo>(json);
            return en;
        }
    }

}
