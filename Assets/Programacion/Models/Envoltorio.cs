using System;
using VirtualGift.Programacion.Models.Interfaces;
using VirtualGift.Programacion.Helper;
using UnityEngine;


namespace VirtualGift.Programacion.Models
{
    [System.Serializable]
    public class Envoltorio : Objeto
    {
        public Envoltorio() {
            this.TipoObjeto = "Envoltorio";
        }
        //Este es el constructor que se utiliza cuando es un regalo con un envoltorio con un modelo completamente personalizado y este contiene directamente el regalo
        public Envoltorio(string name,string tipo, Objeto contenido) {
            this.Name = name;
            this.Tipo = tipo;
            this.Contenido = contenido;
            this.SubTipo = "";
            this.Color = "";
            this.TipoObjeto = "Envoltorio";
        }

        //Este es el constructor que se utiliza cuando es un regalo con un envoltorio con un modelo estandar y se le pasa el color
        public Envoltorio(string name, string tipo, Objeto contenido, string color)
        {
            this.Name = name;
            this.Tipo = tipo;
            this.Contenido = contenido;
            this.Color = color;
            this.SubTipo = "";
            this.TipoObjeto = "Envoltorio";
        }

        //Constructores Para cuando el paquete va dentro de otro paquete Y SE QUIERE PERSONALIZAR  el color 
        //Este es el constructor que se utiliza cuando es un regalo con un envoltorio con un modelo estandar y se le pasa el color, 
        public Envoltorio(string tipo, Objeto contenido, string color)
        {
            this.Name = "";
            this.Tipo = tipo;
            this.Contenido = contenido;
            this.Color = color;
            this.SubTipo = "";
            this.TipoObjeto = "Envoltorio";
        }
        //Este es el constructor que se utiliza cuando es un regalo con un envoltorio con un modelo completamente personalizado y este contiene directamente el regalo
        public Envoltorio( string tipo, Objeto contenido)
        {
            this.Name = "";
            this.Tipo = tipo;
            this.Contenido = contenido;
            this.SubTipo = "";
            this.Color = "";
            this.TipoObjeto = "Envoltorio";
        }

        /*
         * ____________________________ Definiciones variables _______________________________
         */
        public string Name { get; set; }//Puede estar vacio si esta dentro de otro envoltorio
        public string Tipo { get; set;}
        public string SubTipo { get; set; }//Puede estar vacia
        public string Color { get; set; }
        public string TipoObjeto { get; set; }//Sirve para indicar si es un regalo o un envoltorio
        public Objeto Contenido { get; set;}
    }
}

