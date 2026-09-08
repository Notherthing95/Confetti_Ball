using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip openSE, correctSE, incorrectSE, endGameSE, startSE, countSE, intervalSE;


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

    public void PlayStartSE()
    {
        audioSource.PlayOneShot(startSE);
    }

    public void PlayCountSE()
    {
        audioSource.PlayOneShot(countSE);
    }

    public void PlayIntervalSE()
    {
        audioSource.PlayOneShot(intervalSE);
    }

    

    // è„ãLÇÃèëÇ´ï˚ÇéQçlÇ…í«â¡ÇµÇΩÇ¢âπÇ™Ç†ÇÍÇŒí«â¡
}
