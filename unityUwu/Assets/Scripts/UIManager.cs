using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public static UIManager instance; // Opcional, crea una instancia singleton para fácil acceso desde otros scripts.
    public TextMeshProUGUI bachesText;           // Arrastra aquí el elemento de texto de UI desde el Inspector.
    public CarController carController;
    public TextMeshProUGUI posicionBacheText; // Texto para mostrar la posición del bache.
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        bachesText.text = "Baches totales: " + carController.contadorBaches;
        //posicionBacheText.text = "Último bache en: (" + carController.bachePosition.x.ToString("F2") + ", " + carController.bachePosition.y.ToString("F2") + ", " + carController.bachePosition.z.ToString("F2") + ")";
        // Reiniciar el texto de las posiciones de los baches
        posicionBacheText.text = "Posiciones de baches:";

        // Añadir cada posición de bache al texto
        foreach (Vector3 pos in carController.bachesPositions)
        {
            posicionBacheText.text += "\n(" + pos.x.ToString("F2") + ", " + pos.y.ToString("F2") + ", " + pos.z.ToString("F2") + ")";
        }
    }

    void Awake()
    {
        // Singleton simple para asegurar que solo haya una instancia de UIManager.
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    /*public void UpdateBachesCount(int count)
    {
        bachesText.text = "Baches totales: " + count;
    }*/
}
