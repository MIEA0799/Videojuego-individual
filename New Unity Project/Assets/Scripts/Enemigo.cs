using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private Rigidbody EnemigoRB;
    private GameObject Jugador;
    private float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        EnemigoRB = GetComponent<Rigidbody>();
        Jugador = GameObject.Find("Jugador");
    }

    // Update is called once per frame
    void Update()
    {
        EnemigoRB.AddForce((Jugador.transform.position - transform.position).normalized * speed);

        if(transform.position.y < 1)
        {
            Destroy(gameObject);
        }
    }
}
