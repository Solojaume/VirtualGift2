using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using VirtualGift.Programacion.Helper;

public class EnviarRegalo : MonoBehaviour
{
    public RawImage QR; // Objeto RawImage donde se mostrará el código QR
    public string json = "Hello, world!"; // Texto que se convertirá en código QR
    public int qrCodeSize = 256;
    private string nombreArchivo = "";
    private Texture2D qrCodeTexture;
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
            json = ArchivoHelper.LeerArchivoGuardado("regalos/" + nombreArchivo);
            //JsonHelper.Deserialize(r);
            this.nombreArchivo = nombreArchivo;
            Debug.Log(nombreArchivo);
            Debug.Log("Componente archivo:" + json);
            GameObject qr = GameObject.Find("QR");

            
        }
        catch {
            Debug.Log("Error al crear el qr");
        }

        try {
            //Generar Qr
           /* var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode("Hola, mundo!", QRCodeGenerator.ECCLevel.Q);

            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(qrCodeSize);
            using (var memoryStream = new MemoryStream())
            {
                //qrCodeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                memoryStream.Seek(0, SeekOrigin.Begin);

                qrCodeTexture = new Texture2D(qrCodeSize, qrCodeSize);
                qrCodeTexture.LoadImage(memoryStream.ToArray());
            }

            var qrCodeObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
            qrCodeObject.transform.position = new Vector3(0, 0, 2);
            qrCodeObject.GetComponent<Renderer>().material.mainTexture = qrCodeTexture;


            //QR.texture = qrCodeTexture;*/
        }
        catch {
            Debug.Log("Error generación QR");
        }
        
    }

}
