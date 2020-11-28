using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ParticulasArtornillador : MonoBehaviour
{

    public bool tocando;
    public OVRScreenFade fade;

    private void Start()
    {
        fade = FindObjectOfType<OVRScreenFade>();
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            StartCoroutine(LoadAsync("MainScene"));
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Madera" || other.tag == "Piedra")
        {
            tocando = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Madera" || other.tag == "Piedra")
        {
            tocando = false;
        }
    }


    public IEnumerator LoadAsync(string scene)
    {
        StartCoroutine(fade.Fade(0f, 1f));
        yield return new WaitForSeconds(2f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
