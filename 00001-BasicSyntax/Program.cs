namespace _00001_BasicSyntax {
	internal class Program {
		static void Main() {
			const	bool	b8	= false;
				short	i16	= -4;
			const	ushort	u16	= +5;
			const	int	i32	= -6;
				uint	u32	= +7;
				long	i64	= -8;
			const	ulong	u64	= +9;
			const	float	f32	= -4.4f;
			const	double	f64	= +5.5;
				char	c8	= 'C';
				string	str	= "ahmed";
				byte	uB	= 0b01110001;
			const	sbyte	B	= -0b01111111;
				decimal D	= 1.6m;


			// multiple variable declaration
			int x, y, z;

			// cascaded assignment.
			x = y = z = 50;

			// multiple variable declaration and assignment
			int xx = 4, yy = 5, zz = 6;

			// then next line prints "Hello, World!" in the terminal and jumbs to a new line
			Console.WriteLine("Hello, World!");

			/*
			 * the next line will print "I'm learning C#" in the terminal
			 * however the "\n" escape character will be understod to be the mark to jumb into a new line
			 * ass the Console.Write method doesn't terminate the string with a new line like the Console.WriteLine.
			*/
			Console.Write("I'm learning C#\n");

			// this prints the result of adding two numbers.
			Console.WriteLine(f32 + f64);

			// this will write the value "ahmed" stored in the variable str.
			Console.WriteLine(str);

			// this will print the size of the variable in byts.
			Console.WriteLine(sizeof(bool));	// 1
			Console.WriteLine(sizeof(char));	// 2
			Console.WriteLine(sizeof(short));	// 2
			Console.WriteLine(sizeof(int));		// 4 
			Console.WriteLine(sizeof(float));	// 4
			Console.WriteLine(sizeof(long));	// 8
			Console.WriteLine(sizeof(double));      // 8


			Console.Write("Enter your name: ");

			// getting the user input
			string name = Console.ReadLine();


			Console.WriteLine("The name is: " + name);

			// using the math library
			Console.WriteLine(Math.Max(5, 6));

			// testing string interpolation
			string formattedString = $"the value of the variable {{name}} is \"{name}\"";

			Console.WriteLine(formattedString);
			Console.Write("Ahmed");
			Console.Write("\b\bad");
			Console.WriteLine();


			string word = "";
			// trying to raed one word
			while (true)
			{
				char character = (char) Console.Read();
				if (character == '\n') {
					break;
				}
				word += character;
			}

			Console.WriteLine(word);


			for (int i = 0; i < 10; i++) { 
				for (int j = 0; j < 10-i-1; j++) {
					Console.Write(" ");
				}
				for (int j = 0; j < 1+i*2; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}