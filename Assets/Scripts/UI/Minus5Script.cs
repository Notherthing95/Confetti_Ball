// -5‚Ì“®‚«
using UnityEngine;

public class Minus5Script : MonoBehaviour
{
    
    [SerializeField] float speed = 100f;
    [SerializeField]float downSpeed = 50f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
        speed -= downSpeed * Time.deltaTime;
        if (speed <= 0f)
            Destroy(gameObject);
    }
}
