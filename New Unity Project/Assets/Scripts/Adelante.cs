using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adelante : MonoBehaviour
{
    public float velocidad = 20;
    private int limiteZ = 13;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        if(transform.position.z > limiteZ)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -limiteZ)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
