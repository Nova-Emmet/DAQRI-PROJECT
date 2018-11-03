# DAQRI-PROJECT
A list of scripts I used with a DAQRI Smart Helmet project. The purpose of the project was to carry out an inspection on an industrial
cabinet, follow a list of specific instructions on how to provide basic maintenance, view a thermal view and take a screenshot of issues. 
The project can also generate a PDF report upon completion.

These are just samples of the scripts. No assets or project files are included.

Controller.cs is used to control the flow of the app. You navigate the UI elements, take as screenshot, generate a PDF report and 
have the option of resetting the project or quitting at the end.

LocalisationScript.cs is used to swap the text objects within the app to either English or Spanish. There is a floating UI that 
provides this option throught the application.

CapturePicture.cs is a script used to take a screenshot of the current DAQRI camera view. I provide a 5 second countdown before the picture is taken and save it as part of the PDF report.

