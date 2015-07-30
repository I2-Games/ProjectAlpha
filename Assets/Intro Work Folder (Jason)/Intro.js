//#pragma strict

var introMusic : AudioClip;
var introVoiceOver : AudioClip;
var blackScreen : Texture2D;
var image_1 : Texture2D;
var image_2 : Texture2D;
var mainMenuPlaceHolder : Texture2D;

var audioSource_1;
var audioSource_2;
function Start () {

var loadingAudioSources = gameObject.GetComponents(AudioSource);
audioSource_1 = loadingAudioSources[0];
audioSource_2 = loadingAudioSources[1];
audioSource_1.clip = introMusic;
audioSource_2.clip = introVoiceOver;
audioSource_2.Play();


// There apears to be a limitation on audio scources for an object. Cashing a list and using 
// Seperately won't work. Going to have to setup a toggle system for sound objects.


}

function Update () {

	if ( Time.time > 2 )
	{
		audioSource_1.Play();
	}

}

function OnGUI () {

GUI.DrawTexture( Rect(0,(Screen.height/2) - (image_1.height /4),Screen.width,image_1.height/2), image_1, ScaleMode.StretchToFill, true, 50.0f );

}