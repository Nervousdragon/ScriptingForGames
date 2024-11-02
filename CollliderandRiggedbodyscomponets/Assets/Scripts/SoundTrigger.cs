
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
       audioSource = GetComponent<AudioSource>();  
    }

    private void OnTriggerEnter(Collider Other)
    {
       audioSource.Play(); // Play the attached sound effect 
    }
}
