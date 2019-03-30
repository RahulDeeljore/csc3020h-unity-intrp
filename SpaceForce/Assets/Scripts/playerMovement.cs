using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float speed;


	void Start () 
	{

	}

	// Update is called once per frame
	void FixedUpdate () {


		if (Input.GetKey ("up")) //up key moves player in the y direction
		{
			GetComponent<Rigidbody2D>().AddForce (gameObject.transform.up * speed); 
		}

		if(Input.GetKey("left"))//Press left arrow key to rotate anticlockwise on the Z AXIS
		{
			transform.Rotate(0,0,4); //rotate anticlockwise
			GetComponent<Rigidbody2D>().angularVelocity = 0; //prevents player rotating without any keys being pressed after collision
		}
		if(Input.GetKey("right"))//Press right arrow key to rotate clockwise on the Z AXIS
		{
			transform.Rotate(0,0,-4); //rotate clockwise
			GetComponent<Rigidbody2D>().angularVelocity = 0; //prevents player rotating without any keys being pressed after collision
		}



	}
}
