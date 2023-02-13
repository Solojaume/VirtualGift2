using System;
using VirtualGift.Programacion.Models.Interfaces;
using System.Text;
using UnityEngine;


namespace VirtualGift.Programacion.Models
{
    [System.Serializable]
    public class Objeto : IObjeto
    {
        public Objeto() {
            this.TipoObjeto = "Objeto";
            this.Tipo = "";
            this.Name = "";
        }
        public Objeto(string tipo)
        {
            this.Tipo = tipo;
            this.TipoObjeto = "Objeto";
            this.Name = "";
        }
        public Objeto(string name, string tipo)
        {
            this.Tipo = tipo;
            this.Name = name;
            this.TipoObjeto = "Objeto";
        }

        public string Tipo { get; set; }//Puede estar vacia
        public string TipoObjeto { get; set; }//Sirve para indicar si es un regalo o un envoltorio
        public string Name { get; set; }
    }
}