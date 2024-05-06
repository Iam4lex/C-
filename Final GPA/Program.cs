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


int sum = 0;
int[] marks = new int[8];

string[] unit = {"CSC220", "CSC221", "CSC222", "CSC223", "CSC224", "CSC225", "CSC226", "CSC227"};

for (int i = 0; i < 8; i++){
    Console.WriteLine("Enter mark for " + unit[i]);

    marks[i] = Convert.ToInt32(Console.ReadLine());

    if(marks[i] > 100 || marks[i] < 0){
        Console.WriteLine("Enter a valid number !!");
        i--;
    }

}

for (int i = 0; i < 8; i++){
    sum += marks[i];
}

// Calculate the average
int average = sum / 8;


Console.WriteLine("\n\nName : " + name);

Console.WriteLine("Adm No: " + admNo);

Console.WriteLine("Sum : " + sum);

Console.WriteLine("Average : " + average);

// Final Grade

 if (average > 69 && average <= 100){
    Console.WriteLine("Your grade is A");
}

else if (average > 59 && average < 70){
    Console.WriteLine("Your grade is B");
}

else if (average > 49 && average < 60){
    Console.WriteLine("Your grade is C");
}

else if (average > 39 && average < 50){
    Console.WriteLine("Your grade is D");
}

else if (average > 0 && average < 40){
    Console.WriteLine("Fail");
}

else {
    Console.WriteLine("Ivalid Average");
}
