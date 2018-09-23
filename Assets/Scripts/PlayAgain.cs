using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {

	// respond on collisions
	void OnCollisionEnter(Collision newCollision)
	{
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Bullet") {
			// call the RestartGame function in the game manager
			GameManager.gm.RestartGame();
		}
	}
}
