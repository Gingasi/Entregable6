
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 7f;
    private float upperLim = 100f;
    private float lowerLim = -20f;
    private float rightLim = 50f;
    private float leftLim = -50f;

    void Update()
    {
        // Movimiento hacia adelante del Proyectil
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Se destruye bola de energía
        if (transform.position.y > upperLim)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerLim)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > rightLim)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < leftLim)
        {
            Destroy(gameObject);
        }
    }
}
