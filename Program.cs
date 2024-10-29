Console.WriteLine("введите количество месяцев");
int n= Convert.ToInt32(Console.ReadLine());

DateTime SD = new DateTime(1998, 1, 1);
DateTime RD = SD.AddMonths(n).AddDays(2);

string NoY = RD.ToString("dddd");
string NoM = RD.ToString("MMMM");
int year  = RD.Year;
int day = RD.Day;
bool LY = DateTime.IsLeapYear(year);

Console.WriteLine($"день, месяц, год, день недели полученного года: {day} {NoM} {year} {NoY}");
Console.WriteLine($"является ли полученный год високоснымk: {(LY ? "да" : "нет")}");