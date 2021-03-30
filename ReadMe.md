# Mendix Functions To C# Converter

This project will approach the parsing and conversion of Mendix Functions to .Net/C# equivalent string representations.

#### *For example*

`addDays('[%CurrentDateTime%]', 3)` gets converted to `DateTime.Now.AddDays(3)`

If the parameters are fonctions too the program will attempt to recursively resolve those too