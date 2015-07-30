 #pragma strict
 
 // FadeInOut
 
 var fadeTexture : Texture2D;
 var fadeSpeed = 0.01;
 var drawDepth = -1000;
 var delay = 2;
 var fading : boolean = false;
 
 private var alpha = 1.0; 
 private var fadeDir = -1;
 
 function Update () {
 	Debug.Log(Time.time);
 	if ( Time.time > delay )
 	{
 		fading = true;
 	}
 }
 
 function OnGUI(){
     
     if (fading){
     alpha += fadeDir * fadeSpeed * Time.deltaTime;  
     alpha = Mathf.Clamp01(alpha);   
     
     GUI.color.a = alpha;
     }
     
     GUI.depth = drawDepth;
     
     GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), fadeTexture);
 }