using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour 
{
	public void PlayPressed()
	{
		SceneManager.LoadScene("Game");
		// SceneManager.LoadScene(SceneManagement.GetActiveScene().buildIndex + 1);
	}

	public void ExitPressed()
	{
		Application.Quit();
	}
}