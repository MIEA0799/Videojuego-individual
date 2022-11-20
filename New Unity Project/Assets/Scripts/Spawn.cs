using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemigo;
    private int contador;
    private int NoEnemigos;
    //public int puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spawner(1);
    }

    void Spawner(int cantidad)
    {
        for(int i= 0; i < cantidad; i++)
        {
            Instantiate(enemigo, GenerarPosicion(), enemigo.transform.rotation);
        }
    }

    Vector3 GenerarPosicion()
    {
        return new Vector3(Random.Range(5.94f, 25.48f), 4, Random.Range(4,22.87f));
    }

    // Update is called once per frame
    void Update()
    {
        contador = FindObjectsOfType<Enemigo>().Length;
        if (contador == 0)
        {
            NoEnemigos++;
            Spawner(NoEnemigos);
            //puntos = puntos + 1;
            //Puntos.text = puntos.ToString();
        }
    }
}
