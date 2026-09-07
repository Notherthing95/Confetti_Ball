using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Numerics;

public class TimeAnnounce : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI announce;

    //UI取得
    public GameObject announceText;

    //フラグ取得用
    CountdownTimer script;

    //表示用
    private int _countValue;

    //カメラ中央の右端から左端

    void Start()
    {

        script = this.GetComponent<CountdownTimer>();
    }

    void Update()
    {
        if (script.countDown == 90 || script.countDown == 60 || script.countDown == 30)
        {
            //表示用に数値をint変換(切り上げ)
            _countValue = Mathf.CeilToInt(script.countDown);

            //時間を表示する
            announce.text = "残り" + _countValue.ToString() + "秒";

            //インスタンスを生成
            Instantiate(announceText);
        }
    }
}