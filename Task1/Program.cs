// TASK 1 ---------------------
Console.WriteLine("Введите целое число для определения его кратности 7 и 23:");
int a =Convert.ToInt32(Console.ReadLine());
if (a%7 == 0 & a%23 == 0)
 {   Console.WriteLine("Число " + a + " кратно 7 и 23 \n");
 } else {
    Console.WriteLine("Число " + a + " не кратно 7 и 23 \n");
 }

// TASK 2 ---------------------
Console.WriteLine("Введите координату x:");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y:");
int y =Convert.ToInt32(Console.ReadLine());
if (x>0 & y>0)
{
   Console.WriteLine("Координата находится в первой четверти графика \n");
} else if (x<0 & y>0){
   Console.WriteLine("Координата находится в второй четверти графика \n");
} else if (x<0 & y<0){
   Console.WriteLine("Координата находится в третьей четверти графика \n");
} else {
   Console.WriteLine("Координата находится в четвертой четверти графика \n");
}

// TASK 3 ---------------------
Console.WriteLine("Введите число от 10 до 99:");
int MaxFig= Convert.ToInt32(Console.ReadLine());
if (MaxFig%10 > MaxFig/10)
{
   Console.WriteLine("большая цифра - " + MaxFig%10 + "\n");
}else{
   Console.WriteLine("большая цифра - " + MaxFig/10 + "\n");
}

// TASK 4 ---------------------
Console.WriteLine("Введите число:");
long Cifra= Convert.ToInt64(Console.ReadLine());

if (Cifra < 10)
 {
   Console.WriteLine(Cifra);
 }else{
   while (Cifra/10 !=0)
   {
   Console.Write(Cifra%10 + ", ");
   Cifra = (Cifra - Cifra%10)/10;
   // 
   }Console.WriteLine(Cifra);
 }
