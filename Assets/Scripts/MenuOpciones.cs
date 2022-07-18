using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpciones : MonoBehaviour
{
    // Start is called before the first frame update
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
