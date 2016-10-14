using UnityEngine;
using System.Collections;

public class Fan : MonoBehaviour {
	[SerializeField]
	private Rigidbody _Fanboy;

	[SerializeField]
	private float _JumpForce;

	private bool _isGrounded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_isGrounded) 
		{
			Jump (_JumpForce, _Fanboy);
		}
	}


	public void Jump(float jumpF, Rigidbody body)
	{
		Debug.Log ("Jump");
		body.AddForce(Vector3.up * jumpF, ForceMode.Impulse);
		_isGrounded = false;
	}

	void OnCollisionEnter (Collision coll )
	{
		Debug.Log ("Collision");
		if (coll.gameObject.tag == "Ground") 
		{
			Debug.Log ("Grounded");
			_isGrounded = true;
		}
	}



}


