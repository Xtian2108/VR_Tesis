using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class DesbrozadoraController : MonoBehaviour
{

    public GameObject mango;

    private void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
        GetComponent<VRTK_InteractableObject>().InteractableObjectUngrabbed += new InteractableObjectEventHandler(ObjectUngrabbed);
    }

    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        mango.GetComponent<BoxCollider>().enabled = true;
    }

    private void ObjectUngrabbed(object sender, InteractableObjectEventArgs e)
    {
        mango.GetComponent<BoxCollider>().enabled = false;
    }
}
