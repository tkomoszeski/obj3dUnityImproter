using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjImporter : MonoBehaviour {

	public string Path;

	public void ImportObjModel()
	{
		Debug.Log ("Initalizing obj model: " + Path);
		GameObject objGameObject = OBJLoader.LoadOBJFile (Path);
		Material[] materials = OBJLoader.LoadMTLFile (Path);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
