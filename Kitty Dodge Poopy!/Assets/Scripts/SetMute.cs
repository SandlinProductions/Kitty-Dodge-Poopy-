using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMute : MonoBehaviour
{
    BackgroundMusic music;
    public GameObject musicMaster;
    // Start is called before the first frame update
    void Start()
    {
        music = FindObjectOfType<BackgroundMusic>();
        musicMaster = GameObject.FindGameObjectWithTag("Music");
    }

        public void SaveMute()
    {
        if (musicMaster.GetComponent<AudioSource>().mute == true)
        {
            PlayerPrefs.SetInt("isMuted", 0);
            PlayerPrefs.Save();
            Debug.Log("0 Muted");
        }
        else if (musicMaster.GetComponent<AudioSource>().mute == false)
        {
            PlayerPrefs.SetInt("isMuted", 1);
            PlayerPrefs.Save();
            Debug.Log("1 Not Muted");
        }

    }
}
