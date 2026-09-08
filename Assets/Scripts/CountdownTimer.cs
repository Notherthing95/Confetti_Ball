using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI count;
    [SerializeField] TextMeshProUGUI countFirst;

    //フラグ取得用
    FirstCountdown script;

    //カウントダウン
    public float countDown;
    //表示用
    private int _countValue;

    //画面遷移用ラグ
    private float _rag = 0;

    //カウントダウン開始用フラグ
    //private int _countDownFlag = 0;

    void ChangeScene()
    {
        SceneManager.LoadScene("ResultScene");
    }

    void Start() 
    {
        //script = countFirst.GetComponent<FirstCountdown>();
        
        script = this.GetComponent<FirstCountdown>();
        //countDown;
    }

    void Update()
    {
        if (script.start == 1 || script.start == 2)
        {
            if (script.start == 1 && Time.timeScale == 0)
            {                
                //Debug.Log("start:" + script.start);
                script.start = 2;
                Time.timeScale = 1.0f;
            }
            
            //カウントダウン
            countDown -= Time.deltaTime;

            //表示用に数値をint変換(切り上げ)
            _countValue = Mathf.CeilToInt(countDown);

            //時間を表示する
            count.text = _countValue.ToString();

            //countdownが0以下になったとき
            if (countDown <= 0)
            {
                count.text = "TIME UP!!";

                Time.timeScale = 0;

                //time Time.unscaledDeltaTime;
            }

            if (Time.timeScale == 0 && countDown <= 0)
            {
                _rag += Time.unscaledDeltaTime;
            }

            if (_rag >= 1.5f)
            {
                ChangeScene();
            }
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}