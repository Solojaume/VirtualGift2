using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirRegalo : MonoBehaviour
{

    private bool clickIzquierdoPulsado;
    private bool clickIzquierdoRecienPulsado;
    private float pInicialY,pDejadaTapa;
    private GameObject tapa;
    private float pIRenY;
    // Start is called before the first frame update
    void Start()
    {
        clickIzquierdoPulsado = false;
        tapa = GameObject.Find("tapa");
        pInicialY = tapa.transform.position.y;
        clickIzquierdoRecienPulsado = false;
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
           
            Debug.Log("posicion inicial raton:"+pIRenY);
        }

        if (this.clickIzquierdoPulsado == true)
        {

            Vector3 mousePos = Input.mousePosition;
            {
                float x = mousePos.x;
                float y = mousePos.y;
                Debug.Log("Y Raton actual : " + y + " X RATON ACTUAL:"+x);
                MoveTapa(mousePos);
            }
           
        }

        //Detecto si el boton izquierdo del raton  se a soltado
        if (Input.GetButtonUp("Fire1"))
        {
           
            //Se guarda el estado de que se a soltado en una variable
            clickIzquierdoPulsado = false;

            //Se guarda que se ha clickado por primera vez
            clickIzquierdoRecienPulsado = true;

            //Se actualiza la posicion inical del raton en y
            pIRenY = 0f;

            pDejadaTapa = tapa.transform.position.y;
        }
    }

    //Metodo encargado de mover la tapa
    public void MoveTapa(Vector3 position)
    {
       //Declaro x, z
        float x = tapa.transform.position.x;
        float z = tapa.transform.position.z;

        //Declaro Y, asignandole la posicion del raton
        float y = position.y ;
        Debug.Log("Y Raton actual : " + y + " X tapa ACTUAL:" + x);

        //Posicion de y después de resto la posicion inicial
        y -= pIRenY;
        Debug.Log("Posicion y despues de descontar Y Raton inicial : " + y);

        
        switch(clickIzquierdoRecienPulsado){
            case false:
                y += //Sumamos la posicion inicial del objeto y esto se hace dado que esta es negativa
                 y += pInicialY;
                Debug.Log("Posicion y despues de descontar Y Raton inicial, e Y inicial : " + y);
                break;
            default:
                y += pDejadaTapa;
                break;

        }
        
        

        //Se comprueba que Y es mayor que  la posicion inicial de la tapa, si lo es se reinicia
        if (y < pInicialY)
        {
            y = pInicialY;
            Debug.Log("y reiniciada");
        }

        float height = Screen.height;
        height -= ((pIRenY*20)/100);
        //Si y es menor que la altura de la pantalla se cambia la posición de la tapa
        if (y<height)
        {
            tapa.transform.position = new Vector3(x, y, z);
        }
        Debug.Log("Y resultante : " + y);
        // Este es el orden de ejes para el metodo Translate(float eje , float eje z , float ejeY)
        
       
    }
    
   

}

