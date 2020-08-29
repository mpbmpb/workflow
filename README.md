
<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
![Coverage][coverage-shield]
![Tests][tests-shield]
![GitHub code size in bytes][codesize-shield]
[![Contributors][contributors-shield]][contributors-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]




<!-- PROJECT LOGO -->
<br />
<p align="center">
<a href="https://github.com/mpbmpb/workflow">
   <img src="/gitAssets/workstation.jpg" height="320" width="505">
</a>

  <h1 align="center">Workflow</h1>

  <p align="center">
    <a href="https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop">
    <img src="/gitAssets/csharpintermediate.jpg"></a>
    <br />
    <br />
    <br />
    A coding exercise from the udemy course C# intermediate
    <br />
    <a href="https://www.udemy.com"><img src="/gitAssets/udemylogo.svg" height="90" width="90"></a>
    <br />
    <a href="https://github.com/mpbmpb/workflow/issues">Report Bug</a>
    ·
    <a href="https://github.com/mpbmpb/workflow/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
  * [Specifications](#specifications)
* [What I learned from this project](#what-i-learned-from-this-project)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project
<p align="center">
  <img src="/gitAssets/code.jpg" width="480" height="300">
</p>
This is a short console app written as an exercise given in de udemy course C# Intermediate by Mosh Hamedani.
<br/>
<br/>
The app models a workflow engine that takes workflow objects and executes the methods they contain.
<br/>
<br/>
I wrote all of the exercises for this course using the TDD approach of writing tests first and then production code.
The tests are written using xUnit and Fluent Assertions.
<br/>
<br/>
Thank you Mosh Hamedani for making a comprehensive and easy to follow course. :star:
<br/>
<br/>
A list of commonly used resources that I found helpful are listed in the acknowledgements.

### Built With
The code was written in Visual Studio.<br/>
The test coverage was measured with JetBrains dotCover.

* [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp)
* [xUnit](https://xunit.net)
* [Fluent Assertions](https://fluentassertions.com/)
* [dotCover](https://www.jetbrains.com/dotcover/)

### Specifications
The given specifications were:
<br/>
<h2>Exercise: Design a workflow engine</h2>
Design a workflow engine that takes a workflow object and runs it. A workflow is a series of steps or activities. The workflow engine class should have one method called Run() that takes a workflow, and then iterates over each activity in the workflow and runs it.
<br/>
<br/>
We want our workflows to be extensible, so we can create new activities without impacting the existing activities.
<br/>
<br/>
Educational tip: we should represent the concept of an activity using an interface. Each activity should have a method called Execute(). The workflow engine does not care about the concrete implementation of activities. All it cares about is that these activities have a common interface: they provide a method called Execute(). The engine simply calls this method and this way it executes a series of activities in sequence.
<br/>
<br/>
For the purpose of this exercise, do not worry about these complexities. Simply use Console.WriteLine() in each of your activity classes.


## What I learned from this project
How to use interfaces to create loosely coupled systems with polymorphic behaviour.

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple example steps.

### Prerequisites

Visual Studio needs to be installed along with the dotnet core runtime and SDK
All can be installed by the Visual Studio installer.

* The installer can be found on this page 
```sh
[Visual Studio documentation](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019)
```

### Installation

1. Open Terminal
2. Navigate to the directory where you want to install the files
3. Clone the repo
```sh
git clone https://github.com/mpbmpb/workflow.git
```
3. go to the workflow directory
```sh
cd workflow
```
4. run the app from the terminal
```
dotnet run
```
5. or find the workflow.sln file in your explorer and double click it.
   Visual Studio should take it from there.


<!-- USAGE EXAMPLES -->
## Usage

This project is meant purely as an educational exercise.

<!-- ROADMAP -->
## Roadmap

There are currently no plans to expand this project.
Feel free to contribute if you want to add something.

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact
Feel free to contact me if you have questions or suggestions.

Mark van den Beemt - markkeyster@gmail.com

Project Link: [https://github.com/mpbmpb/workflow](https://github.com/mpbmpb/workflow)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Mosh Hamedani's C# intermediate course](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop)
* [GitHub best readme template](https://github.com/othneildrew/Best-README-Template)
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Img Shields](https://shields.io)
* [Choose an Open Source License](https://choosealicense.com)
* [GitHub Pages](https://pages.github.com)
* [flaticon](https://www.flaticon.com)
* [unsplash](https://unsplash.com)
* <span>Photo by <a href="https://unsplash.com/@markusspiske?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText">Markus Spiske</a> on <a href="https://unsplash.com/s/photos/code?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText">Unsplash</a></span>
* Icons made by <a href="https://www.flaticon.com/authors/pixel-perfect" title="Pixel perfect">Pixel perfect</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[coverage-shield]: https://img.shields.io/badge/coverage-100%25-brightgreen?style=plastic
[tests-shield]: https://img.shields.io/badge/tests-passing-brightgreen?style=plastic
[contributors-shield]: https://img.shields.io/github/contributors/mpbmpb/workflow?color=blue?style=plastic
[contributors-url]: https://github.com/mpbmpb/workflow/graphs/contributors
[codesize-shield]: https://img.shields.io/github/languages/code-size/mpbmpb/workflow?style=plastic
[stars-shield]: https://img.shields.io/github/stars/mpbmpb/workflow?style=plastic
[stars-url]: https://github.com/mpbmpb/workflow/stargazers
[issues-shield]: https://img.shields.io/github/issues/mpbmpb/workflow?style=plastic
[issues-url]: https://github.com/mpbmpb/workflow/issues
[license-shield]: https://img.shields.io/github/license/mpbmpb/workflow?style=plastic
[license-url]: https://github.com/mpbmpb/workflow/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?logo=linkedin&style=plastic&colorB=555
[linkedin-url]: https://www.linkedin.com/in/mark-van-den-beemt-7805011b1/
