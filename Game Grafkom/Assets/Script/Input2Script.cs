using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input2Script : MonoBehaviour
{
	public string input;
	public GameObject inputField;
	public GameObject textDisplay;
	public GameObject inputan;
	public GameObject button;
	public GameObject hmm;
	public GameObject boxnya;
	public Text hintnya;
	public string hint;
	public bool PlayerInRange;
	public flag flagnya;
	public PlayerMovement pindahnya;

	public AudioSource CorrectSound;
    // Start is called before the first frame update

    void Start() {
       
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && PlayerInRange){
        	if(boxnya.activeInHierarchy){
        		pindahnya.pindah = true;
        		inputField.SetActive(false);
        		textDisplay.SetActive(false);
        		button.SetActive(false);
        		boxnya.SetActive(false);
        		hmm.SetActive(true);
        	} else{
        		if(flagnya.dua){
        		} else{
        			inputField.SetActive(true);
        		}
        		pindahnya.pindah = false;
        		button.SetActive(true);
        		textDisplay.SetActive(true);
        		boxnya.SetActive(true);
        		hmm.SetActive(false);
        		hintnya.text = hint;
        		Debug.Log(input);
        	}
        }
    }



    public void StorName(){
    	input = inputan.GetComponent<Text>().text;
        if(input == "Perjuangan"){
        	AudioSource correctSound = CorrectSound.GetComponent<AudioSource>();
    		correctSound.PlayOneShot(correctSound.clip);
        	textDisplay.GetComponent<Text>().text = "You Get It";
        	inputField.SetActive(false);
        	//button.SetActive(false);
        	//boxnya.SetActive(false);
        	//hmm.SetActive(true);
        	flagnya.dua = true;
        	pindahnya.pindah = true;    
        } else {
        	textDisplay.GetComponent<Text>().text = "No reaction";
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
    		inputField.SetActive(false);
    		textDisplay.SetActive(false);
    		button.SetActive(false);
    		boxnya.SetActive(false);
    		hmm.SetActive(false);
    	}
    }

}


