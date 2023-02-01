using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio2 : MonoBehaviour
{
    //Recivir un Regalo
    public void RecibirRegalo()
    {
        SceneManager.LoadScene("Menu Recivir Regalo");

    }

    //Salir de la aplicacion
    public void Salir()
    {
        Debug.Log("SALIEEENDOOOOO...");
        Application.Quit();
    }
}
