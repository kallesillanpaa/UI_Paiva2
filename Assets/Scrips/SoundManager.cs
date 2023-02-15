using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager sm;

    //public AudioClip GameMusic; //‰‰nitiedosto, jota soitetaan
    
    AudioSource audiosrc;

    public AudioMixer mixer;

    public Slider volumeSlider;


    public void Awake()
    {
        if (sm == null)
        {
            DontDestroyOnLoad(gameObject);
            sm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }


    public void SetVolume()
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(volumeSlider.value) * 20);
    }
}
