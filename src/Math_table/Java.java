package mohammed;

/*
 *	In this class i will present a basic way to print
 * 	the result of arithmetic operation.
 * 			+, -, x, /.
 * */

public class MathOperation {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		/*
		* Variables to be used with
		* Mathematical operation
		* ************************/
		int x = 5;
		int y = 3;

		printSubtraction(x, y);
		printAddition(x, y);
		printDivision(x, y);
		printMultiplication(x, y);
		printExponential(x, y);

	}

	private static void printAddition(int x, int y) {
		System.out.println(x + " + " + y + " = " + (x+y));
	}

	private static void printSubtraction(int x, int y) {
		System.out.println(x + " - " + y + " = "+ (x-y));
	}

	private static void printMultiplication(int x, int y) {
		System.out.println(x + " x " + y + " = " + (x*y));
	}

	private static void printDivision(int x, int y) {
		System.out.println(x + " / " + y + " = " + (x/y));
	}

	private static void printExponential(int x, int y) {

		int result = 1;

		for(int i = 0; i < y; i++){
			result *= x;  // --> result = x * x;
		}

		System.out.println(x + "^" + y + " = " + result);
	}

}
