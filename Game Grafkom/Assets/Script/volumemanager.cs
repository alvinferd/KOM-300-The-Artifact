using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumemanager : MonoBehaviour
{	
	public GameObject volumeoption;
	public AudioSource ButtonSound;

	private int firstPlayInt;
	public Slider backgroundSlider;
	private float backgroundFloat;
	public AudioSource backgroundAudio;

	void Start(){

		firstPlayInt = PlayerPrefs.GetInt("FirstPlay");

		if(firstPlayInt == 0){
			backgroundFloat = .125f;
			backgroundSlider.value =  backgroundFloat;
			PlayerPrefs.SetFloat("BackgroundPref", backgroundFloat);
			PlayerPrefs.SetInt("FirstPlay", 1);
		} else{
			backgroundFloat = PlayerPrefs.GetFloat("BackgroundPref");
			backgroundSlider.value =  backgroundFloat;
			backgroundAudio.volume = backgroundSlider.value;
		}
	}

	public void SaveSoundSettings(){
		PlayerPrefs.SetFloat("BackgroundPref", backgroundSlider.value);
	}


	public void UpdateSound(){
		backgroundAudio.volume = backgroundSlider.value;
	}

    public void open(){
    	AudioSource buttonSound = ButtonSound.GetComponent<AudioSource>();
    	buttonSound.PlayOneShot(buttonSound.clip);
    	if(volumeoption.activeInHierarchy){
    		volumeoption.SetActive(false);	
    	} else volumeoption.SetActive(true);
    }
}
