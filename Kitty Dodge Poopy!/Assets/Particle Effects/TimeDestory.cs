using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestory : MonoBehaviour
{
    [SerializeField]
    private float coundDownTime = 1f;

    void Awake()
    {
        Destroy(gameObject, coundDownTime);
    }

    
}
