﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Movement : MonoBehaviour
{
    Rigidbody rbd;
    bool ret, trig, st;
    public float time_1, time_max = 2.0f, vel = 10.0f, vel_add;
    private float posx, posz;
    private int i = 1, j=1;
    public P_Movement p_movement;
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }
    void Update()
    {
        vel_add = p_movement.points * 0.2f;
        rbd.velocity = new Vector3(-1, 0, 0) * (vel+vel_add);
        if (ret)
        {
            if (i == j)
            {
                posz = Random.Range(11.0f, -11.0f);
                j++;
            }
            rbd.transform.position = new Vector3(23.12f, .5f, posz);
            if ((Time.time - time_1) >= time_max)
            {   
                ret = false;
                i++;
            }
        }
    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            ret = true;
            time_1 = Time.time;
        }
        if (col.gameObject.CompareTag("Wall"))
        {
            ret = true;
            time_1 = Time.time;
        }
    }
}