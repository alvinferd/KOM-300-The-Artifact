using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
	public AudioSource ButtonSound;
	public int load;
	public Animator transition;
	public float transitiontime = 1f;
    // Start is called before the first frame update


    public void PlayGame(){
    	load = 0;
    	PlayerPrefs.SetInt("load", load);
    	AudioSource buttonSound = ButtonSound.GetComponent<AudioSource>();
    	buttonSound.PlayOneShot(buttonSound.clip);
    	StartCoroutine(transisi(SceneManager.GetActiveScene().buildIndex + 1)); 
    }

    public void LoadGame(){
    	load = 1;
    	AudioSource buttonSound = ButtonSound.GetComponent<AudioSource>();
    	buttonSound.PlayOneShot(buttonSound.clip);
    	PlayerPrefs.SetInt("load", load);
    	StartCoroutine(transisi(3));
    	
    }

    public void keluargame(){
    	AudioSource buttonSound = ButtonSound.GetComponent<AudioSource>();
    	buttonSound.PlayOneShot(buttonSound.clip);
    	Application.Quit();
    }

    IEnumerator transisi(int index){
    	transition.SetTrigger("start");

    	yield return new WaitForSeconds(transitiontime);

    	SceneManager.LoadScene(index);
    }

}
