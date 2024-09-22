using System.Collections;
using System.Collections.Generic;
using UnityEditor.Performance.ProfileAnalyzer;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public AudioClip splashSound;
    public ParticleSystem splashParticles;
    public Color splashColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 12f);
    }
    public void Slice()
    {
        Audio.Play(splashSound);
        foreach (Transform child in GetComponentInChildren<Transform>())
        {
            if(child == transform) continue;
            Rigidbody2D rb = child.gameObject.AddComponent<Rigidbody2D>();
            rb.velocity = GetComponent<Rigidbody2D>().velocity + Random.insideUnitCircle;
            rb.angularVelocity = Random.Range(-10f, 10f);
        }

         ParticleSystem particles = Instantiate(splashParticles, transform.position, Quaternion.identity);
        particles.startColor = splashColor;
        transform.DetachChildren();
        Destroy(gameObject);
    }

    
}
