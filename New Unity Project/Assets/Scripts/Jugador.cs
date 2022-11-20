using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public float aceleracion = 2;
    private Rigidbody JugadorRB;
    private GameObject PuntoCentral;
    public bool Activo;
    public float FuerzaPW = 1;
    // Start is called before the first frame update
    void Start()
    {
        JugadorRB = GetComponent<Rigidbody>();
        PuntoCentral = GameObject.Find("PuntoCentral");
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        JugadorRB.AddForce(PuntoCentral.transform.forward * aceleracion * vertical);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Activo = true;
            Destroy(other.gameObject);
            StartCoroutine(Tiempo());
        }
    } 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo") && Activo)
        {
            Rigidbody EnemigoRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 Alejar = (collision.gameObject.transform.position - transform.position);

            EnemigoRB.AddForce(Alejar * FuerzaPW, ForceMode.Impulse);
        }
    }

    IEnumerator Tiempo()
    {
        yield return new WaitForSeconds(5);
        Activo = false;
    }
}
