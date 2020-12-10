using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextosController : MonoBehaviour
{

    public float tiempoDeEsperaParaBorrar = 4f;
    public GameObject[] textOne;
    public GameObject[] textTwo;
    public GameObject[] textThree;

    private bool parte1 = true;
    private bool parte2 = true;
    private bool parte3 = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MostrarParte1());
    }

    public IEnumerator MostrarParte1()
    {
        while (parte1)
        {
            for(int i = 0; i < textOne.Length; i++)
            {
                yield return new WaitForSeconds(1f);
                textOne[i].SetActive(true);
            }
            StartCoroutine(MostrarParte2());
            parte2 = true;
            parte1 = false;
        }
    }

    public IEnumerator MostrarParte2()
    {
        while (parte2)
        {
            for (int i = 0; i < textTwo.Length; i++)
            {
                yield return new WaitForSeconds(0.8f); //Tiempo
                textTwo[i].SetActive(true);
            }
            StartCoroutine(MostrarParte3());
            parte3 = true;
            parte2 = false;
        }
    }

    public IEnumerator MostrarParte3()
    {
        while (parte3)
        {
            for (int i = 0; i < textThree.Length; i++)
            {
                yield return new WaitForSeconds(0.4f);
                textThree[i].SetActive(true);
            }
            yield return new WaitForSeconds(tiempoDeEsperaParaBorrar);
            StartCoroutine(EsconderParte1());
            StartCoroutine(EsconderParte2());
            StartCoroutine(EsconderParte3());
            parte3 = false;
        }
    }

    public IEnumerator EsconderParte1()
    {
        for (int i = 0; i < textOne.Length; i++)
        {
            yield return new WaitForSeconds(1f);
            textOne[i].SetActive(false);
        }
    }

    public IEnumerator EsconderParte2()
    {
        for (int i = 0; i < textTwo.Length; i++)
        {
            yield return new WaitForSeconds(1f);
            textTwo[i].SetActive(false);
        }
    }

    public IEnumerator EsconderParte3()
    {
        for (int i = 0; i < textThree.Length; i++)
        {
            yield return new WaitForSeconds(1f);
            textThree[i].SetActive(false);
        }
    }
}
