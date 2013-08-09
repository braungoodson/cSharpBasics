using System;

// Llambda expressions are just anonymous functions.
// a.k.a., inline statement or expression
// target .NET 3.5 >
// a delegate can be initialized with a llambda expression

// Our delegates
public delegate void myDelegate ();
public delegate int myDelegate1 (int i);

// Class holder to execute whatever we want.
public class unitClass {
	// Initialize a delegate with a llambda statement
	public void initializeDelegateWithLlambdaStatement () {
		myDelegate d = () => {
			Console.WriteLine("Body of a llambda statement.");
		};
		d();
	}
	// Initialize a delegate with a llambda expression
	public void initializeDelegateWithLlambdaExpression () {
		myDelegate1 d = i => i;
		Console.WriteLine(d(1));
	}
	// Main
	public void init () {
		initializeDelegateWithLlambdaStatement();
		initializeDelegateWithLlambdaExpression();
	}
}

// Main class
public class delegatesTutorial {
	public static void Main () {
		unitClass c = new unitClass();
		c.init();
	}
}