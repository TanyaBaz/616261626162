const int COEFFICIENT =0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.Write($"Точка пересечения уравнений
    y = {lineData1[COEFFICIENT]}*x+{lineData1[COEFFICIENT]} и
    y = {lineData2[COEFFICIENT]}*x+{lineData2[COEFFICIENT]} ");
    System.Console.WriteLine($" имеет координаты ({coord[X_COORD]}),
    ({coord[Y_COORD]})");
}
double Promt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT]  =Promt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONSTANT]  =Promt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}
double[] FindCoords(double[] lineData1,double[] lineData2)
{
    double coord = new double[2]
}