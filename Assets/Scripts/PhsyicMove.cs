using UnityEngine;
using System.Collections;

public class PhsyicMove : MonoBehaviour {
	public Rigidbody myRB;
	public GameObject target;
	Vector3 targetPos;
	public float thrust;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody>();
	}
	

	void FixedUpdate () {
		
		targetPos = target.transform.position;
		Vector3 direction = Vector3.Normalize (targetPos - transform.position);
		myRB.AddForce (direction * thrust);
	}
}
