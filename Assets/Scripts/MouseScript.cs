using UnityEngine;

public class MouseScript : MonoBehaviour
{
    [SerializeField] GameObject mouseObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Vector2 mousePos = Input.mousePosition;
            mouseObject.transform.position = mousePos;
        }
    }
}
