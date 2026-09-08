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
    [SerializeField] SoundManager soundManager;
    [SerializeField] CountdownTimer countdownTimer;
    [SerializeField] GameObject UICanvas;
    [SerializeField] GameObject incorrectUI;

    [SerializeField] bool isStartScene;


    //[SerializeField] bool isClicking; // カーソルのアニメーションを変える

    [SerializeField] float breakKusudamaDistance = 0.5f;
    [SerializeField] float adjustIncorrectUIPointY = 100.0f;
    private bool _isCircleClicking;
    private GameObject _incorrectUIObject;
    

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
            else if(!isStartScene)
            { 
                soundManager.PlayIncorrectSE();
                countdownTimer.countDown -= 5.0f;
                _incorrectUIObject = Instantiate(incorrectUI,Input.mousePosition + new Vector3(0f,adjustIncorrectUIPointY,0f),Quaternion.identity);
                _incorrectUIObject.gameObject.transform.SetParent(UICanvas.gameObject.transform);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            _isCircleClicking = false;
            circleInfo = null;
        }

        //if (_isCircleClicking)
        //    Debug.Log("distance: " + (distanceY - mouseObject.transform.position.y));

        // くす玉を割る処理
        if(_isCircleClicking && distanceY - mouseObject.transform.position.y > breakKusudamaDistance)
        {
            circleInfo.isOpened = true;
            _isCircleClicking = false;
            if (!isStartScene)
                ScoreManager.Score++;
            
        }
    }


}
