// Program to calculate the final GPA of students

/*
    What we need
    1. Name and ADMNO of the students
    2. Number of units taken by the students
    3. Enter the marks of each unit
    4. Calculate sum
    5. Calculate the average
    6. Find the grade based on the average
*/

Console.WriteLine("Enter the name of the student");
string name = Console.ReadLine();

Console.WriteLine("Enter the Adm Number");
string admNo = Console.ReadLine();

Console.WriteLine("Name : " + name);

Console.WriteLine("AdmNo : " + admNo);

int sum = 0;
int marks;

string[] unit = {"CSC220", "CSC221", "CSC222", "CSC223", "CSC224", "CSC225", "CSC226", "CSC227"};

for (int i = 0; i < 8; i++){
    Console.WriteLine("Enter mark for " + unit[i]);
    marks = Console.ReadLine(); 
}

for (int i = 0; i < 8; i++){
    sum += marks[i];
}

System.i = sum;
