using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Pausegame : MonoBehaviour
{
    public GameObject airplane;
    private AudioSource audio1;
    public Sprite pause;
    public Sprite start;
    public GameObject[] panel;

    void Start()
    {

        audio1 = airplane.GetComponent<AudioSource>();
        
    }
    public void Gamepaused()
    {
        if(Time.timeScale == 0)
        {
            audio1.UnPause();
            respawn();
            
        }
        else if (Time.timeScale == 1)
        {
            audio1.Pause();
            for (int i = 0; i < panel.Length; i++)
            {
                panel[i].SetActive(true);
            }
            Time.timeScale = 0;
            GetComponent<Image>().sprite = start;
    
        }


    }
    public void respawn()
    {
        for (int i = 0; i < panel.Length; i++)
        {
            panel[i].SetActive(false);
        }

        Time.timeScale = 1;
        GetComponent<Image>().sprite = pause;
    }
}
