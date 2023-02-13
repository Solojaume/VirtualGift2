using System;
using VirtualGift.Programacion.Models.Interfaces;
using VirtualGift.Programacion.Helper;

using UnityEngine;

namespace VirtualGift.Programacion.Models
{
    [System.Serializable]
    public class Regalo : Objeto
    {
        public Regalo() {
            this.TipoObjeto = "Regalo";
        }
        public Regalo(string tipo) {
            this.Tipo = tipo;
            this.TipoObjeto = "Regalo";
        }

        public Regalo(string name, string tipo)
        {
            this.Tipo = tipo;
            this.Name = name;
            this.TipoObjeto = "Regalo";
        }

    }
}
