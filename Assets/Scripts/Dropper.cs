using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rbody;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rbody = GetComponent<Rigidbody>();
        rbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        float timer = Time.time;
              

        if(timer > timeToWait)
        {            
            renderer.enabled = true;
            
            rbody.useGravity = true;
        }
    }
}
