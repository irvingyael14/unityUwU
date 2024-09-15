using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2.3f, -5);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Sigue al jugador con el offset
        transform.position = player.transform.position + player.transform.rotation * offset;

        // Alinea la rotación de la cámara con la del jugador
        transform.rotation = player.transform.rotation;
    }
}
