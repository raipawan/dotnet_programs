﻿using System;namespace ConsoleApp2{    class Program    {        static void Main(string[] args)        {            const int IS_FULL_TIME = 1;            const int IS_PART_TIME = 2;            const int RATE_PER_HOUR = 20;            const int WORKING_HOUR = 20;            int EmpWage = 0;            int EmpHr = 0;            Random random = new Random();            int EmpCheck = random.Next(0, 3);            if (EmpCheck == IS_FULL_TIME)            {                 EmpHr = 8;            }            else if ( EmpCheck == IS_PART_TIME )            {                EmpHr = 4;            }            else            {                EmpHr = 0;            }            EmpWage = EmpHr*RATE_PER_HOUR ;            Console.WriteLine( EmpWage);            Console.ReadKey();        }    }}