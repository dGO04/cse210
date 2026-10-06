using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Assigments Summary: ");
        MathAssigment math1 = new MathAssigment(studentName:"Diego Esquit", topic:"Quadratic Equations", textbookSection:"2.1", problems:"1-5, 7, 9-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.HomeworkList());
        
        Console.WriteLine(); //New line for good formatting

        WritingAssignment write1 = new WritingAssignment(studentName:"Roberto Arias", topic:"Guatemalan Civil War", assignmentTitle:"Is poverty a cause of war?");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInfo());

    }
}