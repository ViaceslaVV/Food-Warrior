using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
    }

    public static AudioSource source;
    // Start is called before the first frame update
   public static void Play(AudioClip clip)
    {
        source.PlayOneShot(clip);

    }
}
