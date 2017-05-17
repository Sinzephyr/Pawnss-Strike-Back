using UnityEngine;
using System.Collections;

public class PawnMovement : MonoBehaviour {

	//make new public bool and GameObjects
	//remember that public means they can be edited in the Unity editor and by other scripts
	public bool goToWork;
	public GameObject Pawn;
	public AudioSource keysound;
	public float thrust;
	public Rigidbody RB;
	Vector3 PawnOrigin;
	// Use this for initialization, similar to void setup() in Processing
	void Start () {
		RB = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame, similar to void draw() in Processing
	void Update () {
		Debug.Log("game object is at ... " + Pawn.transform.position);

		if (Input.GetKeyDown("left")){
			
			Pawn.transform.position += new Vector3(-1,0,0);
		}
		if (Input.GetKeyDown("right")){
			
			Pawn.transform.position += new Vector3(1,0,0);
		}
		if (Input.GetKeyDown("up")){

			Pawn.transform.position += new Vector3(0,0,1);
		}
		if (Input.GetKeyDown("down")){

			Pawn.transform.position += new Vector3(0,0,-1);
		}
		//check it the mover's position is equal to (0,5,0)
		if (Pawn.transform.position.z < -4){
			//if it is, add on this additional position (5,-5,0)
			Pawn.transform.position = PawnOrigin;
		}
		if ((Pawn.transform.position.x < -2)
			|| (Pawn.transform.position.x > 2)
			|| (Pawn.transform.position.z < 0)
			|| (Pawn.transform.position.z > 14))	{
			//if it is, reset to the original position (origin)
			Pawn.transform.position = PawnOrigin;
		}

	}
}