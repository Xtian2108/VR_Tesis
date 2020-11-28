using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SierraController : MonoBehaviour
{

    public GameObject madera;
    public float timer;
    public bool cortando;
    private void Update()
    {
        if (cortando == true)
        {
            timer += Time.deltaTime;
            if (timer >= 2f)
            {
                madera.GetComponent<Animator>().enabled = true;
            }
        }
        else
        {
            timer = 0;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Madera")
        {
            cortando = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        cortando = false;
    }
}
