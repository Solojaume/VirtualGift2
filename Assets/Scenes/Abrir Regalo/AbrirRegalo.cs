using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirRegalo : MonoBehaviour
{

    private bool clickIzquierdoPulsado;
    public float velX, velY;
   
    
    // Start is called before the first frame update
    void Start()
    {
        clickIzquierdoPulsado = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detecto si el boton izquierdo del raton  se a clickado
        if (Input.GetButtonDown("Fire1"))
        {
            //Se guarda el estado de que se a clikcado en una variable
            this.clickIzquierdoPulsado = true;
            Debug.Log("Click");
        }

        if (this.clickIzquierdoPulsado == true)
        {

            Vector3 mousePos = Input.mousePosition;
            {
                float x = mousePos.x;
                float y = mousePos.y;
                Debug.Log("x: " + x);
                Debug.Log("y: " + y);
            }
            //Move();
        }
       

        //Detecto si el boton izquierdo del raton  se a soltado
        if (Input.GetButtonUp("Fire1"))
        {
            //Se guarda el estado de que se a soltado en una variable
           clickIzquierdoPulsado = false;
            Debug.Log("Desclick");
        }
    }

   

}
