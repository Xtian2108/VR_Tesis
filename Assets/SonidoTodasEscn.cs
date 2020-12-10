using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoTodasEscn : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        var objs = FindObjectOfType<SonidoTodasEscn>();
        if (objs!=null)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }


}
