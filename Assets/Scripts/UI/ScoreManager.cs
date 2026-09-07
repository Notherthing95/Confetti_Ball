using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    static public float Score = 0;
    static public float HiScore = 0;
    static public float ScoreTime = 0;
    static public float HiScoreTime = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
    }
}
