# README
****

### Description
- This program is a **DOTNET** console application written in **C#**.
- It is created to exlude from **string** arrays any items  longer than *3* chars.
-  This task is achieved by using 4 separate methods.

****

### Methods
- ```string[] CreateStringArray()```Creates and manually fills **string** array to work with.
- ```int ElementNumberCount(string[] arr)``` Counts number of elements in input array which are smaller than 4 chars.
- ``` string[] CreateNewArray(int number, string[] arr)``` Creates new **string** array by length of input number and fills it with elements of input array whith length less than 4 chars.
- ``` void PrintStringArray(string[] arr)``` Outputs elements of input array to the console.

****

### Input

- After the start of the program user will see "**Введите количество элементов массива**" line.
It demands to enter the number of elements of the input **string** array. Enter **int** number.
- Then user will see "**Введите элемент массива номер {i}**" line, which demands to enter one element at a time. Enter **string** for each *i*.

### Output
- Program will output to the console elements of the input **string** array with length less than 4 chars in the same order they were entered.