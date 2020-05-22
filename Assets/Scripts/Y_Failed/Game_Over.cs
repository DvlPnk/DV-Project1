using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Over : MonoBehaviour
{
    // Start is called before the first frame update
    public P_Movement player;
    public GameObject fail;
    public bool dead = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.vida == 0)
        {
            dead = true;
            Time.timeScale = 0;
            fail.SetActive(true);
        }
        else {
            dead = false;
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
