using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (PhotonView.isMine)
	    {
	        transform.position = ViveManager.Instance.head.transform.position;
            transform.rotation = ViveManager.Instance.head.transform.rotation;
        }
	}
}
