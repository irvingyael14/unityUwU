using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 15f;
    public float turnSpeed = 45f;
    public float horizontal;
    public float vertical;
    public int contadorBaches = 0;
    public Vector3 bachePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Mover el vehiculo para enfrente
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontal);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bache")
        {
            // Acceder al Renderer del bache y cambiar el color a rojo
            Renderer bacheRenderer = other.GetComponent<Renderer>();
            if (bacheRenderer != null)
            {
                bacheRenderer.material.color = Color.red;
            }
            other.GetComponent<Collider>().enabled = false;
            contadorBaches++;
            bachePosition = other.transform.position;
        }
    }
}
