// программа на вход два числа, выводит большее и меньшее.
// 5-7.2-10.-9--3.


// !!!РАСКОМЕНТИРОВАТЬ НУЖНЫЕ ЗНАЧЕНИЯ ПЕРЕМЕННОЙ!!!



int a = 5;
int b = 7;

//int a = 2;
//int b = 10;

//int a = -9;
//int b = -3;

int max = a;

if (a>max) max = a;
if (b>max) max = b;

Console.Write("max = ");
Console.WriteLine(max);

