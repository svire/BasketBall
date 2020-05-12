using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public GameObject trailObject;
	// Use this for initialization
	void Start () {
        //object at first deactivated
        trailObject.SetActive(false);		
	}
    //kad stojis nece da svjettli	
	// Update is called once per frame
	public void ActiveTrail()
    {
      
        trailObject.SetActive(true);
    }

	
	
}
