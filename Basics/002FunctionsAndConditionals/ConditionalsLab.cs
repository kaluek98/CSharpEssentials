using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.CheckPassword("SevenOF9");
		myOperator.CheckPassword("OU812");
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first greater.");
		} else {
			Console.WriteLine("False, the second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}
}

using System;
					
public class Program
{
	public void Main()
	{ 
		Console.WriteLine("Lets see what you got! Hmmm. " );
		carl(2);
			
	}
	
	public void carl(int value){ 
		if(value == 4){
		 Console.WriteLine("You got 4!" );
	 }else {
		 Console.WriteLine("Sorry, no four." );
	}
}
}
	
using System;
					
public class Program
{
	public test myTest;
	public void Main()
	{ 
		myTest = new test();
		Console.WriteLine("Lets see what you got! Hmmm. " );
		myTest.carl(2);
			
}
}

public class test{

		public void carl(int value){ 
		if(value == 4){
		 Console.WriteLine("You got 4!" );
	 }else {
		 Console.WriteLine("Sorry, no four." );
	}
}
}

using System;
					
public class Program
{
	public test myTest;
	public void Main()
	{ 
	
		myTest = new test();
		Console.WriteLine("Lets see what you got! Hmmm. " );
		myTest.carl(4);
		
			
			
}
}

public class test{

		public void carl(int value){ 
		int sam = 1;
			string result = (sam > value) ? "Sam is beating you!" : "You're beating Sam!";
			Console.WriteLine(result);
		if(value == 4){
		 Console.WriteLine("You got 4 points!" );

	}
}
}
