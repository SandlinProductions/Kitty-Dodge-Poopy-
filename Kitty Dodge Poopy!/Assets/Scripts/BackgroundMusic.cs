using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField]
    AudioSource musicMaster;
    // Start is called before the first frame update
    void Start()
    {
        musicMaster = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("isMuted") == 1)
        {
            musicMaster.GetComponent<AudioSource>().mute = false;
            Debug.Log("Saved as 1 Not Muted");
        }
        if (PlayerPrefs.GetInt("isMuted") == 0)
        {
            musicMaster.GetComponent<AudioSource>().mute = true;
            Debug.Log("Saved as 0 Muted");
        }
    }
    public void AdjuctMute(bool mute)
    {
        musicMaster.mute = !musicMaster.mute;
    }
    public void AdjustVolume(float vol)
    {
        musicMaster.volume = vol;
    }
    private void Update()
    {
        //if (musicMaster.GetComponent<AudioSource>().mute == true)
        //{
        //    PlayerPrefs.SetInt("isMuted", 0);
        //    PlayerPrefs.Save();
        //    Debug.Log("0 Muted");
        //}
        //else if (musicMaster.GetComponent<AudioSource>().mute == false)
        //{
        //    PlayerPrefs.SetInt("isMuted", 1);
        //    PlayerPrefs.Save();
        //    Debug.Log("1 Not Muted");
        //}
    }
    public void SetMute()
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
