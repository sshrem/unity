using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class FileUtil {

	public string message = "hello";

	public static string[] GetSmPaths () {
//		Debug.Log (this.GetType ().Name + " is starting up!");
		string path = Directory.GetCurrentDirectory();
		Debug.Log (path);
		string [] filenames;
		filenames = Directory.GetFiles("Assets/Resources/Apartments", "*SM_*.fbx", SearchOption.AllDirectories)
			.Select(x => Path.GetDirectoryName(x).Substring(17) + Path.VolumeSeparatorChar  + Path.GetFileNameWithoutExtension(x)).ToArray();

		return filenames;
	}
	
}
