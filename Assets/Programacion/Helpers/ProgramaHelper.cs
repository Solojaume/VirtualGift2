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


        //Comunica al programa si se habia empezado amover el regalo
        public static bool primerMovimientoRegalo = false;

        //Comunica al programa si se habia sacado un regalo Completamente
        public static bool RegaloSacado = false;

        //Corresponde al id de la escena anterior que se estaba visitando
        public static int PantallaAnterior = 0;

        //Declaro diccionario
        public static Dictionary<string, Vector3> diccionarioObjetos = new Dictionary<string, Vector3>()
        {
            {"suspectCard",new Vector3(60, 50f, 549f) },
            {"suspectPaula",new Vector3(118, 21f, 549f) },
            {"Rosas",new Vector3(58.7f, 20.8f, 494.9f) },
        };


        public readonly static Vector3 posicionInicialCajaEnvoltorio = new Vector3(68.09995f, 2, 492.4391f);
        public  static Vector3 posicionInicialRegalo = new Vector3(60, 21f, 549f);
        public readonly static Vector3 PosicionInicialTapaCaja = new Vector3(69f, -141f, 493.7f);

        private static Regalo pre = new Regalo("suspectPaula", "JuegoCartas");
        //Creo envoltorio compartido por toda la aplicacion
        public static Envoltorio regalo;

        public static void VolverAAbrirRegalo()
        {
            CajaRegaloAbierta = false;
            RegaloSacado = false;
        }

        public static void reiniciarEnvoltorio()
        {
            pre = new Regalo("suspectPaula", "JuegoCartas");
            regalo = new Envoltorio("pbmv2023", "Paulita", pre);
       
        }

        public static void reiniciarRegalo(string r)
        {
            posicionInicialRegalo = diccionarioObjetos[r];
        }

    };
}
