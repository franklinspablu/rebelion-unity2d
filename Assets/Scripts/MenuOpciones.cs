using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class MenuOpciones : MonoBehaviour
{
    // Start is called before the first frame update
=======
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
>>>>>>> dev
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

<<<<<<< HEAD
    // Update is called once per frame
    void Update()
    {
        
=======
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }

    public void CambiarCalidad(int index){
        QualitySettings.SetQualityLevel(index);
>>>>>>> dev
    }
}
