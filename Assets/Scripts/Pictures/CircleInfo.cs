// ƒT[ƒNƒ‹‚ª‹ó‚¢‚Ä‚é‚©‚Ç‚¤‚©‚Ìî•ñ

using UnityEngine;
using UnityEngine.UI;
public class CircleInfo : MonoBehaviour
{
    public bool isOpened;
    private bool _checkFlag;
    public GameObject kusudamaPoint;
    [SerializeField] GameObject kusudama;
    [SerializeField] Image circleImage;
    [SerializeField] SoundManager sound;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isOpened && !_checkFlag)
        {
            kusudama.SetActive(true);
            circleImage.sprite = null;
            circleImage.color = new Color(1f, 1f, 1f, 0f);
            sound.PlayOpenSE();
            sound.PlayCorrectSE();
            _checkFlag = true;
        }
    }
}
