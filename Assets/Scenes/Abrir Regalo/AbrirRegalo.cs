using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGift.Programacion.Helper;
using System;
namespace VirtualGift.Scenes.AbrirRegalo
{
    public class AbrirRegalo : AbrirRegaloHelper
    {
        protected bool clickIzquierdoPulsado;
        protected bool clickIzquierdoRecienPulsado;
        protected float pInicialY, pDejadaTapa;
        protected string Tipo = ProgramaHelper.regalo.Tipo;
        protected float pIRenY;
        protected GameObject objeto;
        protected string nombreRegalo = "";
        protected bool recienPulsadoVolverAAbrir = false;

        // Start is called before the first frame update
        void Start()
        {
            clickIzquierdoPulsado = false;

            //Asignamos el tipo de regalo leido a la vaiable tipo
            this.Tipo = ProgramaHelper.regalo.Tipo;

            //Colocamos la caja en el lugar inicial
            objeto = GameObject.Find("caja" + this.Tipo);
            objeto.transform.position = ProgramaHelper.posicionInicialCajaEnvoltorio;

            //colocamos El regalo en su lugar
            try {

                this.nombreRegalo = ProgramaHelper.regalo.Contenido.Name;
                objeto = GameObject.Find(this.nombreRegalo);
            }
            catch(Exception ms) {
                Debug.Log("Error no se ha encontrado el siguiente objeto:"+ms);
                this.nombreRegalo = ProgramaHelper.regalo.Contenido.Tipo;
                objeto = GameObject.Find(this.nombreRegalo);
            }
            objeto.transform.position = ProgramaHelper.posicionInicialRegalo;


            Debug.Log("TIPO: "+this.Tipo);
            objeto = GameObject.Find("tapa"+ this.Tipo);

            //Mostramos la poicion inicial de tapa de la caja
            Debug.Log("x: " + ProgramaHelper.PosicionInicialTapaCaja.x + " y:" + ProgramaHelper.PosicionInicialTapaCaja.y + " z:" + ProgramaHelper.PosicionInicialTapaCaja.z);

            //Colocamos la tapa en el lugar inial de la caja
            objeto.transform.position = ProgramaHelper.PosicionInicialTapaCaja;
            pInicialY = objeto.transform.position.y;
            clickIzquierdoRecienPulsado = false;
            ProgramaHelper.VolverAAbrirRegalo();
        }

        // Update is called once per frame
        void Update()
        {
            //Detecto si el boton izquierdo del raton  se a clickado
            if (Input.GetButtonDown("Fire1"))
            {
                //Se guarda el estado de que se a clikcado en una variable
                this.clickIzquierdoPulsado = true;

                Vector3 mousePos = Input.mousePosition;
                float yC = mousePos.y;
                this.pIRenY = yC;

                Debug.Log("posicion inicial raton:" + pIRenY);
            }

            if (this.clickIzquierdoPulsado == true)
            {

                Vector3 mousePos = Input.mousePosition;
                {
                    float x = mousePos.x;
                    float y = mousePos.y;
                    Debug.Log("Y Raton actual : " + y + " X RATON ACTUAL:" + x);
                    switch (ProgramaHelper.CajaRegaloAbierta)
                    {
                        case false:
                            MoveTapa(mousePos);
                            break;
                        case true:
                            if (ProgramaHelper.primerMovimientoRegalo == false)
                            {
                                //clickIzquierdoPulsado=false;
                                clickIzquierdoRecienPulsado = false;
                                pIRenY = y;
                                objeto = GameObject.Find(this.nombreRegalo);
                                pInicialY = objeto.transform.position.y;
                                //mousePos.y = 35f;
                            }
                            switch (clickIzquierdoPulsado)
                            {
                                case false:
                                    Debug.Log("Click izquierda Pulsado false");
                                    break; 
                                default:
                                    Debug.Log("Sw TRue");
                                    MoveRegaloSubeBaja(mousePos);
                                    break;
                                    
                            }
                            break;  
                            
                    }

                }

            }

            //Detecto si el boton izquierdo del raton  se a soltado
            if (Input.GetButtonUp("Fire1"))
            {
                //Se guarda el estado de que se a soltado en una variable
                clickIzquierdoPulsado = false;

                //Se guarda que se ha clickado por primera vez
                clickIzquierdoRecienPulsado = true;

                //Detecto si se acaba de pulsar volveraAbrir
                if (recienPulsadoVolverAAbrir==true)
                {
                    recienPulsadoVolverAAbrir = false;
                    clickIzquierdoRecienPulsado = false;
                }

                //Se actualiza la posicion inical del raton en y
                pIRenY = 0f;

                pDejadaTapa = objeto.transform.position.y;
            }
        }

