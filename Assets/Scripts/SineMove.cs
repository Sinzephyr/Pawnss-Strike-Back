using UnityEngine;
using System.Collections;

public class SineMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Mathf.Sin (Time.time)/50f, Mathf.Sin (Time.time)/50f, Mathf.Sin (Time.time)/50f);	}
}
