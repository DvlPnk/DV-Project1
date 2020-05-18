using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlay : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audio;
    float time1, i = 1;
    bool timer;
    void Start()
    {
        Time.timeScale = 1;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time1 >= 1.5f && i>1)
        {
            SceneManager.LoadScene("Tut");
        }
    }
    public void Play()
    {
        audio.Play();
        if (i==1)
        {
            time1 = Time.time;
            i++;
        }
    }
}
