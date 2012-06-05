# Silverlight Metro Style Wizard

This is the source code that accompaniments the [blog post](http://stevenhollidge.blogspot.co.uk/2012/06/silverlight-metro-style-wizard.html) by [Steven Hollidge](http://stevenhollidge.com).

## About
The aim is promote, share and cross pollinate ideas and approaches for data entry within Metro style apps.

Here's where you can find the source:  [https://github.com/stevenh77/MetroWizard](https://github.com/stevenh77/MetroWizard)

## Screenshots

![Screenshot#1](http://stevenhollidge.com/blog-source-code/metrowizard/wizard.PNG)

![Screenshot#2](http://stevenhollidge.com/blog-source-code/metrowizard/wizard-currencies.PNG)

## So what useful things are in the project?

* An animation for the left hand sidebar sliding in at the beginning

* Examples of the Visual State Manager being used to set the visibility on various controls as the user steps through the wizard

* Comments within the Xaml explaining what each Xaml code block does

* An Image button control.  You only need to set the image and pressed image and it’s ready to go

* An example of MVVM, with view models used for the main page and two of the wizard steps (Unique Identifiers and Currencies)
INotifyDataErrorInfo and an injectable validation rules engine (courtesy of Fluent Validation for .NET) for verifying the user input

* BindVisualStateBehaviour class and converter that shows how to bind the Visual State Managers current visual state to a property in your view mode, from within your Xaml