using System; 

using System.Collections.Generic; 

  

class GFG { 

  

    // Main Method 

    static public void Main() 

    { 

  

        // Creating a linkedlist 

        // Using LinkedList class 

        LinkedList<String> my_list = new LinkedList<String>(); 

  

        // Adding elements in the LinkedList 

        // Using AddLast() method 

        my_list.AddLast("Zoya"); 

        my_list.AddLast("Shilpa"); 

        my_list.AddLast("Rohit"); 

        my_list.AddLast("Rohan"); 

        my_list.AddLast("Juhi"); 

        my_list.AddLast("Zoya"); 

  

        Console.WriteLine("Best students of XYZ university:"); 

  

        // Accessing the elements of  

        // LinkedList Using foreach loop 

        foreach(string str in my_list) 

        { 

            Console.WriteLine(str); 

        } 

    } 
} 
