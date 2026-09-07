// test

using UnityEngine;

public class CameraScript: MonoBehaviour
{
    // ズーム速度
    [SerializeField] float zoomSpeed = 2.0f;

    // ズーム可能範囲
    [SerializeField] float minZoom = 2.0f;
    [SerializeField] float maxZoom = 10.0f;

    // ドラッグ速度
    [SerializeField] float dragSpeed = 1.0f;

    private Vector3 lastMousePosition;

    void Update()
    {
        Zoom();
        Drag();
    }

    void Zoom()
    {
        float scroll = Input.mouseScrollDelta.y;

        if (scroll == 0)
            return;

        // ズーム前のマウス位置をワールド座標で取得
        Vector3 mouseWorldBefore = Camera.main.ScreenToWorldPoint(
            Input.mousePosition
        );

        // ズーム
        Camera.main.orthographicSize -= scroll * zoomSpeed;

        // 範囲制限
        Camera.main.orthographicSize = Mathf.Clamp(
            Camera.main.orthographicSize,
            minZoom,
            maxZoom
        );

        // ズーム後のマウス位置
        Vector3 mouseWorldAfter = Camera.main.ScreenToWorldPoint(
            Input.mousePosition
        );

        // マウス位置が動かないようにCameraを移動
        Vector3 difference = mouseWorldBefore - mouseWorldAfter;
        transform.position += difference;
    }

    void Drag()
    {
        if (Input.GetMouseButtonDown(1))
        {
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 currentMousePosition = Input.mousePosition;

            Vector3 difference = Camera.main.ScreenToWorldPoint(lastMousePosition)
                               - Camera.main.ScreenToWorldPoint(currentMousePosition);

            transform.position += difference * dragSpeed;

            lastMousePosition = currentMousePosition;
        }
    }
}