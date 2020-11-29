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

    private void Start()
    {
        botonNoApretado = realBoton.transform.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mano")
        {
            int randomNumber = Random.Range(0,4);
            realBoton.transform.localScale = botonApretado;
            if (randomNumber == 0 || randomNumber == 1)
            {
                contador++;
                txtmesh.text = contador.ToString();
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
