using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChainCollisionScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public int count = 0;
    public AudioSource audioSource;
    public AudioClip[] PlayerSounds;
    void OnTriggerEnter2D(Collider2D col)
    {
        ChainScript.isFired = false;
        if (col.tag == "Ball")
        {
            count += 1;
            scoreText.text = "Score : " + count;
            audioSource.PlayOneShot(PlayerSounds[0], 1f);
            col.GetComponent<BallScript>().Split();
        }
    }
}
