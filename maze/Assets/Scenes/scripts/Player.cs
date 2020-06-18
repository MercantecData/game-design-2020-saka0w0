using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private float hostage = 0;

    public TextMeshProUGUI countHostage;
    private void OnTriggerEnter2D(Collider2D myObject)
    {
        if (myObject.transform.tag == "hostages")
        {
            hostage++;
            countHostage.text = hostage.ToString();
            Destroy(myObject.gameObject);
            
        }
    }
}
