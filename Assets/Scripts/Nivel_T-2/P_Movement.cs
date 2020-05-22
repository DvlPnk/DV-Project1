using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class P_Movement : MonoBehaviour
{
    Rigidbody rbd;
    private float vel=10.0f;
    private float movx, movz;
    public bool slowfast;
    private float time_1, time_2;
    private int i = 1, j = 1;
    public int r=0;
    public int vida = 2, points = 0;
    public int temp = 0;
    public Pause_M pause;
    void Start()
    {
        rbd =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movx = Input.GetAxis("Horizontal");
        movz = Input.GetAxis("Vertical");
        rbd.velocity = new Vector3(movx, 0, movz) *vel;
        if (slowfast)
        {
            if (i == j)
            {
                r = Random.Range(1, 3);
                j++;
            }
            if (Time.time - time_1 <= 2)
            {
                if (r == 1)
                {
                    temp = r;
                    Time.timeScale = 0.5f;
                    time_2 = 0.5f;
                }
                else
                {
                    temp = r;
                    Time.timeScale = 1.5f;
                    time_2 = 1.5f;
                }
            }
            else
            {
                temp = 0;
                Time.timeScale = 1.0f;
                time_2 = 1.0f;
                i++;
            }
            if (pause.pause == true)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = time_2;
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("SlowFast"))
        {
            time_1 = Time.time;
            slowfast = true;
            points++;
        }
        if (col.gameObject.CompareTag("Obst"))
        {
            vida--;
            gameObject.transform.position = new Vector3(-16.8f, 1, 0);
        }
    }
}