using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_C : MonoBehaviour
{
    public GameObject Fast;
    public GameObject Slow;
    public GameObject Crash;
    public P_Movement player;
    void Start()
    {

    }
    void Update()
    {
        if (player.temp == 1)
        {
            Slow.SetActive(true);
        }
        if (player.temp == 2 || player.temp == 3)
        {
            Fast.SetActive(true);
        }
        if (player.temp == 0)
        {
            Slow.SetActive(false);
            Fast.SetActive(false);
        }
        if (player.vida == 1)
        {
            Crash.SetActive(true);
        }
    }
}