        //Metodo encargado de mover la tapa
        public void MoveTapa(Vector3 position)
        {
            GameObject tapa = GameObject.Find("tapa" + Tipo);

            float height = Screen.height;
            Debug.Log("Screen height: " + height);

            switch (height)
            {
                case > 1500:
                    height = ((height * 0.75F) / 100);
                    break;
                case > 900:
                    height = ((height * 1) / 100);
                    break;
                case > 600:
                    height = ((height * 1.5F) / 100);
                    break;
                case > 0:
                    height = ((height * 2F) / 100);
                    break;
            }

            Debug.Log("height: " + height);
            if (MoveObject(position, tapa, height)==true)
            {
                ProgramaHelper.CajaRegaloAbierta = true;
            }
        }

        //Metodo que hace que suba y baje el regalo
        public int MoveRegaloSubeBaja(Vector3 position)
        {
            if (ProgramaHelper.RegaloSacado == true)
            {
                return 0;
            }
            if (clickIzquierdoPulsado = true)
            {
                ProgramaHelper.primerMovimientoRegalo = true;
                Debug.Log("CajaAbierta: " + ProgramaHelper.CajaRegaloAbierta);
                GameObject tapa = GameObject.Find(this.nombreRegalo);

                float height = Screen.height;
                Debug.Log("Screen height: " + height);

                switch (height)
                {
                    case > 1500:
                        height = ((height * 7.5F) / 100);
                        break;
                    case > 900:
                        height = ((height * 10) / 100);
                        break;
                    case > 600:
                        height = ((height * 25F) / 100);
                        break;
                    case > 0:
                        height = ((height * 30F) / 100);
                        break;
                }

                Debug.Log("height: " + height);
                if (MoveObject(position, tapa, height) == true)
                {
                    ProgramaHelper.RegaloSacado = true;
                }
            }
            
            return 1;
        }

        //Metodo para movercualquier objeto
        bool MoveObject(Vector3 position, GameObject tapa, float height)
        {
            Debug.Log("CajaAbierta: "+ProgramaHelper.CajaRegaloAbierta);
            bool devolver = false;
            //Declaro x, z
            float x = tapa.transform.position.x;
            float z = tapa.transform.position.z;

            //Declaro Y, asignandole la posicion del raton
            float y = position.y;
            Debug.Log("Y Raton actual : " + y + " X tapa ACTUAL:" + x);

            //Posicion de y después de resto la posicion inicial
            y -= pIRenY;
            Debug.Log("Posicion y despues de descontar Y Raton inicial : " + y);


            switch (clickIzquierdoRecienPulsado)
            {
                case false:
                    y += //Sumamos la posicion inicial del objeto y esto se hace dado que esta es negativa
                     y += pInicialY;
                    Debug.Log("Posicion y despues de descontar Y Raton inicial, e Y inicial : " + y);
                    break;
                case true:
                    y += pDejadaTapa;
                    Debug.Log("Posicion y despues de descontar Y Raton inicial,de dejar la tapa : " + y);

                    break;

            }

            //Se comprueba que Y es mayor que  la posicion inicial de la tapa, si lo es se reinicia
            if (y < pInicialY)
            {
                y = pInicialY;
                Debug.Log("y reiniciada");
            }


            //Si y es menor que la altura de la pantalla se cambia la posición de la tapa
            if (y > height)
            {
                y = height;
                devolver = true;
                Debug.Log("Y menor que height | height:" + height );
            }

            tapa.transform.position = new Vector3(x, y, z);
            Debug.Log("Y resultante : " + y);
            return devolver;
            // Este es el orden de ejes para el metodo Translate(float eje , float eje z , float ejeY)

        }


        // Metodo que coloca todo en de origen
        //Es decir cierra la caja y coloca el regalo en su sitio de origen
        public void VolverAAbrir()
        {
            ProgramaHelper.primerMovimientoRegalo = false;
            clickIzquierdoPulsado = false;
            //Reinicio regalo y todas la variables necesarias
            objeto = GameObject.Find(this.nombreRegalo);
            pInicialY = ProgramaHelper.posicionInicialRegalo.y;
            clickIzquierdoRecienPulsado = false;
            ProgramaHelper.VolverAAbrirRegalo();
            MoveRegaloSubeBaja(ProgramaHelper.posicionInicialRegalo);

            //Reinicio tapa y todas la variables necesarias
            objeto = GameObject.Find("tapa" + this.Tipo);
            pInicialY = ProgramaHelper.PosicionInicialTapaCaja.y;
            clickIzquierdoRecienPulsado = false;
            ProgramaHelper.VolverAAbrirRegalo();
            MoveTapa(ProgramaHelper.PosicionInicialTapaCaja);
            recienPulsadoVolverAAbrir = true;
        }
    }
}

