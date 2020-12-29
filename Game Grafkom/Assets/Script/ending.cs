using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
	public AudioSource ButtonSound;
	public Animator transition;
	public float transitiontime = 1f;
    // Start is called before the first frame update
    public void Playending(){
    	AudioSource buttonSound = ButtonSound.GetComponent<AudioSource>();
    	buttonSound.PlayOneShot(buttonSound.clip);
    	StartCoroutine(transisinya(SceneManager.GetActiveScene().buildIndex + 1)); 
    }

    IEnumerator transisinya(int index){
    	transition.SetTrigger("start");

    	yield return new WaitForSeconds(transitiontime);

    	SceneManager.LoadScene(index);
    }
}
