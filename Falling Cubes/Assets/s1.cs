using UnityEngine;
using System.Collections;

public class s1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start spinning!");
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (new Vector3 (0, 1, 0));
	}
}
