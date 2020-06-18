using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player" && other.tag != "wall" && other.tag != "hostages")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        if (other.tag == "wall") 
        {
            Destroy(this.gameObject);
        }
    } 
}
