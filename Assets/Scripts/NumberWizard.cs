using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	public int min;
	public int max;
	public int guessesAllowed = 10;
	public Text guessText;

	int guess;
	int remainingGuesses;

	public void GuessHigher ()
	{
		min = guess;
		GuessAgain();
	}

	public void GuessLower ()
	{
		max = guess;
		GuessAgain();
	}
	
	void Start ()
	{
		StartGame();
	}

	void StartGame ()
	{
		min = 1;
		max = 1000;
		remainingGuesses = guessesAllowed;

		GuessAgain();
	}

	void GuessAgain ()
	{
		guess = Random.Range(min, max + 1);
		remainingGuesses = remainingGuesses - 1;
		guessText.text = "Is " + guess.ToString() + " your number?";

		if(remainingGuesses <= 0) {
			SceneManager.LoadScene("Win");
		}
	}

}
