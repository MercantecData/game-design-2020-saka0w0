using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private float hostage = 0;

    public Text countDownText;
    public Text loseText;
    int countDownNumber = 3;
    float timer;

    public TextMeshProUGUI countHostage;
    private void OnTriggerEnter2D(Collider2D myObject)
    {
        if (myObject.transform.tag == "hostages")
        {
            hostage++;
            countHostage.text = hostage.ToString();
            Destroy(myObject.gameObject);

            if (hostage == 2)
            {
                loseText.text = "You saved all the hostages!\n level 2 will start in 5 sek. if you dont want to play this level please press new game";
                StartCoroutine("newLevel");

            }

        }
        if (myObject.transform.tag == "Enemy")
        {

            loseText.text = "You lost! \n The butcher caught you!";
            Time.timeScale = 0;
        }
        IEnumerator newLevel()
        {
            Time.timeScale = 0;
            float pauseTime = Time.realtimeSinceStartup + 5;
            while (Time.realtimeSinceStartup < pauseTime)
                yield return 0;
            Time.timeScale = 1;
            SceneManager.LoadScene("Level2");
        }
    }
}
