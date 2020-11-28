using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MangoEsmeriladoraController : MonoBehaviour
{
    public BoxCollider sierraCol;
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
                sierraCol.enabled = true;
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
                sierraCol.enabled = false;

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
        sierraCol.enabled = false;
        anim.enabled = false;
        if (asource.isPlaying)
        {
            asource.Stop();
        }
    }
}
