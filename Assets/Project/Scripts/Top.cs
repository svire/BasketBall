using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour {

    public GameObject djule;
    public GameObject topCamera;
    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;
    public bool holdingBall = true;
    // Use this for initialization
    void Start () {
        djule.GetComponent<Rigidbody>().useGravity = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (holdingBall)
        {
            djule.transform.position = topCamera.transform.position + topCamera.transform.forward * ballDistance;
            if (Input.GetMouseButtonDown(0))
            {
                
              //  Vector3 poz = new Vector3(0.126f, 0.858f, 1.632f);
               // Quaternion rotationn = new Quaternion(0, 0, 0,0);
// Instantiate(djule, poz,rotationn);
//var myNew=Instantiate(djule, Vector3(0.126f, 0.858f, 1.632f),)

                holdingBall = false;
                //graviti needs to be reaplied to ball
                djule.GetComponent<Rigidbody>().useGravity = true;
                djule.GetComponent<Rigidbody>().AddForce(topCamera.transform.forward * ballThrowingForce);
            }
        }

    }
}
