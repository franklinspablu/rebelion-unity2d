using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPausa1 : MonoBehaviour
{
    // [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject CanvasPausa;

    /*
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }*/

    // public void Pausa()
    // {
    //     juegoPausado = true;
    //     Time.timeScale = 0f;
    //     botonPausa.SetActive(false);
    //     menuPausa.SetActive(true);
    // }

    public void Reanudar()
    {
        CharacterController.isPaused = false;
        Time.timeScale = 1f;
        // botonPausa.SetActive(true);
        CanvasPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        CharacterController.isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Exit()
    {
        Debug.Log("CERRANDOOOOO!!!!!");
        Application.Quit();
    }
}

