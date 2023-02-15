using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VirtualGift.Programacion.Helper;
using VirtualGift.Programacion.Models;
public class RecivirPorCodigo : MonoBehaviour
{
    private string codigoValido = "";
    //private string codigoValido = "PBMV2023";
    private string codigoIntroducido = "";

    InputField ICodigo;
    void start()
    {
        ProgramaHelper.reiniciarEnvoltorio();
    }
    void update()
    {

    }

    //Cambiar codigo introducido
    public void CambiarCodigo(string codigoIntroducido)
    {
        this.codigoIntroducido = codigoIntroducido.ToUpper();
        Debug.Log(codigoIntroducido);
        string mostrar = "Codigo Introducido: " + this.codigoIntroducido;
        Debug.Log(mostrar);
    }

    

    //Comprueva si el codigo introducido es valido al pulsar "Abrir regalo"
    public void AbrirRegalo()
    {
        ProgramaHelper.PantallaAnterior = 2;
        try
        {
            string r = ArchivoHelper.LeerArchivoGuardado("regalos/" + codigoIntroducido);
            JsonHelper.Deserialize(r);
            Envoltorio en = ProgramaHelper.regalo;
            Debug.Log("El contenido del archivo es: " + r);
            ProgramaHelper.regalo = en;
            Debug.Log("Nombre:"+ en.Name);
            Debug.Log("Tipo:" + en.Tipo);
            SceneManager.LoadScene(3);
        }
        catch(Exception msg)
        {
            Debug.Log("Nose encontro el archivo: "+ msg);
        }
        
    }

    //Lleva a la pantalla RECIVIR MENU
    public void Volver()
    {
        ProgramaHelper.PantallaAnterior = 2;
        SceneManager.LoadScene("Menu Recivir Regalo");
    }

    

}
