using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drops : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    MeshRenderer renderer;
    Rigidbody rigidbody;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    
    void Update()
    {
        if(Time.time > timeToWait)
        {
            Debug.Log("3 saniyeniz doldu");
            renderer.enabled = true;
            rigidbody.useGravity = true;
            
        }
    }
}
