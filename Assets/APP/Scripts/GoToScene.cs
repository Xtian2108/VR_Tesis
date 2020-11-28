using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{

    public OVRScreenFade fade;


    public void GoScene(string scene)
    {
        StartCoroutine(LoadAsync(scene));
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
