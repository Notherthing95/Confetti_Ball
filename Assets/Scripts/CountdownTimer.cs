using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI count;
    [SerializeField] TextMeshProUGUI countFirst;

    //フラグ取得用
    FirstCountdown script;

    //カウントダウン
    public float countDown = 120.0f;
    //表示用
    private int _countValue;

    //カウントダウン開始用フラグ
    //private int _countDownFlag = 0;

    
    void Start() 
    {
        //script = countFirst.GetComponent<FirstCountdown>();
        script = this.GetComponent<FirstCountdown>();
        countDown = 120.0f;
    }

    void Update()
    {
        if (script.start == 1)
        {
            //カウントダウン
            countDown -= Time.deltaTime;

            //表示用に数値をint変換(切り上げ)
            _countValue = Mathf.CeilToInt(countDown);

            //時間を表示する
            count.text = _countValue.ToString() + "秒";

            //countdownが0以下になったとき
            if (countDown <= 0)
            {
                count.text = "TIME UP!!";
            }
        }
    }
}