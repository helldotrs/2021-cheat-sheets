C# cheat sheet

About this document
  Written by Rebekah Hellberg, github.com/hellmak
  Copyright 2021.

  This document is created with the assumption that the end-user have a basic programming foundation.
  Always open to feedback, unless the feedback is dumb.

  Optimized for Atom editor.

  //FIXME: add operators


Introduction so C#
  - C# is case-sensitive.
  - ; for line-termination //which is inferior to line break
  - \ for escape
  - // inline comments
  - /* block comments */
  - /// XML comments

// Data //////////////////////////////////////////////////

Variables
  syntax
    datatype variable_name = value;

  naming rules
    must only start with
      letter, underscore

    must ONLY contain
      letters, numbers, underscores

  naming conventions
    check naming-conventions.py

Arrays
  syntax
    DataType[] array_name =                 {value, value};
    DataType[] array_name = new DataType[2] {value, value}; //expects 2 values

  examples
    int[]     numbers_string    = {0, 12, 345, 6789};
    string[3] top_3_cities      = {"Gothenburg", "Denver", "Hamburg"};

Strings
  concatenation
    Console.WriteLine("hello" + " " + "world.");

  string.format //FIXME
    example //FIXME
      (string.Format("{0:C}", 11)); //FIXME
        output: $11.00  //FIXME

// Statements ///////////////////////////////////////////////////


If / else / else if
  /*Note: dont use curly brackets for single-line code-blocks other than in examples*/

  syntax
    if(true){
      //do
    } else if(false) {
      //do
    } else{
      //not a boolean!!
    }

Tenary
  var = (condition) ? "output for true" : "output for false";

Switch
  /*cleaner than nested if Statements
  and only uses one var*/

  switch(expression) {
    case x:
      //do
      break;
    case y:
      //do
      break;
    default:
      //do
      break;
  }

While loop
  while (age < 50){
    Console.WriteLine(age);
    age++;
  }

For loop
  for(int i = age; i < 50; i++){
    Console.WriteLine(i);
  }

  //write 1-100
  for(int i= 0; i<= 100; i++){
    console.WriteLine(i);
  }

For each loop
  foreach (string city in top_3_cities){
    Console.WriteLine(city);
  }

// "ADV" //FIXME big time /////////////////////////////////////////////
Try catch / exceptions
  syntax
    try{
    }
    catch(Exception){
      throw;
    }

  example
    try{
      string result = "text";
      Console.WriteLine(Convert.ToInt32(result)+10); //FIXME
    }
    catch(Exception excp){
      Console.WriteLine(excp.Message);
    }

Methods
  //oNlY mEtHoDs, No fUnCtiOnS bEcAuSe C# Is OoOoOoOoOoObJeCt OrIeNtEd

  syntax
    static  - class does not have to be initiated to use this method
    void    - no return value
    datatype- set datatype to be returned
    public  - access allowed outside of class
    static  - access NOT allowed outside of class
      //FIXME - I must have messed up - how can something be "public static" if they are opposites??

  examples
    public void doSomething(){  //follow proper naming conventions, you're not special C#
    }

    public static void doSomething(){
      //do
    }

    public static DateTime returnTomorrow() //FIXME remove brackes for single line blocks also applies in C#?
      return DateTime.Now.AddDays(1);

Classes
  class CarClass{ //FIXME - straight up copied this part.
    public void Manufacturer(string Manufac){
      Console.WriteLine(Manufac);
    }
  }
  CarClass my_car = new CarClass();
  my_car.Manufacturer("Toyota");

Hello world
  using System;
  namespace HelloWorld{
    class Hello{
      static void Main(string[] args){
        Console.WriteLine("Hello world.");
      }
    }
  }
