
using test_function;

//Testing AFunction() and catching thrown exceptoins
foreach(var i in new int[] { int.MinValue, -11, -0, -9, -15, -5, -1, 0, 
    1, 4, 5, 6, 2, 10, int.MaxValue }) { 

try {
    Console.WriteLine(NewFunction.AFunction(i));
}
catch {
    Console.WriteLine("Threw and exception!");
}
}
