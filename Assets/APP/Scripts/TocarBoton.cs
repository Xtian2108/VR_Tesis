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
            contador++;
            txtmesh.text = contador.ToString();
            realBoton.transform.localScale = botonApretado;
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
