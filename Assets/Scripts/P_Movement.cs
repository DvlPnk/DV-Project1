using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class P_Movement : MonoBehaviour
{
    Rigidbody rbd;
    private float vel=10.0f;
    private float movx, movz;
    bool slowfast;
    private float time_1;
    private int i = 1, j = 1, r;
    public int vida = 2, points = 0;
    void Start()
    {
        rbd=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        movx = Input.GetAxis("Horizontal");
        movz = Input.GetAxis("Vertical");
        rbd.velocity = new Vector3(movx, 0, movz) *vel;
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
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Zone") && slowfast)
        {
            if (i == j)
            {
                r = Random.Range(1, 3);
                j++;
            }
            if (Time.time - time_1 <= 2) {
                if (r == 1)
                {
                    Time.timeScale = 0.5f;
                }
                else
                {
                    Time.timeScale = 1.5f;
                }
            }
            else
            {
                Time.timeScale = 1.0f;
                i++;
            }
        }
    }
}