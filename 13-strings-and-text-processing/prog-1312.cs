/*
|--------------------------------------------------------------------------
| Chapter 13. Strings and Text Processing
|--------------------------------------------------------------------------
|
| Exercise 12:
|
|     Write a program that parses an URL in following format:
|
|       * [protocol]://[server]/[resource]
|
|     It should extract from the URL the protocol, server
|     and resource parts. For example, when http://www.cnn.com/video
|     is passed, the result is:
|
|       * [protocol]="http"
|         [server]="www.cnn.com"
|         [resource]="/video"
|
| Solutions and Guidelines:
|
|     Use a regular expression or search for the respective
|     splitters – two slashes for a protocol and one slash
|     as a separator between the server and the resource.
|     Test the special cases like missing parts of the URL.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.netflix.com/rick-and-morty";
            string[] urlParts = url.Split(new char[] { ':', '/' } , StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"\nBefore splitting the URL: {url}\n");
            Console.WriteLine("After the split:\n");
            Console.WriteLine($"[protocol]=\"{urlParts[0]}\"");
            Console.WriteLine($"[server]=\"{urlParts[1]}\"");
            Console.WriteLine($"[resource]=\"/{urlParts[2]}\"");
        }
    }
}