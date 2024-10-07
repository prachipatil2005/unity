using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpcolor : MonoBehaviour
{
    MeshRenderer SphareMeshRenderer;
    [SerializeField][Range(0f, 1f)] float lerpTime;

    [SerializeField] Color[] myColor;
    int myColorIndex = 0;
    float t = 0f;
    int len;
    void Start()
    {

        SphareMeshRenderer = GetComponent<MeshRenderer>();
        len = myColor.Length;

    }

    // Update is called once per frame
    void Update()
    {
        SphareMeshRenderer.material.color = Color.Lerp(SphareMeshRenderer.material.color, myColor[myColorIndex], lerpTime * Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            myColorIndex++;
            myColorIndex = (myColorIndex >= len) ? 0 : myColorIndex;


        }
    }
}
    