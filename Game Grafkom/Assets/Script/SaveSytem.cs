using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSytem {

	public static void SavePlayer (flag flags, PlayerMovement player, CameraMovement camove){

		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.dat";
		FileStream stream = new FileStream(path, FileMode.Create);

		Playerdata data = new Playerdata(flags,player,camove);

		formatter.Serialize(stream,data);
		stream.Close();
		Debug.Log(data);
	}

	public static Playerdata LoadPlayer(){

		string path = Application.persistentDataPath + "/player.dat";
		if(File.Exists(path)){

			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);

			Playerdata data = formatter.Deserialize(stream) as Playerdata;
			stream.Close();

			return data;

		} else{
				Debug.LogError("not found");
				return null;
			}
	}
}
