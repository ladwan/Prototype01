using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {
    public GameObject CanvasText;
	// Use this for initialization
	void Start () {
        CanvasText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Dud")
        {
            CanvasText.SetActive(true);
        }
        else
        {
            Debug.Log("Tag has failed");
        }
    }
}
