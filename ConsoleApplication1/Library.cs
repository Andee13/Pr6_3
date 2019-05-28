using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Library
    {
        List<Book> arr = new List<Book>();

        public Book getBookbyName(String name)
        {
            foreach (var VARIABLE in arr)
            {
                VARIABLE.Equals(name);
                return (Book)VARIABLE;
            }
            return null;

        }
        
        public bool add(Book book)
        {
            try
            {
                arr.Add(book);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }    
            
        }
    }
}