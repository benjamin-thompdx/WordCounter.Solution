# _Word Counter_

#### _Word Counter terminal application_, _Mar. 3, 2020_

#### By _**Benjamin Thom**_

## Description

_An application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence (checks for full word matches only)._

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|A user inputs a sentence and the application collects the response|"the quick brown fox jumps over the lazy dog"|"the quick brown fox jumps over the lazy dog"|
|The application converts the user's sentence into an array of strings|"the quick brown fox jumps over the lazy dog"|{ "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" }|
|A user inputs a word and the application collects the response and if the user's word is a full word match, the application displays the user word's frequency|"the"|"the"|
|The application calculates the frequency the user's word (full word matches only) within the user's sentence|"the", "the"|2|
|A user inputs a word and the application collects the response and if the user's word is not included in the user's sentence or is a partial match, the application displays a word frquency of 0|user sentence: "there are big mountains in Montana", user word: "the"|0|

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