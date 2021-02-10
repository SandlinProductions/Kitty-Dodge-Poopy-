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
    }
    public void AdjuctMute(bool mute)
    {
        musicMaster.mute = !musicMaster.mute;
    }
    public void AdjustVolume(float vol)
    {
        musicMaster.volume = vol;
    }

}
