# Lab5PokeAPITesting

2/18/2024
Started by learning what the heck an API is
Learned what it is
Figured might as well stick to the pokemon theme of the class and decided on a RESTful API called PokeAPI

2/19/2024
Asked my uncle how he would approach this lab as a newbie but he just gave me some advance advice that flew over my head.  
He dummed it down quite a bit and explained that understanding the API first would be a good start.  PokeAPI was one that was well documented and felt like i understood what was going on and how to use it.
I planned out that i would make a simple testing project first that would be trail and error on calling a pokemon name and it would give me its corresponding PokeDex entry number.
2/20/2024 
started programming the project in mind
Used a libarary called Newtonsoft.Json that made working with JSON data easier to work with and learned about serialization and deserialization newtonsoft.json https://www.youtube.com/watch?v=nx37hWBWif4&ab_channel=ZetBit from this video.

I wasn't sure what my uncle was talking about when he talked about asynchronous programming and how it would help my program, so i looked into it some.  

I DID HOWERVER start to realize that PokeAPI is super well documented and i could easily make HTTTP request to the PokeAPI.  

I made a http request to the PokeAPI endpoint for the pokemon indentifier the user inputs and the response is read

The JSON response is then put into an object by using Deserialization and the relevent data is extracted from the JSON response (in this test project im using the pokemon name, id (dex number), and type.  

The data is put into the PokemonData object which is then returned to be displayed.

Will use this knowledge to make my presented lab 4 project

2/22/2024

I unfortunately thought that i was him and could do my proposed lab 5.  All i have to show is my test project. sad.  And i decided to upload the test lab 5 project and my notes onto Github as my submission for lab5.
