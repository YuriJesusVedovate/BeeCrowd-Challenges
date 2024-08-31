using CSharp_Challenges;

Beginner beginner = new Beginner();

#region Beginner

Execute(beginner.Beginner1000HelloWorld, false);
Execute(beginner.Beginner1001ExtremelyBasic, true);
Execute(beginner.Beginner1002AreaOfACircle, true);
Execute(beginner.Beginner1003SimpleSum, true);
Execute(beginner.Beginner1004SimpleProduct, true);
Execute(beginner.Beginner1005Average1, true);
Execute(beginner.Beginner1006Average2, true);
Execute(beginner.Beginner1007Difference, true);
Execute(beginner.Beginner1008Salary, true);
Execute(beginner.Beginner1009SalaryWithBonus, true);
Execute(beginner.Beginner1010SimpleCalculate, true);
Execute(beginner.Beginner1011Sphere, true);
Execute(beginner.Beginner1012Area, true);
Execute(beginner.Beginner1013TheGreatest, true);
Execute(beginner.Beginner1014Consumption, true);
Execute(beginner.Beginner1015DistanceBetweenTwoPoints, true);


#endregion


void Execute(Action methodToExecute, bool hasInput = false)
{
    Console.WriteLine(new string('-', 30));
    Console.WriteLine(methodToExecute.Method.Name);
    if (!hasInput) methodToExecute();
}
