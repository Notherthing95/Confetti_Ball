// マウスの動き、クリック

using Unity.VisualScripting;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    float distanceY;  // 丸とマウスのYの距離
    Vector2 circlePointdistance;
    CircleInfo circleInfo;
    [SerializeField] GameObject mouseObject;
    [SerializeField] GameObject fingerPoint;
    [SerializeField] FingerScript fingerScript;

    //[SerializeField] bool isClicking; // カーソルのアニメーションを変える

    [SerializeField] float breakKusudamaDistance = 0.5f;
    private bool _isCircleClicking;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        mouseObject.transform.position = worldPos;

        // 丸を選択した時の処理
        if (Input.GetMouseButtonDown(0))
        {

            if (fingerScript.collisionObject != null && fingerScript.collisionObject.gameObject.CompareTag("Circle"))
            {
                circleInfo = fingerScript.collisionObject.GetComponent<CircleInfo>();
                // mouseObject.transform.position = circleInfo.kusudamaPoint.transform.position;
                distanceY = circleInfo.kusudamaPoint.transform.position.y;
                

                _isCircleClicking = true;
            }
            else
            {
                // 制限時間を減らす、その他
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            _isCircleClicking = false;
            circleInfo = null;
        }

        if (_isCircleClicking)
            Debug.Log("distance: " + (distanceY - mouseObject.transform.position.y));

        // くす玉を割る処理
        if(_isCircleClicking && distanceY - mouseObject.transform.position.y > breakKusudamaDistance)
        {
            circleInfo.isOpened = true;
            _isCircleClicking = false;
            // 加算処理
        }
    }


}
