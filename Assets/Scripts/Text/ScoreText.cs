using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI StarScore;

    public static int Score;
    
    void Start()
    {
        StarScore =GameObject.Find("Canvas/StarScore").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        StarScore.text = "Score="+Score.ToString();
    }
}
