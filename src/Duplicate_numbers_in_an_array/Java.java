package mohammed;

/*
 *	In this class i will present a basic way to print
 * 	any duplicate value in an array only ONCE.
 * */

public class Homework {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		/*
		* Elements of the array could be defined by any mean
		* For simplicity, i declared & initialized the array hardcoded.
		 * -------------------------------------------------------------*/
		int[] arr = {2,2,2,4,6,6,9,10,10,11};


		printNonDuplicateValues(arr);  // Call the method to print non-duplicate values

	}


	/*
	 * Purpose: 	To Print non-duplicate values
	 * Parameters: 	int[], array of type int
	 * BigO(n): 	BigO(N*N).
	 * -------------------------------------------------------------*/
	public static void printNonDuplicateValues(int[] arr){

		for(int i = 0; i < arr.length; i++){
			boolean isNonDuplicate = true;		// reset to True;

			for(int j = i+1;  j < arr.length; j++){
				if (arr[i] == arr[j])
					 isNonDuplicate = false;
			}

			if (isNonDuplicate)
				System.out.printf("%d ", arr[i]);

		}

	}

}
