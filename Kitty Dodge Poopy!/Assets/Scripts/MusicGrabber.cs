using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicGrabber : MonoBehaviour
{
    [SerializeField]
    Toggle toggle;
    [SerializeField]
    BackgroundMusic music;
    GameObject musicMaster;
    // Start is called before the first frame update
    void Awake()
    {
        toggle = GetComponent<Toggle>();
        music = FindObjectOfType<BackgroundMusic>();
        musicMaster = GameObject.FindGameObjectWithTag("Music");
        if (music != null && music != null)
        {
            
            toggle.onValueChanged.AddListener(value => FindObjectOfType<BackgroundMusic>().AdjuctMute(toggle.enabled));
        }
        if (musicMaster.GetComponent<AudioSource>().mute)
        {
            toggle.SetIsOnWithoutNotify(true);
        }
    }
}
