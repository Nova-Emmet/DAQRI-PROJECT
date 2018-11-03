using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

//Script used to capture a picture of the current camera view within a DAQRI Smart Helmet.
//A 5 second timer will commence before the screenshot is taken.
//When the screenshot is taken, it will be saved to a folder within the helmet and pushed to a PDF report.

public class CapturePicture : MonoBehaviour {

	public Text textbox;
	public GameObject panel1;
	public GameObject panel2;
	public GameObject panel3;
	public GameObject panel4;
	public GameObject nextButton;
	public GameObject step4;

	public SimplePDF pdf;

	private float timer = -1;
	private int temptimer;
	// Use this for initialization
	void Start (){
	//	textbox = gameObject.GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		if(timer <= 9 && timer > 4){
			temptimer = (int)timer;
			temptimer -= 3;
			Debug.Log ("Time = "+temptimer);
			textbox.text = "\n\n" + temptimer;
			timer -= Time.deltaTime;
		}


		if(timer <= 4 && timer >= 1){
			panel1.SetActive (false);
			panel2.SetActive (false);
			Debug.Log ("Take picture");
			TakeScreenshot ();
			timer -= Time.deltaTime;
		}

		if (timer < 1 && timer > 0) {
			panel1.SetActive (true);
			panel2.SetActive (true);
			panel3.SetActive (false);
			panel4.SetActive (false);
			Debug.Log ("Last panel");
		}

		timer -= Time.deltaTime;

	}

	public void StartTimer(){
		timer = 9;
	}

	public void TakeScreenshot(){
		var pathToPictures = Environment.GetFolderPath (Environment.SpecialFolder.MyPictures);
		Application.CaptureScreenshot (pathToPictures+"ENAPImage.png");
		pdf.Path (pathToPictures);
		Debug.Log ("Screenshot taken");
	}

	public void CaptureComplete(){
		step4.SetActive (false);
		nextButton.SetActive (true);

	}

	public void reset(){
		panel2.SetActive (false);
		panel4.SetActive (false);
	}
}
