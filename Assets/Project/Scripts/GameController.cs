using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to restart the scene
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    //we do this because we wanna know is player still holing a ball
    //if not holding ... restart the scene
    public Player player; //Player script
    public float resetTimer = 3f;//5 seconds
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        if (player.holdingBall == false)
        {
            //count down and restar the scene
            if (player.holdingBall == false)
            {
                resetTimer -= Time.deltaTime;
                if (resetTimer <= 0)
                {
                    SceneManager.LoadScene("SampleScene");
                }
            }
        }	
	}
}
