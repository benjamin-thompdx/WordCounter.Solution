# _Word Counter_

#### _Word Counter terminal application_, _Mar. 3, 2020_

#### By _**Benjamin Thom**_

## Description

_An application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence (checks for full word matches only)._

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|A user inputs a sentence and the application collects the response as an array of strings|"the quick brown fox jumps over the lazy dog"|{ "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" }|
|The Application verifies that user's sentence only contains letters|"the 6 quick brown foxes jumps over the 2 lazy dogs"|false|
|A user inputs a word and the application collects the response|"the"|"the"|
|The Application verifies that user's word only contains letters|"6"|false|
|The application checks how frequently the user's word (full word matches only) appears in the user's sentence|"the", "the"|2|

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/benjamin-thompdx/WordCounter.Solution.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} WordCounter.Solution```
* On Windows: ```WordCounter.Solution```

_Download Manually:_

* Navigate to https://github.com/benjamin-thompdx/WordCounter.Solution.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "WordCounter.Solution".

_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/benjamin-thompdx/WordCounter.Solution/issues) here on GitHub._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_
* _VS Code_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Benjamin Thom_**