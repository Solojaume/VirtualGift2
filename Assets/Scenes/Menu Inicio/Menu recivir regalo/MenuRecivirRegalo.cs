using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VirtualGift.Programacion.Helper;

public class MenuRecivirRegalo : MonoBehaviour
{
    //LLeva a la pantalla que sirve para introducir un codigo
    public void RecivirCodigo()
    {
        ProgramaHelper.PantallaAnterior = 1;
        SceneManager.LoadScene("Recivir por codigo");
    }

    //Lleva a la pantalla que sirve para escanear un QR
    public void RecivirQR()
    {
        ProgramaHelper.PantallaAnterior = 1;
        //SceneManager.LoadScene("SampleScene");
    }

    //Lleva a la pantalla PRINCIPAL
    public void Volver()
    {
        ProgramaHelper.PantallaAnterior = 1;
        SceneManager.LoadScene("Menu inicio");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void Start()
    {
        ProgramaHelper.reiniciarEnvoltorio();
    }
}
