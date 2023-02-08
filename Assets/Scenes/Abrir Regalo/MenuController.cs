using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Metodo que coloca todo en de origen
    //Es decir cierra la caja y coloca el regalo en su sitio de origen
    public void VolverAAbrir() { 
    }

    //Sirve para volver al usuario a la pantalla anterior
    public void VolverAtras() {
        //SceneManager.LoadScene();
    }

    //Como su nombre indica te lleva a dicho menú
    public void MenuPrincipal() {
        SceneManager.LoadScene("Menu Inicio");
    }
}
