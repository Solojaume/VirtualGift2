using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VirtualGift.Programacion.Helper;
using VirtualGift.Programacion.Models;

public class CrearRegalo : MonoBehaviour
{
    /*
     * ___________ Variables del sistema
     */
    private Dictionary<string, string> diccionarioColoresEnvoltorio =
     new Dictionary<string, string>(){
        {"Rojo","" },
        {"Verde","verde"}
     };

    //En la primera posicion va el nombre que se muestra en el menu
    //en la segunda va una lista con los nombres de dicha categoria
    private Dictionary<string, string[]> diccionariotipoRegalo =
        new Dictionary<string, string[]>(){
        {"JuegosDeCartas",new string[] {"suspectPaula" ,"Generico"} },
        {"Flores",new string[]{"Rosas"}}

     };

    public Text colorEnvoltorio;
    private int posicionNombreRegalo = 0;
    private int posicionColor = 0;

    string nombreArchivo,tipoEvoltorio,color,tipoRegalo,nombreRegalo;


    // Start is called before the first frame update
    void Start()
    {
        ProgramaHelper.reiniciarEnvoltorio();
        Debug.Log("Regalo: "+ProgramaHelper.regalo.Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarNombre(string nombre)
    {
        nombreArchivo = nombre;
        Debug.Log("Nombre archivo:"+ nombreArchivo);

    }
    /*
     * __________ Personalización Envoltorio ________
     */
    public void cambiarTipoEnvoltorio(string tipo)
    {
        tipoEvoltorio = tipo;
        Debug.Log("Tipo envoltorio: " + tipo);
    }

    public void cambiarColor(string entrada)
    {
        string clave = "";
        Debug.Log(entrada);
        try
        {
            clave = diccionarioColoresEnvoltorio[entrada];
             color = clave;

        }
        catch
        {
            color = "";
        }
        Debug.Log(clave);
       

        //GameObject.Find("colorEnvoltorio").Text = clave;
    }
    

    /*
     * ___________ Personalizar Regalo _______
     */
    public void cambiarTipoRegalo(string regalo)
    {
        tipoRegalo = regalo;
        Debug.Log(regalo);
    }

    public void cambiarSubtipoRegalo(string subtipo)
    {
        nombreRegalo = subtipo;
        Debug.Log("Subtipo:"+subtipo);
    }


    /*
     * ___________ Botones de abajo _____________ 
     */
    //Te lleva a Enviar
    public void EnviarRegalo()
    {

    }
    //Te lleva a abrir regalo
    public void PrevisualizarRegalo()
    {
        crearEnvoltorio();
        string json = JsonHelper.Serialize(ProgramaHelper.regalo);
        Debug.Log(json);
        ArchivoHelper.CrearArchivoGuardado("regalos/" + ProgramaHelper.regalo.Name, json);
        SceneManager.LoadScene(3);
        ProgramaHelper.PantallaAnterior = 5;

    }

    public void guardarYSalir()
    {
        crearEnvoltorio();
        string json = JsonHelper.Serialize(ProgramaHelper.regalo);
        Debug.Log(json);
        ArchivoHelper.CrearArchivoGuardado("regalos/" + ProgramaHelper.regalo.Name, json);
        SceneManager.LoadScene(ProgramaHelper.PantallaAnterior);
        ProgramaHelper.PantallaAnterior = 5;
    }

    public void Volver()
    {
        SceneManager.LoadScene(ProgramaHelper.PantallaAnterior);
        ProgramaHelper.PantallaAnterior = 5;
    }

    /*
     * Otras funciones
     */
    //Crea el envoltorio y lo asigna a la variable global
    void crearEnvoltorio()
    {
       Regalo pre = new Regalo(nombreRegalo, tipoRegalo);
       ProgramaHelper.regalo = new Envoltorio(nombreArchivo, tipoEvoltorio, pre);
    }
}
