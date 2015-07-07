﻿using System;

namespace Calculator
{
    public static class FactoryTwoArgument
    {
        public static ITwoArgument CreatCalculator(string calculator)
        {
        	switch (calculator)
            {
                case "Minus":
                    return new Minus();
                case "Multiply":
                    return new Multiply();
                case "Divide":
                    return new Divide();
                case "Added":
                    return new Added();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }   
     }
}