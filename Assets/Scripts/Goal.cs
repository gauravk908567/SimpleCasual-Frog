using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    private GameObject frogplayer;
    private Vector3 playerinipos;

    public Text ScoreText;
    private int score;


    private void Awake()
    {
        frogplayer = GameObject.FindWithTag("Player");
        playerinipos = frogplayer.transform.position;

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            target.transform.position = playerinipos;
            score += 100;
            ScoreText.text = score.ToString();

        }
    }

}
