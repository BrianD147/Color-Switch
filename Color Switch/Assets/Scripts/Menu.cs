using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Text highScoreText; // players highScore as presented on screen

	public GameObject areYouSureUI;
	public GameObject smallCircle1;
	public GameObject smallCircle2;


	void Start(){
		highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); // get the players highscore
	}
    
	public void StartGame () {
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void AreYouSure()
	{
		smallCircle1.SetActive(false);
		smallCircle2.SetActive(false);
		areYouSureUI.SetActive(true); // Set the areYouSureUI to active
	}

    	public void Cancel()
	{
		smallCircle1.SetActive(true);
		smallCircle2.SetActive(true);
		areYouSureUI.SetActive(false); // Set the areYouSureUI to inactive
	}

    	public void ResetHighscore()
	{
		smallCircle1.SetActive(true);
		smallCircle2.SetActive(true);
		areYouSureUI.SetActive(false); // Set the areYouSureUI to inactive
		PlayerPrefs.DeleteKey("HighScore");
		highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); // get the players highscore
	}
}
