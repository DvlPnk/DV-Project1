using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obst_Move : MonoBehaviour
{
    Rigidbody rbd;
    bool ret, trig, st;
    public float time_1, time_max = 2.0f, vel = 10.0f;
    private float posx, posz;
    private int i = 1, j = 1;
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rbd.velocity = new Vector3(-1, 0, 0)*vel;
    }
    private void FixedUpdate()
    {

    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (col.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
