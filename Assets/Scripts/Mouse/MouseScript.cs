// マウスの動き、クリック

using UnityEngine;

public class MouseScript : MonoBehaviour
{
    CircleInfo circleInfo;
    [SerializeField] GameObject mouseObject;
    [SerializeField] GameObject fingerPoint;
    [SerializeField] FingerScript fingerScript;
    [SerializeField] bool isClicking;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        mouseObject.transform.position = worldPos;

        Debug.Log("mousePos: " + mousePos);

        if (Input.GetMouseButtonDown(0))
        {
            isClicking = true;
            if (fingerScript.collisionObject.gameObject.CompareTag("Circle"))
            {
                circleInfo = fingerScript.collisionObject.GetComponent<CircleInfo>();
                fingerPoint.transform.position = circleInfo.kusudamaPoint.transform.position;
            }
            else
            {
                // 制限時間を減らす、その他
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            isClicking = false;
            Debug.Log("Upped");
        }
    }
}
