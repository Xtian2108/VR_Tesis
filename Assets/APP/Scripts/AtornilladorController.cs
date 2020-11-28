using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class AtornilladorController : MonoBehaviour
{
    public Animator anim;

    public GameObject particula;

    public ParticulasArtornillador pa;
    public AudioSource asource;
    public bool grabbed;
    private void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
        GetComponent<VRTK_InteractableObject>().InteractableObjectUngrabbed += new InteractableObjectEventHandler(ObjectUngrabbed);
    }


    private void Update()
    {
        if (grabbed)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                if (!asource.isPlaying)
                {
                    asource.Play();
                }
                anim.enabled = true;

                if (pa.tocando == true)
                {
                    particula.SetActive(true);
                }
                else
                {
                    particula.SetActive(false);
                }
            }
            else
            {
                if (asource.isPlaying)
                {
                    asource.Stop();
                }
                anim.enabled = false;
                particula.SetActive(false);
            }
        }
    }

    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        grabbed = true;

    }

    private void ObjectUngrabbed(object sender, InteractableObjectEventArgs e)
    {
        grabbed = false;

    }
}
