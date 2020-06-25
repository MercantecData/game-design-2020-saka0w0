using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class miniMap : MonoBehaviour
{
    public Transform Player;
    public Camera MainCamera;
    public bool rotate = true;

    // Start is called before the first frame update
    void Start()
    {

        SetPosition();
        SetRotation();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Player != null)
        {
            SetPosition();
            if (rotate && MainCamera)
            {
                SetRotation();
            }
        }

    }
    private void SetRotation()
    {
        transform.rotation =
            Quaternion.Euler(90.0f, MainCamera.transform.eulerAngles.y, 0.0f);
    }
    private void SetPosition()
    {
        var newPos = Player.position;
        newPos.y = transform.position.y;

        transform.position = newPos;
    }
}
