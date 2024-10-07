using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LerpColor : MonoBehaviour
{
    MeshRenderer cmr;
    [SerializeField] [Range(0f, 1f)] float lerptime;
    [SerializeField] Color[] mColor;

    int colorindex = 0;
    float t = 0f;
    void Start()
    {
        cmr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        cmr.material.color= Color.Lerp(cmr.material.color, mColor[colorindex], lerptime*Time.deltaTime);
        t= Mathf.Lerp(t,1f,lerptime*Time.deltaTime);
        if(t>0.9f)
        {
            t=0f;
            colorindex++;
            colorindex=(colorindex >=mColor.Length)?0:colorindex;
        }
    }
}
