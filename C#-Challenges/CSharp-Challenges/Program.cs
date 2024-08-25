using CSharp_Challenges;

Beginner beginner = new Beginner();

#region Beginner

Execute(beginner.Beginner1000HelloWorld, false);
Execute(beginner.Beginner1001ExtremelyBasic, true);
Execute(beginner.Beginner1002AreaOfACircle, true);


#endregion


void Execute(Action methodToExecute, bool hasInput = false)
{
    Console.WriteLine(new string('-', 30));
    Console.WriteLine(methodToExecute.Method.Name);
    if (!hasInput) methodToExecute();
}
