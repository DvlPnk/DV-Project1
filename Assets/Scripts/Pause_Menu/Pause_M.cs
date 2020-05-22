using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_M : MonoBehaviour
{
    public GameObject Pause;
    public bool pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pause = true;
            Time.timeScale = 0;
            Pause.SetActive(true);
        }
    }
    public void Continue()
    {
        pause = false;
        Pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        pause = false;
        Time.timeScale = 1;
        Pause.SetActive(false);
        SceneManager.LoadScene("M_Menu");
    }
}
