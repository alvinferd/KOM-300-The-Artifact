using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{

	public GameObject infobtn;
	public GameObject infos;
    // Start is called before the first frame update
   public void infoing(){
		if(infos.activeInHierarchy){
			infos.SetActive(false);
		} else infos.SetActive(true);
	}
}
