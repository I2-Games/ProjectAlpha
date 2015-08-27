using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	private bool optionsOpen = false;
	private GameObject options;

	public GameObject optionsUI;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel(string levelName){
		Application.LoadLevel(levelName);
	}
	public void Options(){
		if(!optionsOpen){
			options = Instantiate(optionsUI,Vector3.zero,Quaternion.identity) as GameObject;
			optionsOpen = true;
		}else{
			Destroy(options);
			optionsOpen = false;
		}
	}
}
