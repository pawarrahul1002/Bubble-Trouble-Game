using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Vector2 startForce;
    public GameObject nextBall;
    public Rigidbody2D rb;
    void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void Split()
    {

        if (nextBall != null)
        {
            GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<BallScript>().startForce = new Vector2(2f,5f); 
            ball2.GetComponent<BallScript>().startForce = new Vector2(-2f,5f); 
        }

        Destroy(gameObject);
    }
}
