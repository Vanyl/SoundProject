using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        myAnimationController.SetBool("character_nearby", true);
        sound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        myAnimationController.SetBool("character_nearby", false);
        sound.Stop();
    }
}
