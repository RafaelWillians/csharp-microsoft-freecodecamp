int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    //É possível determinar da forma abaixo, para que dois cases distintos executem a mesma ação.
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");