using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{

    public int Scenenumber;
    public void buttonclicked()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Scenenumber);
    }
}
