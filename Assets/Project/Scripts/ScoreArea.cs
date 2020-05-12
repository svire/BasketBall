using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreArea : MonoBehaviour {
    public GameObject effectObject;
    public Text text;
    private int rezultat = 0;
    void Start()
    {
        effectObject.SetActive(false);
        text.text = rezultat.ToString();
    }
    void Update()
    {
        text.text = rezultat.ToString();
    }
    void OnTriggerExit(Collider otherCollider)
    {
        //collided with a ball a not anything else
        if (otherCollider.GetComponent<Ball>() != null)
        {
            Debug.Log("SCORE!");
            rezultat++;
            effectObject.SetActive(true);
        }
        else if(otherCollider.GetComponent<Ball>() == null)
        {
            Debug.Log("Miss");
        }
    }
}
