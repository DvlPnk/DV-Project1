using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class P_M_N3 : MonoBehaviour
{
    Rigidbody rbd;
    private float vel = 15.0f;
    private float movx, movz;
    bool slowfast;
    private float time_1, time_2;
    private int i = 1, j = 1, r, k = 1;
    public int vida = 2, points = 0;
    public float temp=0;
    public Pause_M pause;
    public Game_Over_N3 game;
    void Start()
    {
        Time.timeScale = 1;
        rbd = GetComponent<Rigidbody>();
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
            if (pause.pause == true || game.dead == true)
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
