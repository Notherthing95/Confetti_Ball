// ƒT[ƒNƒ‹‚ª‹ó‚¢‚Ä‚é‚©‚Ç‚¤‚©‚Ìî•ñ

using UnityEngine;
using UnityEngine.UI;
public class CircleInfo : MonoBehaviour
{
    public bool isOpened;
    public GameObject kusudamaPoint;
    [SerializeField] GameObject kusudama;
    Image circleImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpened)
        {
            kusudama.SetActive(true);
            circleImage.sprite = null;
        }
    }
}
