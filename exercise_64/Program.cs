// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
int sum(int m, int n){
    if(m+1==n){
        return m+n;
    }
    else {
        return  sum(m,n-1)+n;
        }
}

Console.WriteLine("Введите два числа промежутка M и N");//m<n
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if(n<=m){Console.WriteLine("Введены некорректные значения");}
else{Console.WriteLine("Сумма числе в промежутке MN равна " +sum(m,n));}