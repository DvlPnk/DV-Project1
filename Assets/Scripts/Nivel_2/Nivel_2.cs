﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel_2 : MonoBehaviour
{
    private float time1, time2 = 1.0f;
    private int i = 1;
    public P_Movement p_move;
    public GameObject nivel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        time1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time1 < time2)
        {
            time1 += 0.1f;
            i = 0;
        }
        if (time1 >= time2 && i == 0)
        {
            Time.timeScale = 1;
            nivel.SetActive(false);
            i = 1;
        }
        if (p_move.points == 25)
        {
            SceneManager.LoadScene("Nivel_3");
        }
    }
}
