using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //public GameObject ball;
    //kasnije changed to
    //references the ball scirpt
    public Ball ball;//kad si napravio ball script
    public GameObject playerCamera;
    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;
    public bool holdingBall = true;
	//because of physics we first disable rigidbody look around and when we decide to shoot
    //we enable rigidbody
	void Start () {
        // GetComponent<Rigidbody>().useGravity = false; bi bilo od Player jer je na njega zakacena

        ball.GetComponent<Rigidbody>().useGravity = false; //ne podlijeze gravitaciji al se moze pomjeriti
    }
	
	// Update is called once per frame
	void Update () {
        //when player look around ball right in front of player
        //both of these are Vector 3 col of 3three elements hor,ver,depth pos
        //forward referencing direction ... ima i up,down,left,right
        //referencing point in the world

        if (holdingBall)
        {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                //graviti needs to be reaplied to ball
                //ovo se doda kad se napravi ball scirpt pa kad je bacis da prsti perje
                ball.ActiveTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward*ballThrowingForce);
            }
        }


// ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward* ballDistance;


    }
}
