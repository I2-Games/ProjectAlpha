using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour {
	private float volume;
	private Slider volumeSlider;

	public bool muted = false;

	// Use this for initialization
	void Start () {
		volumeSlider = GameObject.Find("VolumeSlider").GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnChangeVolume(){
		if(muted){
			AudioListener.volume = 0;
			Debug.Log ("Muted");
		}else{
			volume = volumeSlider.value;
			AudioListener.volume = volume/11;
			Debug.Log (volume);
		}
	}
	public void Mute(){
		muted = !muted;
		OnChangeVolume();
	}
	public void CloseOptions(){
		Destroy(this.gameObject);
	}
}
