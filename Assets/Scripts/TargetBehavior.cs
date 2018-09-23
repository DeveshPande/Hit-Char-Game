using UnityEngine;
using System.Collections;

public class TargetBehavior : MonoBehaviour
{
	//public int scoreAmount = 0;
	//public float timeAmount = 0.0f;
	int k=0;
	int p=10;
	int n = -5;

	// explosion when hit?
	public GameObject explosionPrefab;

	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{
		PlayerPrefManager.getstring ();
		int mainstringindex = PlayerPrefManager.getind ();
		int stilenght = PlayerPrefManager.getlength ();
		int  l= PlayerPrefManager.getstringindex ();
		string[] st2 = PlayerPrefManager.st;
		string st1 = st2 [mainstringindex];
		stilenght = st1.Length;
		//int index = st1.Length;
		//int s = st1.Length - index;
		Debug.Log ("Stringlenght;"+l);
		Debug.Log ("mainstringindex"+mainstringindex);
		Debug.Log ("stilenght"+stilenght);
		string ch=st1.Substring(l,1);
		//index--;
		// exit if there is a game manager and the game is over
		if (GameManager.gm) {
			if (GameManager.gm.gameIsOver)
				return;
		}

		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Bullet") {
			
			if (this.gameObject.tag == ch) {
				l++;
				if(GameManager.gm)
					GameManager.gm.targetHit (10, 2.0f,st1);
				PlayerPrefManager.SetScore (p);
				if (l == stilenght) {
					k = l;
					l = 0;
					mainstringindex++;
					st1 = st2 [mainstringindex];
					PlayerPrefManager.setvalue (mainstringindex, stilenght, l);
					if(GameManager.gm)
						GameManager.gm.targetHit (10,2.0f,st1);
					PlayerPrefManager.SetScore (p);
				} else {
					PlayerPrefManager.setvalue (mainstringindex, stilenght, l);
				}
				Debug.Log (ch);
			} else {
				if(GameManager.gm)
					GameManager.gm.targetHit (-5, (5.0f)*-1,st1);
				PlayerPrefManager.SetScore (n);
			}
			if (explosionPrefab) {
				// Instantiate an explosion effect at the gameObjects position and rotation
				Instantiate (explosionPrefab, transform.position, transform.rotation);
			}

			// if game manager exists, make adjustments based on target properties
			if (GameManager.gm) {
				if (k == st1.Length) {
					GameManager.gm.targetHit (k*10, 10.0f,st1);
				}
				//GameManager.gm.targetHit (scoreAmount, timeAmount);
			}
				
			// destroy the projectile
			Destroy (newCollision.gameObject);
				
			// destroy self
			Destroy (gameObject);
		}
	}
}
