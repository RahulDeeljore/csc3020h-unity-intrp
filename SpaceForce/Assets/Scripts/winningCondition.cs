using UnityEngine;
using UnityEngine.UI;

public class winningCondition : MonoBehaviour {
	public static Transform player1;
	public  static Transform player2;
	public GameObject border1;
	public GameObject border2;
	public GameObject border3;
	public GameObject border4;

	
	public Text scoreText;
	public static int army;

	// Use this for initialization
	void Awake () 
	{
       // GameOverPanel.SetActive(false);
        army = 5;
		updateScore ();
    
    }
	
	// Update is called once per frame
	void Update () 
	{

		if (player1 == null && player2 == null) 
		{
            GameOverScript.gameover.text = "LOSER";


        }
	}

	public void addScore()
	{
		army -= 1;
		updateScore ();
	}
	
	void updateScore()
	{
		scoreText.text = "Wave: " + army;
	}
}
