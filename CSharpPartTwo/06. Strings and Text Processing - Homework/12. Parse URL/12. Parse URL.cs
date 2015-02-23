using System;

class ParseURL
{
    static void Main()
    {
        /*•	Write a program that parses an URL address given in the format:
         * [protocol]://[server]/[resource] and extracts from it the [protocol],
         * [server] and [resource] elements.*/
         string url = "http://telerikacademy.com/Courses/Courses/Details/212";

        int index = 0;

        index = url.IndexOf(':');
        Console.WriteLine("[protocol] = {0}", url.Substring(0,index));
        url = url.Remove(0, index + 3);

        index = url.IndexOf('/');
        Console.WriteLine("[server] = {0}", url.Substring(0,index));
        url = url.Remove(0, index);

        Console.WriteLine("[resource] = {0}", url);
    }
}
