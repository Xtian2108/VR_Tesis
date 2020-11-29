using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AumentarNumero : MonoBehaviour
{
    public OVRScreenFade fade;
    public int contador;
    public TextMeshProUGUI textMesh;
    public GameObject textosArriba1;
    public GameObject textosArriba2;
    public GameObject hashtag1;
    public GameObject hashtag2;
    public GameObject verFalsosComentarios;
    public GameObject darOpinion;

    public GameObject cabeza;

    private bool pasarEscena;

    public void AumentarContador()
    {
        StartCoroutine(InteraccionBoton());
    }

    public void Update()
    {
        if(contador == 2)
        {
            textosArriba1.SetActive(true);
            textosArriba2.SetActive(true);
        }

        if(contador == 3)
        {
            hashtag1.SetActive(true);
        }

        if(contador == 4)
        {
            hashtag2.SetActive(true);
        }

        if(contador == 5)
        {
            verFalsosComentarios.SetActive(true);
        }

        if(contador == 6)
        {
            darOpinion.SetActive(true);
            if(pasarEscena == false)
            {
                StartCoroutine(InteraccionFinal(3f, "Parte4"));
            }
        }
    }

    public IEnumerator InteraccionBoton()
    {
        contador++;
        textMesh.text = contador.ToString();
        this.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(1.0f);
        this.GetComponent<Button>().interactable = true;
        yield return null;
    }


    public IEnumerator InteraccionFinal(float timer,string scene)
    {
        pasarEscena = true;
        yield return new WaitForSeconds(timer);
        //fade.fadeColor = Color.red;
        cabeza.SetActive(true);
        StartCoroutine(fade.Fade(0f, 1f));
        yield return new WaitForSeconds(2f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
