using UnityEngine;
using TMPro;


public class Sword : MonoBehaviour
{
    public AudioClip splashSound;
    Camera cam;
    public float sliceTime;
    public float maxslice;
    public int combo;
    [SerializeField] AudioClip[] comboSounds;


    

    

    void Start()
    {
        cam = Camera.main;
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        transform.position = pos;

        if(Time.time - sliceTime< maxslice && combo >= 3)
        {
            gameManager.instance.AddScore(combo);

            Audio.Play(comboSounds[combo-3]);

            combo = 1;

            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Audio.Play(splashSound);
        other.gameObject.GetComponent<Fruit>().Slice();

        if(Time.time - sliceTime< maxslice)
        {
            combo++;
        }
        else
        {
            combo = 1;
        }
        sliceTime = Time.time;
    }
    

}