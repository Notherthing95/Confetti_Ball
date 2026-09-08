using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FirstCountdown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countFirst;

    //カウントダウン
    public float countDownFirst = 3.0f;
    //表示用
    private int _countFirstValue;
    //カウントダウン開始用フラグ
    public int start = 0; 

    void Start()
    {
        countDownFirst = 3.0f;
        //タイムラグ調整用
        countDownFirst++;
    }

    void Update()
    {
        if (countDownFirst >= 0.0f)
        {
            //カウントダウン
            countDownFirst -= Time.unscaledDeltaTime;

            //表示用に数値をint変換(切り上げ)
            _countFirstValue = Mathf.CeilToInt(countDownFirst) - 1;

            //時間を表示する
            countFirst.text = _countFirstValue.ToString();

            //countdownが0以下になったとき
            
        }

        if (countDownFirst <= 1.0f)
        {        
            if (countDownFirst <= 0.0f)
            {
                countDownFirst = 0.0f;
                countFirst.text = "";
                start = 1;
            }
            else 
            {
                countFirst.text = "START";
            }
        }
    }
}
