using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderGrabber : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    [SerializeField]
    BackgroundMusic music;
    [SerializeField]
    GameObject musicMaster;
    public float volume;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
        music = FindObjectOfType<BackgroundMusic>();
        musicMaster = GameObject.FindGameObjectWithTag("Music");
        volume = musicMaster.GetComponent<AudioSource>().volume;
        if (music != null && music != null)
        {
            slider.onValueChanged.AddListener(value => FindObjectOfType<BackgroundMusic>().AdjustVolume(slider.value));
            SetVolume(volume);
        }
        if (music.GetComponent<AudioSource>().mute)
        {
            slider.SetValueWithoutNotify(0);
            
        }
       
    }

    public void SetVolume(float sliderValue)
    {
        slider.value = volume;
    }
}
