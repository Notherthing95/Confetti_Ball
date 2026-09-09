using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    static public float Score = 0;
    // static public float HiScore = 0;
    static public float ScoreTime = 0;
    // static public float HiScoreTime = 0;

    public GameObject[] Circles;
    public GameObject[] correctCircles;

    public bool isGameScene;
    /// <summary>
    /// ‚±‚±‚©‚ç‰º‚ÍResultScene‚Å‚Ì‚Ý“ü‚ê‚é‚±‚Æ
    /// </summary>
    [SerializeField] bool isResultScene;
    [SerializeField] TextMeshProUGUI scoreTimeText;
    [SerializeField] ResultManager resultManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString() + "/" + Circles.Length.ToString();
        if (isResultScene && Score == Circles.Length)
        {
            resultManager.isAllCorrect = true;
            scoreTimeText.text = Score.ToString();
        }

        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
