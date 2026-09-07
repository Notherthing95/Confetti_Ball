using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip openSE, correctSE, incorrectSE; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayOpenSE()
    {
        audioSource.PlayOneShot(openSE);
    }

    public void PlayCorrectSE()
    {
        audioSource.PlayOneShot(correctSE);
    }

    public void PlayIncorrectSE()
    {
        audioSource.PlayOneShot(incorrectSE);
    }
}
