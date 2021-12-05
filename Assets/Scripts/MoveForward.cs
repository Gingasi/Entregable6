using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 7f;
    private float upperLim = 40f;
    private float lowerLim = -20f;

    void Update()
    {
        // Movimiento hacia adelante del Proyectil
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Se destruye bola de energía
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }
    }
}
