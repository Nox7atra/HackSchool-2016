using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
	 
	public string playGame;

	public void StartGame()
	{
		Application.LoadLevel(playGame);
	}
}