using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;
	public GameObject player;

	// UI Variables
	public Text lifeText;
	public Text scoreText;
	public Text gameOver;
	public Text finalScore;

	//private Instance variable
	private int lives;
	private int score;

	// Use this for initialization
	void Start () {

		this._GenerateTanks ();

		gameOver.enabled = false;
		finalScore.enabled = false;

		lives = 5;
		score = 0;

		lifeText.text = "Lives : " + lives;
		scoreText.text = "Score : " + score;
	}
	
	// Update is called once per frame
	void Update () {
		CheckGameOver ();
	}

	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}


	//public variables
	public void AddScore(){
		score += 10;
		PrintGUI ();
	}

	public void RemoveLife(){
		lives --;
		PrintGUI ();
	}
		
	public int GetLives(){
		return lives;
	}

	//private variables
	private int GetScore(){
		return score;
	}


	private void PrintGUI(){
		scoreText.text = "Score : " + GetScore();
		lifeText.text = "Lives : " + GetLives();
	}

	private void CheckGameOver(){
		if (GetLives () == 0) {
			scoreText.text = "";
			lifeText.text = "";
			gameOver.enabled = true;
			finalScore.enabled = true;
			finalScore.text = "Score : " + GetScore ();
			player.SetActive (false);

		}
	}


}
