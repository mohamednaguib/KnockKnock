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
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    interface IRedPill
    {
        [OperationContract]
        ContactDetails WhoAreYou();
        [OperationContract]
        long FibonacciNumber(long n);
        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);
        [OperationContract]
        string ReverseWords(string s);
    }

}
