using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;

    static float x =1;
    void Start()
    {
        volumeSlider.value = x;
        volumeSlider.value = PlayerPrefs.GetFloat("GameVolume", 1f);
        AudioListener.volume = volumeSlider.value;

       
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float volume)
    {
        AudioListener.volume = volume; 
        PlayerPrefs.SetFloat("GameVolume", volume); 
        PlayerPrefs.Save();

        x = volumeSlider.value;


    }
}
