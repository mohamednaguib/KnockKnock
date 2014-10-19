using knockknock.readify.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPillService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPillService.svc or RedPillService.svc.cs at the Solution Explorer and start debugging.
    public class RedPillService : IRedPill
    {
        public ContactDetails WhoAreYou()
        {
            return new ContactDetails()
            {
                GivenName = "Mohamed",
                FamilyName = "Naguib",
                EmailAddress = "mohamed.naguib.92@hotmail.com",
                PhoneNumber = "+2-0111-677-2397",
                Blog = "https://codeonthefly.ghost.io/"
            };
        }
        public System.Threading.Tasks.Task<ContactDetails> WhoAreYouAsync()
        {
            return Task.Factory.StartNew<ContactDetails>(() => WhoAreYou());
        }
        public long FibonacciNumber(long n)
        {
            return Fibonacci.ValueAt(n);
        }

        public System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n)
        {
            return Task.Factory.StartNew<long>(() => FibonacciNumber(n));
        }
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if ((a > (b + c)) || (b > (a + c)) || (c > (b + a)))
                return TriangleType.Error;
            else if (a < 0 || b < 0 || c < 0)
                return TriangleType.Error;
            else if (a == 0 || b == 0 || c == 0)
                return TriangleType.Error;
            else if (a == b && a == c)
                return TriangleType.Equilateral;
            else if (a == b || a == c || b == c)
                return TriangleType.Isosceles;
            else
                return TriangleType.Scalene;
        }

        public System.Threading.Tasks.Task<TriangleType> WhatShapeIsThisAsync(int a, int b, int c)
        {
            return Task.Factory.StartNew<TriangleType>(() => WhatShapeIsThis(a, b, c));
        }
        public string ReverseWords(string s)
        {
            if (s == null) throw new NullReferenceException("Value cannot be null");
            if (s.Length == 0) return "";
            char[] result = new char[s.Length];
            int i = 0; 
            while (i < s.Length)
            {
                while (i < s.Length && s[i] == ' ') result[i++] = ' '; 
                int j = i + 1; 
                while (j < s.Length && s[j] != ' ') j++; 
                ReverseWord(s, result, i, j - 1); 
                i = j; 

            }
            return new String(result);
        }

        private void ReverseWord(string s, char[] result, int i, int j)
        {
            while (i < s.Length && j >= i)
            {
                result[i] = s[j];
                result[j] = s[i];
                i++; j--;
            }
        }

        public System.Threading.Tasks.Task<string> ReverseWordsAsync(string s)
        {
            return Task.Factory.StartNew<string>(() => ReverseWords(s));
        }
    }
}
