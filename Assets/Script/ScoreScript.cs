using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int ScoreValue;
    private TextMeshProUGUI scoreText;
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        ScoreValue = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
         scoreText.text = "Score:" + ScoreValue;
    }
}
