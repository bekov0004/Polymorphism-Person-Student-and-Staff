using Home_Work.Services;
                   //Student  
var student = new Student("Anushervon","Dushanbe","Programa",2022,5000);
Console.WriteLine(student.ToString());
student.SetAddress("Kulob");
student.SetProgram("C#");
student.SetYear(2023);
student.SetFee(10000);
Console.WriteLine(student.ToString());
Console.WriteLine($"Name: {student.GetName()}");
Console.WriteLine($"Address: {student.GetAddress()}");
Console.WriteLine($"Program: {student.GetProgram()}");
Console.WriteLine($"Year: {student.GetYear()}");
Console.WriteLine($"Fee: {student.GetFee()}\n");

//Staff
var staff = new Staff("Muhammaad","Dushanbe","Softclub",3000);
Console.WriteLine(staff.ToString());
staff.SetAddress("Farhor");
staff.SetSchool("Amerkan School");
staff.SetPay(1500);
Console.WriteLine(staff.ToString());
Console.WriteLine($"Name: {staff.GetName()}");
Console.WriteLine($"Address: {staff.GetAddress()}");
Console.WriteLine($"GetSchool: {staff.GetSchool()}");
Console.WriteLine($"Fee: {staff.GetPay()}"); 












