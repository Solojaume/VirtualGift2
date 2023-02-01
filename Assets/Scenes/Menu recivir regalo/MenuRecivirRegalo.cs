using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRecivirRegalo : MonoBehaviour
{
    //LLeva a la pantalla que sirve para introducir un codigo
    public void RecivirCodigo()
    {
        SceneManager.LoadScene("Recivir por codigo");
    }

    //Lleva a la pantalla que sirve para escanear un QR
    public void RecivirQR()
    {
        //SceneManager.LoadScene("SampleScene");
    }

    //Lleva a la pantalla PRINCIPAL
    public void Volver()
    {
        SceneManager.LoadScene("Menu inicio");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
