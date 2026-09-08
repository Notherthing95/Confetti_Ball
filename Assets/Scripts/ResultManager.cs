using UnityEngine;

public class ResultManager : MonoBehaviour
{
    [SerializeField] GameObject FadeObject;
    [SerializeField] GameObject PerfectObject;

    public bool isAllCorrect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAllCorrect)
        {
            FadeObject.SetActive(false);
            PerfectObject.SetActive(true);
        }
    }
}
