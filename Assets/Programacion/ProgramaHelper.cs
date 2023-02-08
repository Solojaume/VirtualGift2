using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VirtualGift.Programacion.Helper
{
    public class ProgramaHelper : MonoBehaviour
    {
        //Comunica al programa si se habia abierto la caja de un regalo o no
        public static bool CajaRegaloAbierta = false;

        //Comunica al programa si se habia sacado un regalo
        public static bool RegaloSacado = false;

        //Corresponde al id de la escena anterior que se estaba visitando
        public static int PantallaAnterior = 0;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


    };
}

