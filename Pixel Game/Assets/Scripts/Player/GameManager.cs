using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
	public GameObject gameOverPanel;
	public GameObject LevelCompletePanel;
	private int nextScene;

    public void Start()
    {
		nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }
    public void GameOver()
	{

		if (gameEnded == false)
		{
			gameEnded = true;

			gameOverPanel.SetActive(true);
		}

	}

	public void MainMenu()
	{

		SceneManager.LoadScene("Menu");

	}
	public void Restart()
	{

		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


	
	public void quit()
	{

		Application.Quit(); //call quit function
	}

	public void next()
    {
		SceneManager.LoadScene(nextScene);
    }



	public void LevelComplete() {
		
		LevelCompletePanel.SetActive(true);
	}


}
