using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UI : MonoBehaviour {
	public Image pauseBackground;
	public Game_Music music;
	// Use this for initialization
	public void Play(){
		music.musicplay.Stop ();
		Application.LoadLevel (1);
	}
	public void Option(){
		music.musicplay.Stop ();
		Application.LoadLevel (2);
	}
	public void Exit(){
		Application.Quit ();
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Pause(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
			pauseBackground.gameObject.SetActive (true);
		}

		else {
			Time.timeScale = 1;
			pauseBackground.gameObject.SetActive (false);
		}
	}
	public void Resume(){
		Time.timeScale = 1;
		pauseBackground.gameObject.SetActive (false);
	}
	public void MainMenu(){
		Application.LoadLevel (0);

		music.musicplay.Play ();
	}
}
