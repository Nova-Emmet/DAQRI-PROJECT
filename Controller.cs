using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Overall controller script for the project. 
//The user would cycle through multiple UI panels, at the end having the option of quitting or restarting the project.


public class Controller : MonoBehaviour {

	public List<GameObject> steps;
	public GameObject pdf;

	public GameObject nextStep1;
	public GameObject nextStep2;
	public GameObject nextStep4;
	public GameObject on_off_ui;
	public GameObject scroll;	
	public GameObject audio;
	public GameObject begin;

	private int currentIndex;
	//public Image onButtonColor;
	//Color redColor;

	public GameObject model;

	public GameObject offButtonColor;

	void Start () {
		currentIndex = 0;
		foreach (GameObject step in steps) {
			step.gameObject.SetActive (false);
		}
		steps [currentIndex].gameObject.SetActive (true);
	
		#if UNITY_EDITOR
		model.SetActive(true);
		#endif
	}
	
	void Update () {
		
	}

	public void GoToNextStep(){
		if (currentIndex <= steps.Count - 2) {
			steps [currentIndex].SetActive (false);
			currentIndex++;
			steps [currentIndex].SetActive (true);
			Debug.Log ("Step " + currentIndex + " loaded");
		} else {
			Debug.Log ("You are at the last step");
		}
	}

	public void GoToPreviousStep(){
		if (currentIndex >= 1) {
			steps [currentIndex].SetActive (false);
			currentIndex--;
			steps [currentIndex].SetActive (true);
		}
	}

	public void Restart(){
		steps [currentIndex].SetActive (false);
		currentIndex = 0;
		steps [currentIndex].SetActive (true);
		Debug.Log ("Step "+currentIndex+" loaded");
	}

	public void Quit(){
		Debug.Log ("Quit Application");
		Application.Quit ();
	}

	public void createPDF(){
		Instantiate (pdf);
	}

	public void createAudio(){
		Instantiate (audio);
	}

	public void step1NextActive(){
		nextStep1.SetActive (true);
	}

	public void step2NextActive(){
		nextStep2.SetActive (true);
	}

	public void step4NextActive(){
		nextStep4.SetActive (true);
	}

	public void DestroyBegin(){
		begin.SetActive (false);
	}

	public void Reset(){
		on_off_ui.SetActive (true);
		nextStep1.SetActive (false);
		nextStep2.SetActive (false);
		nextStep4.SetActive (false);
	}

	public void reloadScene(){
		SceneManager.LoadScene("ENAP", LoadSceneMode.Single);
	}



//	public void colorOn(){
//		onButtonColor.GetComponent<Image>().color = new Color32(28,130,28,255);
//		offButtonColor.GetComponent<Image> ().color = new Color32 (163, 49, 49, 255);
//	}
}
