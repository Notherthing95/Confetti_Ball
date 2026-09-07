// マウスの動き、クリック

using UnityEngine;

public class MouseScript : MonoBehaviour
{
    CircleInfo circleInfo;
    [SerializeField] GameObject mouseObject;
    [SerializeField] GameObject fingerPoint;
    [SerializeField] FingerScript fingerScript;

    //[SerializeField] bool isClicking; // カーソルのアニメーションを変える

    [SerializeField] float breakKusudamaDistance = 5f;
    private bool _isCircleClicking;
    

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

        if (Input.GetMouseButtonDown(0))
        {
            //isClicking = true;

            if (fingerScript.collisionObject != null && fingerScript.collisionObject.gameObject.CompareTag("Circle"))
            {
                circleInfo = fingerScript.collisionObject.GetComponent<CircleInfo>();
                mouseObject.transform.position = circleInfo.kusudamaPoint.transform.position;
                _isCircleClicking = true;
            }
            else
            {
                // 制限時間を減らす、その他
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            //isClicking = false;
            _isCircleClicking = false;
        }
    }


}
