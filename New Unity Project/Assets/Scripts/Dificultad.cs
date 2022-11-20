using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dificultad : MonoBehaviour
{
    private Button boton;
    private Controlador controlador;
    public GameObject titulo;
    public int dificultad;

    // Start is called before the first frame update
    void Start()
    {
        controlador = FindObjectOfType<Controlador>();
        boton = GetComponent<Button>();
        boton.onClick.AddListener(EstablecerDificultad);
    }

    void EstablecerDificultad()
    {
        controlador.IniciarJuego(dificultad);
        titulo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
