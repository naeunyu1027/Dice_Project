using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    public void Sound()
    {
        AudioSource.Play();
    }
    
}
