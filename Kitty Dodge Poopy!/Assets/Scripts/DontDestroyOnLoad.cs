using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

    //Keeps gameObject alive
    public static DontDestroyOnLoad instance = null;
    private void Awake()
    {
        //CHeck if there is already an Instance of this
        if (instance == null)
            //if not, set it to this
            instance = this;
        //if instance already exists
        else if (instance != this)
            //Destroy this, this enforces our singleton pattern so there can only be one instance of this
            Destroy(gameObject);

    //Set this to DontDestroyOnLoad so that it won't be destroyed when reloading our scene
        DontDestroyOnLoad(transform.gameObject);
    }
}
