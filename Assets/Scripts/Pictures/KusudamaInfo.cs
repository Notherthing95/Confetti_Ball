// くす玉が割れるアニメーション

using UnityEngine;

public class KusudamaInfo : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] kusudamaSprite;
    [SerializeField] float durationTime = 2f;
    [SerializeField] float animationTime = 0.2f;
    private int _spriteNumber = 0;
    private float _timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer > animationTime && _spriteNumber != kusudamaSprite.Length)
        {
            spriteRenderer.sprite = kusudamaSprite[_spriteNumber];
            _spriteNumber++;
            _timer = 0;
        }

        if(_spriteNumber== kusudamaSprite.Length && _timer > durationTime)
        {
            gameObject.SetActive(false);
        }


    }
}
