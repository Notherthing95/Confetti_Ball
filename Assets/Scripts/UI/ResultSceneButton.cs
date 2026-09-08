using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultSceneButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        ScoreManager.Score = 0;
        ScoreManager.ScoreTime = 0;
        SceneManager.LoadScene("TitleScene");
    }
}
