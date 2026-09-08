using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip openSE, correctSE, incorrectSE, endGameSE;


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

    public void PlayendGameSE()
    {
        audioSource.PlayOneShot(endGameSE);
    }

    // ã‹L‚Ì‘‚«•û‚ğQl‚É’Ç‰Á‚µ‚½‚¢‰¹‚ª‚ ‚ê‚Î’Ç‰Á
}
