using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    AudioSource sound;
    void Start()
    {
        animator = GetComponent<Animator>(); //connection to animator in Unity      
        sound = GetComponent<AudioSource>(); //connection to animator in Unity      

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("OpenState", true); //to open the door
        sound.PlayDelayed(0.8f);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("OpenState", false); //to close the door
        sound.PlayDelayed(0.8f);

    }
}
