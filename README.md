# C# Library Wrapper for JokeAPI
### Overview
- This C# library converts the JokeAPI at https://v2.jokeapi.dev/joke/Any into JSON.
- The library converts the incoming JSON to C# objects with properties for easy interaction in C# projects.
- It supports all of the returned data the API returns in JSON.
- Use exception handling in the application. Things go wrong.
- Built in .NET Standard 2.0

### Returned Data
 Joke
  * error - (bool)
  * category - Category of joke (string)
  * type - single, two-part (string)
  * joke - The text of the joke (string)
  * safe - true, false (bool)
  
### Joke API documentation
https://jokeapi.dev

### Installing
There are two methods of obtaining the JokeAPIV2.dll.
#### Easy Way
1. Download the JokeAPIV2.dll file. Copy it to your Visual C# project.
2. In your project that's using this code, reference the built DLL from the previous step:
   - Project dropdown -> Add Reference -> Search for the created DLL file.
   - Generally, the path is something like: `/JokeAPIV2/JokeAPIV2`
#### Hard Way - Build Your Own JokeAPIV2.dll
1. Clone this code with the GitHub desktop
2. Open the project in Visual Studio
3. Build the project
4. In the project that's using this code, reference or copy the built DLL to your project from the previous step:
   - Project menu -> Add Reference -> Search for the created DLL(s) file.
   - Generally, the path is something like: ./JokeAPIV2/JokeAPIV2`

### Example Project
This repository contains an example project.
- Console Example

### Credits and Libraries Utilized
- Newtonsoft.Json - JSON parsing class

### Purpose
I am Bill Loring, an Information Technology Instructor at Western Nebraska Community College. I teach Information Technology Technical Support, CyberSecurity and Computer Science.

This library was created for a Visual C# introductory programming class as a tutorial. Students are given the opportunity to learn how to consume a public API without the underlying complexity of parsing json or xml. It reinforces OOP concepts of objects and properties, while being a fun and interesting project.

### Changes
- 03/14/2021: Initial commit

### License
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.

Copyright (c) 2021 William A Loring
