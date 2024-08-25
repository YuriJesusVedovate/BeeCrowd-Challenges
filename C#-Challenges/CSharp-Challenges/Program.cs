using CSharp_Challenges;

Beginner beginner = new Beginner();

#region Beginner

Execute(beginner.Beginner1000HelloWorld);
Execute(beginner.Beginner1001ExtremelyBasic);

#endregion


void Execute(Action methodToExecute)
{
    Console.WriteLine(new string('-', 30));
    Console.WriteLine(methodToExecute.Method.Name);
    methodToExecute();
}
