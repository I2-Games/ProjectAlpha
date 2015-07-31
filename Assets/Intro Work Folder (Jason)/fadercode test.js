 #pragma strict

enum fadetype { In, Out };
var fade : fadetype;
var trigger : boolean = false;
var triggerTarget : GameObject;
var delay = 2;
   
 var fadeTexture : Texture2D;
 var fadeSpeed = 1;
 private var drawDepth = -1000;
 private var delayOver : boolean = false;
 
 private var alpha = 1.0; 
 private var fadeDir : float;
 
 function Start () 
 {
 	if (fade == fadetype.Out) 
 	{
 		fadeDir = 1;
 		alpha = 0.0;
 	}
 	if (fade == fadetype.In)
 	{
 		fadeDir = -1;
 		alpha = 1.0;
 	}
 }
 
 function Update () 
 {
 	if ( Time.time > delay )
 	{
 		delayOver = true;
 	}
 	
 	if ( (fade == fadetype.Out && alpha == 1.0) || ( fade == fadetype.In && alpha == 0 ) ) 
 	{
 	 	if ( trigger ) 
 	 	{
 	 		Debug.Log("Finished time is: " + Time.time);
 	 		triggerTarget.SetActive(true);
 	 	}
 	 	gameObject.SetActive(false);
	}
 	
 }
 
 function OnGUI(){
     
     if (delayOver){
	     alpha += fadeDir * (fadeSpeed * .01) * Time.deltaTime;  
	     alpha = Mathf.Clamp01(alpha);   
     }
     GUI.color.a = alpha;
     GUI.depth = drawDepth;
     GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), fadeTexture);
     
 }