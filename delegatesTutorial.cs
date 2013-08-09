using System;

// C# Delegates are a type that defines a signature.
// They safely encapsulate a method.
// Object-oriented, type-safe, and secure.
// When you instantiate a delegate, you can associate its instance
//  with any method that matches its signature.
// They allow methods to be passed as parameters.
// To define callbacks.
public delegate void myDelegate ();

// A class
public class myClass {
	// A method that matches the signature of the delegate.
	public void myMethod () {
		Console.WriteLine("This is the body of `myMethod()`;");
	}
	// A method that matches the signature of the delegate.
	public void myMethod2 () {
		Console.WriteLine("This is the body of `myMethod2()`;");
	}
	// A method that uses a delegate as a callback.
	public void myMethod1 (myDelegate d) {
		d();
	}
}

// Class holder to execute whatever we want.
public class unitClass {
	// Basic delegate instantiation and call.
	public void instantiateDelegate () {
		myClass c = new myClass();
		myDelegate d = c.myMethod;
		d();
	}
	// Pass a delegate as a callback.
	public void withCallback () {
		myDelegate d;
		myClass c = new myClass();
		d = c.myMethod;
		c.myMethod1(d);
	}
	// Delegate multicasting
	public void delegateMulticasting () {
		myDelegate d1, d2, d3;
		myClass c = new myClass();
		d1 = c.myMethod;
		d2 = c.myMethod2;
		d3 = d1 + d2;
		d3();
	}
	// Main
	public void init () {
		instantiateDelegate();
		withCallback();
		delegateMulticasting();
	}
}

// Main class
public class delegatesTutorial {
	public static void Main () {
		unitClass c = new unitClass();
		c.init();
	}
}
