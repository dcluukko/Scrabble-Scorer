# _Scrabble Scorer_

#### _C# console application for Scrabble Scorrer game , March 5 2020_

#### By _**Fatma C. Dogan & Kristina Hengster Tintor**_

## Description

Console application that takes a word and returns the Scrabble score for that word.

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
| User gets 1 point for typing the following letters: A, E, I, O, U, L, N, R, S, T  | "A"| 1 |
| User gets 2 poings for typing the following letters: D, G   | "Do" | 2 + 1 | 
| User gets 3 poings for typing the following letters: B, C, M, P  | "Map" | 7 |
| User gets 4 poings for typing the following letters: F, H, V, W, Y | "hope" | 4 + 1 + 3 + 1 = 9 |
| User gets 5 poings for typing the following letters: K | "key" | 5 + 1 + 4 = 10 |
| User gets 8 poings for typing the following letters: J, X | "extra" | 1 + 8 + 1 + 1 + 1 = 12 |
| User gets 10 poings for typing the following letters: Q, Z | "zoo" | 10 + 1 + 1 = 12 |



## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone  ```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} ```
* On Windows: ```Pierre-s-Bakery```

_Download Manually:_

* Navigate to . 
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Pierre-s-Bakery".


_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* .Net Core