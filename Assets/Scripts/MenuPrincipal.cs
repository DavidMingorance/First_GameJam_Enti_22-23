using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public AudioSource sound;

    // Start is called before the first frame update
    public void Start()
    {

    }
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}