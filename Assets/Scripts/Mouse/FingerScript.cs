// ŠÛ‚É“–‚½‚Á‚Ä‚é‚©‚Ç‚¤‚©‚Ì”»’è
using UnityEngine;

public class FingerScript : MonoBehaviour
{
    public bool isTriggering;
    public GameObject collisionObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTriggering = true;
        collisionObject = collision.gameObject;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTriggering = false;
        collisionObject = null;
    }
}
