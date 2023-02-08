using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

        public static Vector3 posicionInicialCajaEnvoltorio = new Vector3(-13.0265f, -41.6467f, -1.132843f);
        public static Vector3 PosicionInicialTapaCaja = new Vector3(-12.12644f, -184.6467f, 0.1280823f);
        
        public static void VolverAAbrirRegalo()
        {
            CajaRegaloAbierta = false;
            RegaloSacado = false;
        }

    };
}
