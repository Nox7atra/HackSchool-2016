using UnityEngine;
using System.Collections;

public class Fan : MonoBehaviour {
	[SerializeField]
	private Rigidbody _Fanboy;

	private bool _isGrounded;

	public void Jump(float jumpF)
	{
		if (_isGrounded) {
			Debug.Log ("Jump");
			_Fanboy.AddForce (Vector3.up * jumpF, ForceMode.Impulse);
			_isGrounded = false;
		}
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


