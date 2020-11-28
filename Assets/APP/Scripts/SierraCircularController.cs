using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class SierraCircularController : MonoBehaviour
{

    public GameObject sierra;
    public Animator anim;

    public AudioSource asource;
    public bool grabbed;

    public GameObject particula;

    public ParticulasArtornillador pa;

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
                sierra.GetComponent<BoxCollider>().enabled = true;

                anim.SetBool("Working", true);

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
                sierra.GetComponent<BoxCollider>().enabled = false;
                anim.SetBool("Working", false);
                particula.SetActive(false);
            }
        }
    }

    public void PlaySound()
    {
        if (!asource.isPlaying)
        {
            asource.Play();
        }
    }

    public void StopSound()
    {
        if (asource.isPlaying)
        {
            asource.Stop();
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
