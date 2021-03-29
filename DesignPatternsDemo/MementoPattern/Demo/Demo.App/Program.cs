﻿using System;

namespace Demo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trying out memento!");

            var student = new Student();
            try
            {
                student.StartAdmissionProcess();
                throw new Exception();
            }
            catch (Exception)
            {
                student.Revert();
            }

            Console.WriteLine($"Student status after failure {student.Status}");
            Console.ReadKey();
        }
    }
}
