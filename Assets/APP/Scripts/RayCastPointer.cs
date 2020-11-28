using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class RayCastPointer : MonoBehaviour
{
    public VRTK_StraightPointerRenderer straightPointerRenderer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(straightPointerRenderer.GetPointerObjects());
    }
}
