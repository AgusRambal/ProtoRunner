using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SAcore : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;

    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
    }

    
    void Update()
    {
        scoreText.text = (int)scoreAmount + " Score";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
 