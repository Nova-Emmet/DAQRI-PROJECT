using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script used to set the text objects within a project to either English or Spanish 
//ifEnglish and ifSpanish are attached to buttons within the scene and are selected on the first step

public class LocalisationScript : MonoBehaviour {

	//public Text scanMarker;
	public Text language;
	public Text intro;
	public Text step1;
	public Text step1next; 
	public Text step2;
	public Text step2next; 
	public Text step3;
	public Text step3next; 
	public Text step4;
	public Text step4next; 
	public Text step5;
	public Text finish;

	public Text camera1;
	//public Text camera2;
	public Text camera3;

	public Text capture;
	public Text generate;

	public Text generateReport;

	public Text reset;
	public Text quit;

	public Text yes;
	public Text no;

	public Text onoff;
	public Text onoffyes;
	public Text onoffno;

	public Text scroll;

	ExampleScrollViewController example;

	// Use this for initialization
	void Start () {
	//	scanMarker = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ifEnglish(){
		
	//	scanMarker.text = "Please Scan Marker";

		language.text = "Select Language";
		intro.text = "Panel 19 identified.\n\nLet's begin";

		step1.text = "Step 1. \n\nIdentify status of power button";
		step2.text = "Step 2. \n\nMeasure current reading"; 
		step3.text = "Step 3. \n\nOpen cabinet";
		step4.text = "Step 4. \n\nTake thermal picture";
		step5.text = "Step 5. \n\nGenerate report";

		step1next.text = "Next"; 
		step2next.text = "Next"; 
		step3next.text = "Next"; 
		step4next.text = "Next"; 

		camera1.text = "Capture Image \n\nThere will be a 5 second countdown";
		//camera2.text = "Please look here";
		camera3.text = "Retake Image?";

		capture.text = "Capture ";
		generate.text = "Generate ";

		generateReport.text = "Report generated\n\n Please quit or reset app";

		reset.text = "Reset";
		quit.text = "Quit";

		yes.text = "Yes";
		no.text = "No";

		onoff.text = "Please select On or Off";
		onoffyes.text = "On";
		onoffno.text = "Off";

		scroll.text = "Select Current Level";

		finish.text = "Finish";

		example.setInputext ("Current is");
	}

	public void ifSpanish(){
		
//		scanMarker.text = "Por favor escanear marcador";
		language.text = "Seleccionar Idioma";
		intro.text = "Panel 19 identificado\n\n¡Comencemos!";

		step1.text = "Identificar estado de botón de encendido";
		step2.text = "Medir indicador de corriente"; 
		step3.text = "Abrir gabinete";
		step4.text = "Tomar foto térmica\n";
		step5.text = "Generar Reporte";

		step1next.text = "Siguiente"; 
		step2next.text = "Siguiente"; 
		step3next.text = "Siguiente"; 
		step4next.text = "Siguiente"; 

		onoff.text = "Seleccionar Detenido y Funcionando";
		onoffyes.text = "Detenido";
		onoffno.text = "Funcionando";

		camera1.text = "Capturar Imagen. Habrá una cuenta regresiva desde 5";
		//camera2.text = "Por favor mire aquí";
		camera3.text = "¿Volver a tomar imagen?";

		capture.text = "Capturar";
		generate.text = "Generar";

		generateReport.text = "Reporte generado. Por favor salir o reiniciar app";

		yes.text = "Sí";
		no.text = "No";

		reset.text = "Reiniciar";
		quit.text = "Salir";

		scroll.text = "Indicar Nivel de Amperaje";

		finish.text = "Finalizar";

		example.setInputext ("Corriente de");
	}
}
