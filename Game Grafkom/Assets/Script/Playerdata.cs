using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Playerdata {

	public float[] position;
	public float maxx;
	public float maxy;
	public float minx;
	public float miny;
	public bool satu;
	public bool dua;
	public bool tiga;

	public Playerdata (flag flags,PlayerMovement player, CameraMovement camove){
		satu = flags.satu;
		dua = flags.dua;
		tiga = flags.tiga;

		position = new float[3];
		position[0] = player.transform.position.x;
		position[1] = player.transform.position.y;
		position[2] = player.transform.position.z;

		maxx = camove.maxPosition.x;
		minx = camove.minPosition.x;
		maxy = camove.maxPosition.y;
		miny = camove.minPosition.y;
		//position = new float[3];
		//camera[0] = camove.targetPosition.x;
		//camera[1] = camove.targetPosition.y;
		//camera[2] = camove.targetPosition.z;
			
	}
}
