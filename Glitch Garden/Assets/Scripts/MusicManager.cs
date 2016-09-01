using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	private static MusicManager instance;

	public void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			GameObject.Destroy (this);
		}
	}

	public void Start() {
		audioSource = GetComponent<AudioSource> ();
	}

	public void OnLevelWasLoaded(int level) {
		// - Avoif accessing an out of bounds position
		if (level >= levelMusicChangeArray.Length) {
			return;
		}

		AudioClip thisLevelAudioClip = levelMusicChangeArray [level];

		if (thisLevelAudioClip) {
			audioSource.clip = thisLevelAudioClip;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
}
