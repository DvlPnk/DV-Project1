using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel_2 : MonoBehaviour
{
    public P_Movement p_move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (p_move.points == 25)
        {
            SceneManager.LoadScene("Nivel_3");
        }
    }
}
