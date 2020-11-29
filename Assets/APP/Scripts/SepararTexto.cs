using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SepararTexto : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    private float timer;
    public bool isActive;
    public GameObject laser;
    public GameObject esfera;
    // Start is called before the first frame update
    void Start()
    {
        laser = GameObject.Find("[VRTK][AUTOGEN][RightControllerScriptAlias][StraightPointerRenderer_Tracer]");
        esfera = GameObject.Find("[VRTK][AUTOGEN][RightControllerScriptAlias][StraightPointerRenderer_Cursor]");
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
            laser.GetComponent<MeshRenderer>().materials[0].color = Color.red;
            esfera.GetComponent<MeshRenderer>().materials[0].color = Color.red;
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
