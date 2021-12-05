using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    // Update is called once per frame
    void Update()
    {
        // Con esto indicamos hacia que direcci�n ha de rotar el proyectil cuando salga
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
               SpawnProyectil(Quaternion.Euler(0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProyectil(Quaternion.Euler(0, 0, 180));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProyectil(Quaternion.Euler(0, 0, -90));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProyectil(Quaternion.Euler(0, 0, 90));
        }
    }
    public void SpawnProyectil(Quaternion rotate)
    {
        //Instanciamos/Convocamos el proyectil indic�ndole ya que va a tener rotaci�n, de ah� el quaternion
        Instantiate(projectilePrefab, transform.position,
        rotate);
    }
}

