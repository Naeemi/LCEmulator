using UnityEngine;
using System.Collections;
using System.Drawing;
using System;
using System.IO;
using System.Text;

public class Login : MonoBehaviour {

    public GameObject background_bg;
    public Texture2D bg_login;
    public Bitmap ass;

	// Use this for initialization
	void Awake () 
    {
        background_bg.guiTexture.pixelInset = new Rect((-(float)Screen.width / 2) + Screen.width / 2 - (float)856, (-(float)Screen.height / 2) + Screen.height/2-(float)454.35, (float)1712.2, (float)908.07);
      //  bg_login = Sprite.Cut("../desing/intro_common.png", 0, 0, 310, 275) as Texture2D;
    }
	

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 155, Screen.height / 2 - 30, 310, 275), bg_login, "");
       
       
    }

	// Update is called once per frame
	void Update () {
	
	}
}
