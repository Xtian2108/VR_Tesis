using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoTodasEscn : MonoBehaviour
{
    private static SonidoTodasEscn _instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }


}
