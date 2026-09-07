// くす玉が割れるアニメーション

using UnityEngine;
using UnityEngine.UI;

public class KusudamaInfo : MonoBehaviour
{
    // ここにスイカに状態を送る処理を入れる
    Image kusudamaImage;
    [SerializeField] GameObject parentObject;
    [SerializeField] Sprite[] kusudamaSprites;
    [SerializeField] float durationTime = 1f;
    [SerializeField] float animationTime = 0.1f;
    private int _spriteNumber = 0;
    private float _timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        kusudamaImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer > animationTime && _spriteNumber != kusudamaSprites.Length)
        {
            Debug.Log("Sprite: " + _spriteNumber);
            kusudamaImage.sprite = kusudamaSprites[_spriteNumber];
            _spriteNumber++;
            _timer = 0;
        }

        if(_spriteNumber== kusudamaSprites.Length && _timer > durationTime)
        {
            parentObject.SetActive(false);
        }


    }
}
