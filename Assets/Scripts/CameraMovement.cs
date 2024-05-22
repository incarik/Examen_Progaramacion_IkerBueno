using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerTrasnform;
    public Vector2 minCameraPosition;
    public Vector2 maxCameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = playerTrasnform.position + new Vector3(0, 0, -10); //para la posicion de la camara para el examen //tambien por si acaso playerTrasnform.position

         float clampX = Mathf.Clamp(desiredPosition.x, minCameraPosition.x, maxCameraPosition.x);
         float clampY = Mathf.Clamp(desiredPosition.y, minCameraPosition.y, maxCameraPosition.y);

         Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);

         transform.position = clampedPosition; // Start is called before the first frame update
    }
}
