using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform mTarget;
    public float traveltime;
    Vector3 startpos;
    Vector3 endpos;
    float etimer;
    void Start()
    {
        startpos=transform.position;
        endpos=mTarget.position;
        etimer=0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        etimer +=Time.deltaTime;
        transform.position=Vector3.Lerp(startpos,endpos,etimer/traveltime );
    }
}
