using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirRegalo : MonoBehaviour
{

    private bool clickIzquierdoPulsado;
    private bool clickIzquierdoRecienPulsado;
    private float pInicialY;
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
            //Se guarda que se ha clickado por primera vez
            clickIzquierdoRecienPulsado = true;
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

            //Se actualiza la posicion inical del raton en y
            pIRenY = 0f;
        }
    }

    void FixedUpdate() {
        
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

        y += pInicialY;
        Debug.Log("Posicion y despues de descontar Y Raton inicial, e Y inicial : " + y);
        //Se comprueba que Y es mayor que  la posicion inicial de la tapa, si lo es se reinicia
        if (y<pInicialY)
        {
            y = pInicialY;
            Debug.Log("y reiniciada");
        }
        if(clickIzquierdoRecienPulsado == true)
        {
            y = tapa.transform.position.y;
            clickIzquierdoRecienPulsado = false;
        }

        //Si y es menor que la altura de la pantalla se cambia la posición de la tapa
        if(y<Screen.height-pIRenY)
        {
            tapa.transform.position = new Vector3(x, y, z);
        }
        Debug.Log("Y resultante : " + y);
        // Este es el orden de ejes para el metodo Translate(float eje , float eje z , float ejeY)
        
       
    }
    
   

}

