using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start() {
		if (autoLoadNextLevelAfter > 0) {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
		
	public void LoadPreviousLevel() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}


	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}
