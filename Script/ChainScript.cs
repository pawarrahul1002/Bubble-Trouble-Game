using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainScript : MonoBehaviour
{
    public Transform PlayerController;
    public static bool isFired;
    public float speed = 2f;

    void Start()
    {
        isFired = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isFired = true;
        }


        if (isFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            transform.position = PlayerController.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }


}
