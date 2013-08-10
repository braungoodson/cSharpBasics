using System;
using System.Threading;
using System.Threading.Tasks;

/*
	-- Because a call is not awaited, execution of the current
	   method continues before the call is completed.
	-- Apply the `await` operator to a result of the call or variable.

	e.g.,

		- Call an asynchronous method.
		- Call another method.
		- Wait for the value of `i`.
		
		public async Task<int> method1 () {
			Task<int> i = this.work1();
			this.doSomeOtherWork();
			int j = await i;
			return 1;
		}
*/

public class unit1 {
	public async Task<int> work1 () {
		// Wait for this anonymous function to return.
		return await Task.Run(() => {
			for (int i = 0; i <= 10; ++i) {
				Thread.Sleep(200);
				Console.WriteLine("unit1.work1(): " + i);
			}
			return 0;
		});
	}
	public async Task<int> work2 () {
		// Wait for this anonymous function to return.
		return await Task.Run(() => {
			for (int i = 0; i <= 10; ++i) {
				Thread.Sleep(200);
				Console.WriteLine("unit1.work2(): " + i);
			}
			return 0;
		});
	}
	public void init () {
		// Since `this.method1();` is asynchronous, execution returns immediately
		this.work1();
		// And therefore, `this.method2();` is called.
		this.work2().Wait();
	}
}

public class awaitAsync {
	public static void Main () {
		unit1 u = new unit1();
		u.init();
	}
}

// For access to the C# Compiler `csc` from remote telnet shell.
// %comspec% /k ""C:\Program Files\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"" x86