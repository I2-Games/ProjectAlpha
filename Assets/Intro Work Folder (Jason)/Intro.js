//#pragma strict

var introMusic : GameObject;
var introVoiceOver : GameObject;
var image_1 : Texture2D;
var image_2 : Texture2D;


function Start () {
	
	//Use the yields to setup timing for images, fades, etc.
	introMusic.SetActive(true);
	yield WaitForSeconds(4.5);
	introVoiceOver.SetActive(true);
	yield WaitForSeconds(1.0);
	image_1 = image_2;
	yield WaitForSeconds(10);
	gameObject.SetActive(false);


}

//Going to remove this and place it as a gui element on its own object. so that timing will be handled by the start area. and then de-active the entire intro so it won't use resources.

function OnGUI () {

	GUI.DrawTexture( Rect(0,(Screen.height/2) - (image_1.height /4),Screen.width,image_1.height/2), image_1, ScaleMode.StretchToFill, true, 50.0f );

}