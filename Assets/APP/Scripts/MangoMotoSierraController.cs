using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MangoMotoSierraController : MonoBehaviour
{
    public Animator anim;
    public AudioSource asource;

    public GameObject particula;

    public ParticulasArtornillador pa;

    public GameObject sierra;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Mano")
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                sierra.GetComponent<BoxCollider>().enabled = true;
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
                sierra.GetComponent<BoxCollider>().enabled = false;
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
        particula.SetActive(false);
        anim.enabled = false;
        if (asource.isPlaying)
        {
            asource.Stop();
        }
    }
}
