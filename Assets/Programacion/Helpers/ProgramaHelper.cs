using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGift.Programacion.Models;

namespace VirtualGift.Programacion.Helper
{
    public class ProgramaHelper
    {
        //Comunica al programa si se habia abierto la caja de un regalo o no
        public static bool CajaRegaloAbierta = false;


        //Comunica al programa si se habia sacado un regalo
        public static bool RegaloSacado = false;

        //Corresponde al id de la escena anterior que se estaba visitando
        public static int PantallaAnterior = 0;

        public readonly static Vector3 posicionInicialCajaEnvoltorio = new Vector3(-13.0265f, -41.6467f, -1.132843f);
        public readonly static Vector3 PosicionInicialTapaCaja = new Vector3(-12.12644f, -184, 0.1281f);

        private static Regalo pre = new Regalo("suspectPaula", "JuegoCartas");
        //Creo envoltorio compartido por toda la aplicacion
        public static Envoltorio regalo = new Envoltorio("pbmv2023", "Paulita", pre);
        public static void VolverAAbrirRegalo()
        {
            CajaRegaloAbierta = false;
            RegaloSacado = false;
        }

    };
}
