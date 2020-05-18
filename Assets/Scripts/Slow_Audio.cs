using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Slow_Audio : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audio;
    public P_Movement player;
    int i = 1, j = 1;
    float time1;
    bool aud = true;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (player.r == 1 && aud==true && player.slowfast == true)
        {
            if (i == j)
            {
                time1 = Time.time;
                j++;
                Debug.Log(time1);
            }
            audio.Play();
            aud = false;
        }
        if(Time.time - time1 >= 1.5f && aud==false)
        {
            aud = true;
            i++;
        }*/
    }
}
