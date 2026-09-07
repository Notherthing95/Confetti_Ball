using TMPro;
using UnityEngine;

public class TimeAnnounce : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI count;

    //フラグ取得用
    CountdownTimer script;

    //表示用
    private int _countValue;

    void Start()
    {
        script = this.GetComponent<CountdownTimer>();
    }

    void Update()
    {
        if (script.countDown == 60)
        {
            //表示用に数値をint変換(切り上げ)
            _countValue = Mathf.CeilToInt(script.countDown);

            //時間を表示する
            count.text = "残り" + _countValue.ToString() + "秒";
        }
    }
}