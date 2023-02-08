using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VirtualGift.Programacion.Helper;

namespace VirtualGift.Scenes.AbrirRegalo
{
    public class MenuController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        


        //Sirve para volver al usuario a la pantalla anterior
        public void VolverAtras()
        {

            SceneManager.LoadScene(ProgramaHelper.PantallaAnterior);
            ProgramaHelper.PantallaAnterior = 3;
        }

        //Como su nombre indica te lleva a dicho menú
        public void MenuPrincipal()
        {
            ProgramaHelper.PantallaAnterior = 3;
            SceneManager.LoadScene("Menu Inicio");
        }
    }
}

