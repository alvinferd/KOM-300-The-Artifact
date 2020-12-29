using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show : MonoBehaviour
{
	void Start(){
		GameObject msc = GameObject.FindGameObjectWithTag("Musicending");
        if(msc) Destroy(msc);
	}
}