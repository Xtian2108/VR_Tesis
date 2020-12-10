using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaerHumanos : MonoBehaviour
{
    public Rigidbody[] listaDeHumanos;
    public float segundosParaQueCaigan;
    public GameObject cenotafio;
    public float tiempoParaCambiarDeEscena = 10f;
    private GoToScene goToScene;
    IEnumerator Start()
    {
        goToScene = GetComponent<GoToScene>();
        yield return new WaitForSeconds(segundosParaQueCaigan);
        for (int i = 0; i < listaDeHumanos.Length; i++)
        {
            listaDeHumanos[i].useGravity = true;
        }
        yield return new WaitForSeconds(segundosParaQueCaigan + 3);
        for (int i = 0; i < listaDeHumanos.Length; i++)
        {
            listaDeHumanos[i].gameObject.SetActive(false);
        }
        cenotafio.SetActive(true);
        yield return new WaitForSeconds(tiempoParaCambiarDeEscena);
        goToScene.GoScene("Parte6");
    }
}
