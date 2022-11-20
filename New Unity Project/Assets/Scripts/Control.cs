using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int velocidad = 10;
    public int[] arreglo;
    private float limiteX = 7;
    private bool boton;
    public float inp;
    public GameObject proyectil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inp = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * velocidad * inp);

        if (transform.position.x >limiteX)
        {
            transform.position = new Vector3(limiteX, transform.position.y, transform.position.z);
        }
        if (transform.position.x < - limiteX)
        {
            transform.position = new Vector3(-limiteX, transform.position.y, transform.position.z);
        }

        boton = Input.GetKeyDown(KeyCode.Space);
        if (boton)
        {
            Instantiate(proyectil, transform.position + new Vector3(0, 0, 1), proyectil.transform.rotation);
        }
    }
}
