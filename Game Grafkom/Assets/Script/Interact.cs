using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour {

	public GameObject dialogBox;
	public GameObject hmm;
	public Text dialogText;
	public Text dialogTexttengah;
	public string dialog;
	public string dialogtengah;
	public bool dialogActive;
	public bool PlayerInRange;
	public PlayerMovement pindahnya;

	public GameObject pausebtn;
	public GameObject pausemenu;
	public GameObject resumebtn;
	public GameObject exitbtn;

	public void exited(){
		if(pausemenu.activeInHierarchy){
			pausemenu.SetActive(false);
			SceneManager.LoadScene(0);
			//pindahnya.pindah = true;
		}
	}
	public void resumed(){
		if(pausemenu.activeInHierarchy){
			pausebtn.SetActive(true);
			pausemenu.SetActive(false);
			pindahnya.pindah = true;
		}
	}
	public void paused(){
		if(pausebtn.activeInHierarchy){
			pausemenu.SetActive(true);
			pausebtn.SetActive(false);
			pindahnya.pindah = false;
		}
	}
	
    // Start is called before the first frame update
    void Start() {
       
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && PlayerInRange){
        	if(dialogBox.activeInHierarchy){
        		pindahnya.pindah = true;
        		dialogBox.SetActive(false);
        		hmm.SetActive(true);
        	} else{
        		pindahnya.pindah = false;
        		dialogBox.SetActive(true);
        		hmm.SetActive(false);
        		dialogText.text = dialog;
        		dialogTexttengah.text = dialogtengah;
        		Debug.Log(dialog);
        	}
        }
    }


    private void OnTriggerEnter2D(Collider2D other){
    	if(other.CompareTag("Player")){
    		//Debug.Log("Player in range");
    		PlayerInRange = true;
    		hmm.SetActive(true);
    	}
    }

    private void OnTriggerExit2D(Collider2D other){
    	if(other.CompareTag("Player")){
    		//Debug.Log("player out");
    		PlayerInRange = false;
    		dialogBox.SetActive(false);
    		hmm.SetActive(false);
    	}
    }

}
