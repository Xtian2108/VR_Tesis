using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaerHumanos : MonoBehaviour
{
    public Rigidbody[] listaDeHumanos;
    public float segundosParaQueCaigan;
    public GameObject cenotafio;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(segundosParaQueCaigan);
        for(int i=0; i<listaDeHumanos.Length; i++)
        {
            listaDeHumanos[i].useGravity = true;
        }
        yield return new WaitForSeconds(segundosParaQueCaigan - 1);
        cenotafio.SetActive(true);
    }
}
