using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public static UIManager instance; // Opcional, crea una instancia singleton para f�cil acceso desde otros scripts.
    public TextMeshProUGUI bachesText;           // Arrastra aqu� el elemento de texto de UI desde el Inspector.
    public CarController carController;
    public TextMeshProUGUI posicionBacheText; // Texto para mostrar la posici�n del bache.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bachesText.text = "Baches totales: " + carController.contadorBaches;
        posicionBacheText.text = "�ltimo bache en: (" + carController.bachePosition.x.ToString("F2") + ", " + carController.bachePosition.y.ToString("F2") + ", " + carController.bachePosition.z.ToString("F2") + ")";
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
