using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CenotafioController : MonoBehaviour
{
    private TextMeshProUGUI texto;
    private int contador;
    private void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        StartCoroutine(AumentarContador());
    }

    public IEnumerator AumentarContador()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            int random = Random.Range(0,3);
            if(random == 1)
            {
                contador++;
                texto.text = contador.ToString();
            }
        }
    }
}
