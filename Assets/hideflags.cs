using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideflags : MonoBehaviour
{
    void Start()
    {   
        gameObject.hideFlags = HideFlags.HideInInspector;
        //gameObject.hideFlags = HideFlags.HideInHierarchy;
        
    }



}
