using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource sfxSource;
    public AudioSource musicSource;

    [Header("SFX Clips")]
    public AudioClip buttonClick;
    public AudioClip coinPickup;
    public AudioClip dragonFruitPickup;
    public AudioClip shurikenPickup;
    public AudioClip damageTaken;
    public AudioClip gameOver;
    public AudioClip gameWin;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persist through scene changes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }
}
