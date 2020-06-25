using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public int Myscene;
    public void Restartlevel() 
    {
        SceneManager.LoadScene(Myscene);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
