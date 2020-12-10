using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TocarBoton : MonoBehaviour
{
    public GameObject realBoton;
    private Vector3 botonNoApretado;
    public Vector3 botonApretado;
    public TextMeshProUGUI txtmesh;
    public int contador;
    public float timer;

    private GoToScene goToScene;

    public int maxCont = 10;

    private void Start()
    {
        botonNoApretado = realBoton.transform.localScale;
        goToScene = GetComponent<GoToScene>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mano")
        {
            int randomNumber = Random.Range(0, 4);
            realBoton.transform.localScale = botonApretado;
            if (randomNumber == 0 || randomNumber == 1)
            {
                contador++;
                txtmesh.text = contador.ToString();
            }

            if (contador == maxCont)
            {
                goToScene.GoScene("Parte5");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Mano")
        {
            realBoton.transform.localScale = botonNoApretado;
        }
    }

}
