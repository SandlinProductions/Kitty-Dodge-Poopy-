using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAnimation : MonoBehaviour {

    public Animator titleAnimation;
	// Use this for initialization
	void Start ()
    {
        titleAnimation.SetTrigger("Start");
		
	}
	
}
