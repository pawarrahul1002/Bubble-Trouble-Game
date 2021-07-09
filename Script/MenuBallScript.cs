using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBallScript : MonoBehaviour
{
    public Vector2 startForce;
    
    public Rigidbody2D rb;
    void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }
}
