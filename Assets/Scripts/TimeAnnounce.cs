using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Numerics;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;
using UnityEngine.InputSystem.Controls;
using System.Runtime.InteropServices;

public class TimeAnnounce : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI announce;
    //[SerializeField] Canvas canvasTransform;

    //カメラ取得
    //public Camera mainCamera;

    //カメラ中段、端から端の座標
    //Vector3 min;
    //Vector3 max;

    //残り時間を取得
    CountdownTimer script;

    //表示用オブジェクトを取得
    TextMeshProUGUI _timeAnnounceText;

    //表示用オブジェクトの座標
    Vector3 pos;

    //表示用
    private int _countValue;

    //文字が流れているかのフラグ
    private int _thereText = 0;

    //スピード
    public float speed = 1.0f;

    //端から端の距離
    private float distance;

    private void _announceMove()
    {
        //表示用に数値をint変換(切り上げ)
        _countValue = Mathf.CeilToInt(script.countDown);

        //時間を表示する
        announce.text = "残り" + _countValue.ToString() + "秒";

        pos = announce.rectTransform.position;

        //_timeAnnounceText = Instantiate(announce);
        //インスタンスを生成
        //_timeAnnounceText = Instantiate(announce,max,Quaternion.identity);
        //_timeAnnounceText = Instantiate(announce,canvasTransform);
    }

    void Start()
    {
        script = this.GetComponent<CountdownTimer>();
    }

    void Update()
    {
        //min = mainCamera.ViewportToWorldPoint(new Vector3(-0.5f, 0.5f,0));
        //max = mainCamera.ViewportToWorldPoint(new Vector3(1, 0.5f,0));

        //始点から終点までの距離
        //distance = Vector3.Distance(max, min);

        if (script.countDown == 90 || script.countDown == 60 || script.countDown == 30)
        {
            _announceMove();
            _thereText = 1;
        }

        if (_thereText == 1)
        {
            pos -= new Vector3(10, 0, 0);
            if(-1200 >= pos.x)
            {
                _thereText = 0;
                pos = new Vector3(1200, 0, 0);
            }
            /*
            //現在の位置
            float present_Location = (Time.time * speed) / distance;
            //オブジェクトの移動
            transform.position = Vector3.Lerp(max, min, present_Location);
            */
        }
    }
}