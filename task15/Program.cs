﻿// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i >= 1 & i <= 5) Console.WriteLine("Будний день");
if (i == 6 | i == 7) Console.WriteLine("Выходной");