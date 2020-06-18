using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeTime : MonoBehaviour
{
    Text countDownText;

    float timer;
    int countDownNumber = 150;

    public Text loseText;

    // Start is called before the first frame update
    void Start()
    {
        countDownText = GetComponent<Text>();
        countDownText.text = countDownNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1 && countDownNumber > 0) 
        {
            countDownNumber--;
            countDownText.text = countDownNumber.ToString();
            timer = 0;

            if (countDownNumber == 0) 
            {
                loseText.text = "You didn't save the hostages!";
                Time.timeScale = 0;
            }
        }
    }
}
