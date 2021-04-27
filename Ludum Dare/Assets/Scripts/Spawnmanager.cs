using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] Spawnpoints;
    private Rigidbody rigb;
    public Vector3[] spawningpoints;

    public GameObject congrats;
    public GameObject restart;
    public GameObject homescrren;
    public GameObject pause;

    public Animator anim;

    public GameObject panel;

    public GameObject finishpanel;


    public int spawnpoint=0;

    void Start()
    {
        anim = panel.GetComponent<Animator>();
        rigb = GetComponent<Rigidbody>();
        spawnpoint = 0;

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            spawnpoint = collision.gameObject.name.Length;




        }
        if (collision.gameObject.tag == "ground")
        {
            respawn();
        }
        if (collision.gameObject.tag == "Finish")
        {
            Time.timeScale = 0;
            finishpanel.SetActive(true);
            homescrren.SetActive(true);
            congrats.SetActive(true);
            restart.SetActive(true);
            pause.SetActive(false);
        }


    }
    public void respawn()
    {
        anim.Play("respawn transition");


        rigb.velocity = Vector3.zero;
        rigb.angularVelocity = Vector3.zero;
        transform.position = spawningpoints[spawnpoint - 1];
    }
}
