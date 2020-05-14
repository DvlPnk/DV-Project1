using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obst_Move_N3 : MonoBehaviour
{
    Rigidbody rbd;
    public float time_1, time_max = 2.0f, vel = 15.0f;
    int i = 1;
    public P_M_N3 p_move;
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rbd.velocity = new Vector3(-1, 0, 0) * vel;
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
