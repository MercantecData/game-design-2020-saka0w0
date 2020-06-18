using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float hostage = 0;

    public Text countDownText;
    public Text loseText;

    public TextMeshProUGUI countHostage;
    private void OnTriggerEnter2D(Collider2D myObject)
    {
        if (myObject.transform.tag == "hostages")
        {
            hostage++;
            countHostage.text = hostage.ToString();
            Destroy(myObject.gameObject);

            if (hostage == 6) 
            {
                loseText.text = "You saved all the hostages!";

                Time.timeScale = 0;

            }
            
        }
        if (myObject.transform.tag == "Enemy") 
        {

            loseText.text = "You lost! \n The butcher caught you!";

            Time.timeScale = 0;

        }
    }
}
