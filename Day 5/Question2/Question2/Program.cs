using System;
using AReport = CompanyA.Reporting.Report;
using BReport = CompanyB.Analytics.Report;

namespace Company
{
    public class Program()
    {
        static void Main(string[] args)
        {
            AReport reportA = new AReport();
            reportA.Generate();

            BReport reportB = new BReport();
            reportB.Generate();
        }
    }
}