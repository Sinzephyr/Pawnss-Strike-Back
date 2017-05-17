using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	public GameObject Pawn;
	public GameObject [] Enemies;
	public static int movespeed = 1;
	public Vector3 userDirection = Vector3.right;
	Vector3 EnemiesOrigin;
	public

	void Start(){
	}
	public void Update ()
	{
		
		transform.Translate (userDirection * movespeed * Time.deltaTime);

			
	}
}
