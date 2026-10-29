using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpeechHandler : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip speechSFX;

    void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
       {
           // Trigger the NPC speech here
           Debug.Log("Player entered NPC speech trigger area.");
           // You can add your speech logic here, such as displaying dialogue or playing audio.

            sfxSource.clip = speechSFX; // Assign the NPC speech audio clip to the AudioSource
            sfxSource.Play(); // Play the NPC speech audio


        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Stop the NPC speech here
            Debug.Log("Player exited NPC speech trigger area.");
            // You can add your logic here to stop the dialogue or audio
            
            sfxSource.Stop(); // Stop the NPC speech audio
        }
    }


}
