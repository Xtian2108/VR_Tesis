using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCanvases : MonoBehaviour
{
    public GameObject[] canvases;
    private GoToScene goToScene;
    private bool cambiando;
    private void Start()
    {
        goToScene = GetComponent<GoToScene>();
    }
    void Update()
    {
        if (!canvases[0].activeSelf &&
            !canvases[1].activeSelf &&
            !canvases[2].activeSelf &&
            !canvases[3].activeSelf &&
            !canvases[4].activeSelf &&
            !cambiando)
        {
            cambiando = true;
            goToScene.GoScene("Parte3");
        }
    }
}