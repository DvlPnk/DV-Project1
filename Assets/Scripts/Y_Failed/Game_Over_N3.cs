using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over_N3 : MonoBehaviour
{
    public P_M_N3 player;
    public GameObject fail;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.vida == 0)
        {
            Time.timeScale = 0;
            fail.SetActive(true);
        }
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Tut");
    }
    public void Quit()
    {
        fail.SetActive(false);
        SceneManager.LoadScene("M_Menu");
    }
}
