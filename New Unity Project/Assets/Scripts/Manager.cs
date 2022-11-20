using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] enemigos;
    private float limiteX = 7;
    public float inicio = 2;
    public float intervalo = 1.5f;
    private Text mitexto;

    // Start is called before the first frame update
    void Start()
    {
        mitexto = GameObject.Find("Text").GetComponent<Text>();
        mitexto.text = "Hola";
        InvokeRepeating("generar", inicio, intervalo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            generar();
        }
    }

    void generar()
    {
        Vector3 posicion = new Vector3(Random.Range(-limiteX, limiteX), 1f, 10f);
        int index = Random.Range(0, enemigos.Length);
        Instantiate(enemigos[index], posicion, enemigos[index].transform.rotation);
    }
}
