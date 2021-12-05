using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private Quaternion Up = Quaternion.Euler(0, 0, 0);
    private Quaternion Down = Quaternion.Euler(0, 0, 180);
    private Quaternion Right = Quaternion.Euler(0, 0, -90);
    private Quaternion Left = Quaternion.Euler(0, 0, 90);

    // Update is called once per frame
    void Update()
    {
        // Con esto indicamos hacia que dirección ha de rotar el proyectil cuando salga
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnProyectil(Up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProyectil(Down);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProyectil(Right);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProyectil(Left);
        }
      
    }
    public void SpawnProyectil(Quaternion rotate)
    {
        //Instanciamos/Convocamos el proyectil indicándole ya que va a tener rotación, de ahí el quaternion
        Instantiate(projectilePrefab, transform.position,
        rotate);
    }
}

