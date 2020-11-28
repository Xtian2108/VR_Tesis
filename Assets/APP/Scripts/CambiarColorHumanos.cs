using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorHumanos : MonoBehaviour
{
    private TocarBoton tocarBoton;
    public int numeroDeOrden;
    public GameObject humano;
    public bool yaCambio;

    public void Start()
    {
        tocarBoton = FindObjectOfType<TocarBoton>();
    }

    public void Update()
    {
        if (tocarBoton.contador == numeroDeOrden)
        {
            StartCoroutine(CambiarColor());
        }
    }

    IEnumerator CambiarColor()
    {
        yield return new WaitForSeconds(1.0f);
        if(yaCambio == false)
        {
            humano.GetComponent<SkinnedMeshRenderer>().materials[0].color = Color.red;
            yaCambio = true;
        }
        yield return null;
    }
}
