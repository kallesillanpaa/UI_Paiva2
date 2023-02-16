using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager sm; // luodaan luokasta staattinen instanssi
    
    AudioSource audiosrc;

    public AudioMixer mixer; //referenssi mikseriin. Muista paljastaa (expose) mikseristä volumen parametri,
                             //nimeksi MusicVolume, jotta skriptin SetVolume toimii (hakee sen nimistä parametria)

    public Slider volumeSlider; //slider, jonka arvoa muutetaan


    public void Awake() //pidetään huoli, että käsitellään aina samaa instanssia
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
        audiosrc = GetComponent<AudioSource>(); //audiosource tulee löytyä gameobjektilta, jossa skripti on
    }


    public void SetVolume()
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(volumeSlider.value) * 20); //äänen säätö matemaattisesti
    }
}
