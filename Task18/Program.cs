//Написать программу, которая по заданному номеру четверти 
// показывает диапазон возможных координат точек x и y в этой четверти.
 string RangeOfCoordinates (int quarter)
 {
 if (quarter == 1) return "x>0; y>0";
 if (quarter == 2) return "x<0; y>0";
 if (quarter == 3) return "x<0; y<0";
 if (quarter == 4) return "x>0; y<0";
 return null;
 }

 Console.WriteLine("Введите номер четверти");
 int quarter = Convert.ToInt32(Console.ReadLine());

 string rangeOfCoordinates = RangeOfCoordinates(quarter);
 string result = rangeOfCoordinates != null ? rangeOfCoordinates : "введены некорректные данные";
 Console.WriteLine(result);

