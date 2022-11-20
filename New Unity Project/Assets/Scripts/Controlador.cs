using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //Linea Para usar el botón

public class Controlador : MonoBehaviour
{
    public List<GameObject> Objetivos;
    public TextMeshProUGUI texto;
    public bool activo;
    public Button boton;
    // Start is called before the first frame update
    void Start(){}

    public void IniciarJuego(int i)
    {
        activo = true;
        StartCoroutine(Iniciar(i));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        texto.gameObject.SetActive(true);
        boton.gameObject.SetActive(true);
        activo = false;
    }

    IEnumerator Iniciar(int D)
    {
        while (activo)
        {
            yield return new WaitForSeconds(D);
            int index = Random.Range(0, Objetivos.Count);
            Instantiate(Objetivos[index]);
        }
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
