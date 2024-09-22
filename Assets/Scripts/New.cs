using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public AudioClip splashSound;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        transform.position = pos;

        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Audio.Play(splashSound);
        other.gameObject.GetComponent<Fruit>().Slice();
    }
}
