using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    public GameObject[] dropper;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dropper = GameObject.FindGameObjectsWithTag("Drop");
            foreach (GameObject dropperObject in dropper)
                dropperObject.GetComponent<Rigidbody>().useGravity = true;
            foreach (GameObject dropperObject in dropper)
                dropperObject.GetComponent<Renderer>().enabled = true;


        }



    }
}

