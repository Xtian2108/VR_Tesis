using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MangoDemoledorController : MonoBehaviour
{
    public Animator anim;
    public AudioSource asource;

    public GameObject particula;

    public ParticulasArtornillador pa;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Mano")
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                anim.enabled = true;
                if (!asource.isPlaying)
                {
                    asource.Play();
                }

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
                anim.enabled = false;
                if (asource.isPlaying)
                {
                    asource.Stop();
                }
                particula.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        anim.enabled = false;
        if (asource.isPlaying)
        {
            asource.Stop();
        }
    }
}
