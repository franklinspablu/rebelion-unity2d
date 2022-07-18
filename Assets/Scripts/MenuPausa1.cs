using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPausa1 : MonoBehaviour
{
    // Funciones del canvas pausa
    [SerializeField] private GameObject CanvasPausa;

    // Continua el juego
    public void Reanudar()
    {
        CharacterController.isPaused = false;
        Time.timeScale = 1f;
        CanvasPausa.SetActive(false);
    }

    // Reinicia la partida
    public void Reiniciar()
    {
        CharacterController.isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Regresa a la canvas de inicio
    public void Cerrar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Cierra el juego
    public void Exit()
    {
        Debug.Log("CERRANDOOOOO!!!!!");
        Application.Quit();
    }
}

