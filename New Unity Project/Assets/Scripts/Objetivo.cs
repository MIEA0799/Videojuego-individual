using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objetivo : MonoBehaviour
{
    private Rigidbody ObjetivoRB;
    private float VeMin = 12;
    private float VeMax = 16;
    private float TorMax = 10;
    private float RangoX = 10.5f;
    private float SpawnY = -6.8f;
    private Controlador controlador;
    //private Controlador objeto = new Controlador();
        // Start is called before the first frame update
    void Start()
    {
        controlador = FindObjectOfType<Controlador>();
        ObjetivoRB = GetComponent<Rigidbody>();
        ObjetivoRB.AddForce(FuerzaAleatoria(), ForceMode.Impulse);
        ObjetivoRB.AddTorque(TorqueAleatorio(), TorqueAleatorio(), TorqueAleatorio(), ForceMode.Impulse);
        transform.position = PosicionAleatoria();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 FuerzaAleatoria()
    {
        return Vector3.up * Random.Range(VeMin, VeMax);
    }

    float TorqueAleatorio()
    {
        return Random.Range(-TorMax, TorMax);
    }

    Vector3 PosicionAleatoria()
    {
        return new Vector3(Random.Range(-RangoX, RangoX), SpawnY, 1.1f);
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("E1"))
        {
            controlador.GameOver();
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
