using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtsG_Move : MonoBehaviour
{
    public GameObject ObtsG;
    private float time1, genT=1.0f;
    private bool gen, ret;
    private int i = 1, j = 1;
    private float posz, time_1, time_max;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ObtsG, transform.position, transform.rotation);
        gen = true;
        ret=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ret)
        {
            if (i == j)
            {
                posz = Random.Range(11.0f, -11.0f);
                j++;
            }
            Instantiate(ObtsG, transform.position = new Vector3(27.5f,1.5f, posz), transform.rotation);
            if ((Time.time - time_1) >= time_max)
            {
                ret = false;
                i++;
            }
        }
        if (gen)
        {
            time1 = Time.time;
            gen = false;
        }
        if (Time.time - time1 >= genT) {

            gen = true;
            ret = true;
        }
    }
}

