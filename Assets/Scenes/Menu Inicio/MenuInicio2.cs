using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VirtualGift.Programacion.Helper;

public class MenuInicio2 : MonoBehaviour
{
    void Start()
    {
        ProgramaHelper.reiniciarEnvoltorio();
    }
    //Recivir un Regalo
    public void RecibirRegalo()
    {
        ProgramaHelper.PantallaAnterior = 0;
        SceneManager.LoadScene("Menu Recivir Regalo");

    }

    public void EnviarRegalo()
    {
        ProgramaHelper.PantallaAnterior = 0;
        SceneManager.LoadScene(4);

    }
    public void CrearRegalo()
    {
        ProgramaHelper.PantallaAnterior = 0;
        SceneManager.LoadScene(5);
    }

    //Salir de la aplicacion
    public void Salir()
    {
        Debug.Log("SALIEEENDOOOOO...");
        Application.Quit();
    }
}
