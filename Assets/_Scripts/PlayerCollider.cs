using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	public GameController gameController;
	public GameObject tank;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other){
		if(gameController.GetLives() > 0){
//			if (other.gameObject.tag == "Boundary") {
//				// add score
//				gameController.AddScore();
//			}	
		
			if (other.gameObject.CompareTag ("Enemy")) {
				gameController.RemoveLife();
				other.transform.position = new Vector2 (Random.Range(-287F, 287F), 290F);
			}
		}
	}


}
