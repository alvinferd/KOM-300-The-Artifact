using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class flag : MonoBehaviour {

	public GameObject dialogBox;
	public GameObject hmm;
	public Text dialogText;
	public Text dialogtengah;
	public string dialog;
	public string dialogtngh;
	public bool dialogActive;
	public bool PlayerInRange;
	public bool satu;
	public bool dua;
	public bool tiga;
	public PlayerMovement pindahnya;
	public volumemanager2 vlm;
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
        		if(satu && dua && tiga){
        			vlm.SaveSoundSettings();
        			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        		} else{
        			dialogBox.SetActive(true);
        			hmm.SetActive(false);
        			dialog = "You cant Enter this room";
        			dialogText.text = dialog;
        			dialogtengah.text = dialogtngh;        			
        			Debug.Log(dialog);
        		}
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
