using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FanController : MonoBehaviour
{
	[SerializeField]
	private List<Fan> _Crowd;
	[SerializeField]
	private float _MinJumpForce;
	[SerializeField]
	private float _MaxJumpForce;

	public void RndJump()
	{
		for (int i = 0; i < _Crowd.Count; i++)
		{
			_Crowd[i].Jump(Random.Range(_MinJumpForce, _MaxJumpForce));
		}
	}
	void Update(){
		RndJump ();
	}

}
