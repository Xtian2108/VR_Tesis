using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SepararTexto : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    private float timer;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();    
    }

    private void Update()
    {
        timer += Time.deltaTime;
        Separar();   
    }

    public void Separar()
    {
        if (isActive)
        {
            textMeshProUGUI.characterSpacing = Mathf.PingPong(timer * 6, 30);
        }
        else
        {
            textMeshProUGUI.characterSpacing = 0;
            timer = 0;
        }
    }

    public void Activar()
    {
        isActive = true;
    }

    public void Desactivar()
    {
        isActive = false;
    }
}
