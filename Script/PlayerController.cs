using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float speed = 4f;
    public Rigidbody2D rb;
    private float movement = 0f;
    public Image gameOverImage;
    private float timeSpend = 0;
    private bool runTimer = true;
    
    // private AudioSource audioSource;
    // public AudioClip[] PlayerSounds;


    //  private void Awake()
    // {
    //     audioSource = GetComponent<AudioSource>();
    // }

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        if (runTimer)
        {
            Timer();
        }
    }

    void Timer()
    {
        timeSpend += Time.deltaTime;
        float second = Mathf.FloorToInt(timeSpend % 60);
        timeText.text = "Time : " + second;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * speed * Time.fixedDeltaTime, 0f));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Ball")
        {
            runTimer = false;
            // Debug.Log("Game Over");
            gameObject.SetActive(false);
            gameOverImage.gameObject.SetActive(true);
        }
    }
}
