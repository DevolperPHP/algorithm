// to check whether the given  
// element is present or not  
// in the LinkedList 

using System; 

using System.Collections.Generic; 

  

class GFG { 

  

    // Main Method 

    static public void Main() 

    { 

  

        // Creating a linkedlist 

        // Using LinkedList class 

        LinkedList<String> my_list = new LinkedList<String>(); 

  

        // Adding elements in the Linkedlist 

        // Using AddLast() method 

        my_list.AddLast("Zoya"); 

        my_list.AddLast("Shilpa"); 

        my_list.AddLast("Rohit"); 

        my_list.AddLast("Rohan"); 

        my_list.AddLast("Juhi"); 

  

        // Check if the given element 

        // is available or not 

        if (my_list.Contains("Shilpa") == true)  

        { 

            Console.WriteLine("Element Found...!!"); 

        } 

        else 

        { 

            Console.WriteLine("Element Not found...!!"); 
