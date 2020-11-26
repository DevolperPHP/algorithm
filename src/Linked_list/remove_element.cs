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

  

        // Inital number of elements 

        Console.WriteLine("Best students of XYZ "+ 

                         "university initially:"); 

  

        // Accessing the elements of  

        // Linkedlist Using foreach loop 

        foreach(string str in my_list) 

        { 

            Console.WriteLine(str); 

        } 

  

        // After using Remove(LinkedListNode) 

        // method 

        Console.WriteLine("Best students of XYZ"+ 

                         " university in 2000:"); 

  

        my_list.Remove(my_list.First); 

  

        foreach(string str in my_list) 

        { 

            Console.WriteLine(str); 

        } 

  

        // After using Remove(T) method 

        Console.WriteLine("Best students of XYZ"+ 

                         " university in 2001:"); 

  

        my_list.Remove("Rohit"); 

  

        foreach(string str in my_list) 

        { 

            Console.WriteLine(str); 

        } 

  

        // After using RemoveFirst() method 

        Console.WriteLine("Best students of XYZ"+ 

                         " university in 2002:"); 

  

        my_list.RemoveFirst(); 

  

        foreach(string str in my_list) 

        { 

            Console.WriteLine(str); 

        } 

  

        // After using RemoveLast() method 

        Console.WriteLine("Best students of XYZ"+ 

                         " university in 2003:"); 

  

        my_list.RemoveLast(); 

  

        foreach(string str in my_list) 

        { 

            Console.WriteLine(str); 

        } 

  

        // After using Clear() method 

        my_list.Clear(); 

        Console.WriteLine("Number of students: {0}", 

                                     my_list.Count); 
