using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody _ourRigidbody;
    public float speed;
    private int count;
    public Text countText;
    void Start()
    {
        _ourRigidbody = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        this.enabled = true;
    }

        // Update is called once per frame
    void Update()
    {
        //record input from our player
        float moveHorizontal=Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical");

        Vector3 movement= new (moveHorizontal,0.0f,moveVertical);

        _ourRigidbody.AddForce(speed * Time.deltaTime * movement);

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "pickup")
        {
            other.gameObject.SetActive(false);
            count += 1;
            
            SetCountText();
        }

    }
    private void SetCountText()
    {
        if (countText == null)
        {
            Debug.LogError("countText is not assigned!");
            return;
        }
        countText.text = "Count: " + count.ToString();
        //Debug.Log("Count: " + count);
    }
    /*void OnGUI()
    {
        
        if(count!=8)
        {
            GUI.Label(new Rect (10,10,100,20),countText.text);
            
        } else
        {
            GUI.Label(new Rect (10,10,100,20),"To The Way To Win!!");
        } 

    }*/
}
