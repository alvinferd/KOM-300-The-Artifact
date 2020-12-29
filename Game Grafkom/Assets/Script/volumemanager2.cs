using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumemanager2 : MonoBehaviour
{	
	private int firstPlayInt;
	public Slider backgroundSlider;
	private float backgroundFloat;
	public AudioSource backgroundAudio;

	void Start(){
		
		backgroundFloat = PlayerPrefs.GetFloat("BackgroundPref");
		backgroundSlider.value =  backgroundFloat;
		backgroundAudio.volume = backgroundSlider.value;
	}

	public void SaveSoundSettings(){
		PlayerPrefs.SetFloat("BackgroundPref", backgroundSlider.value);
	}


	public void UpdateSound(){
		backgroundAudio.volume = backgroundSlider.value;
	}
}
