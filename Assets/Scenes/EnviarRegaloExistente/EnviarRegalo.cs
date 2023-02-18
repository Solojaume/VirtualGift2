using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGift.Programacion.Helper;

public class EnviarRegalo : MonoBehaviour
{
    private string nombreArchivo = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void modificarNombreArchivo(string nombreArchivo)
    {
        try {
            string r = ArchivoHelper.LeerArchivoGuardado("regalos/" + nombreArchivo);
            //JsonHelper.Deserialize(r);
            this.nombreArchivo = nombreArchivo;
            Debug.Log(nombreArchivo);
            Debug.Log("Componente archivo:" + r);
        }
        catch { }
        
    }

}
