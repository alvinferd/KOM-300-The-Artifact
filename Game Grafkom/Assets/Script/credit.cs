using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credit : MonoBehaviour
{
	public float animatetime = 600f;
	public Animator creditanimate;

     void Start()
     {
         StartCoroutine(LoadAfterAnim());
     }

     public IEnumerator LoadAfterAnim(){
     	creditanimate.SetTrigger("mulai");
     	yield return new WaitForSeconds(animatetime);
     	SceneManager.LoadScene(0);
     }
}
