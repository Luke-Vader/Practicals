import java.util.Scanner;

public class ColumnTransposition {

	public static void main(String[] args) {
		
		String message;
		String encrypted = "";
		String decrypted = ""; 
		boolean flag = false;
		int r;
		int c;
		int k = 0;
		
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter the Message: ");
		message = sc.nextLine();
		System.out.println("Enter Number of Rows: ");
		r = sc.nextInt();
		System.out.println("Enter Number of Columns: ");
		c = sc.nextInt();
		
		char arr[][] = new char[r][c];
		int key[] = new int[c];
		
	
		while (!flag) {
			if (message.length() > r*c) {
				System.out.println("String and Matrix have different sizes");
				System.out.println("Matrix size is " + r*c + " Enter appropriate string: ");
				message = sc.nextLine();
				
			} else {
				System.out.println("Good Job");
				flag = true;
				
			}
		}
		if (flag) {
			
			for (int i = 0; i < r; i++) {
				System.out.println("");
				for (int j = 0; j < c; j++) {
					arr[i][j] = '_';
				}
			}
			
			for (int i = 0; i < r; i++) {
				for (int j = 0; j < c; j++) {
					if (k < message.length()) {
						arr[i][j] = message.charAt(k);
						k++;
					}
				}
			}
			
			for (int i = 0; i < r; i++) {
				System.out.println("");
				for (int j = 0; j < c; j++) {
					System.out.print(arr[i][j]);
				}
			}
		}
		
		System.out.println("\nEncryption Boii: ");
		
		for (int i = 0; i < c; i++) {
			k = sc.nextInt();
			key[i] = k;
			for (int j = 0; j < r; j++) {
				encrypted += arr[j][k-1];
				
			}
		}
		
		System.out.println("Encrypted: " + encrypted);
		System.out.println("Key: ");
		for (int i = 0; i < key.length; i++) {
			System.out.print(key[i]);
		}
		
		for (int i = 0; i < c; i++) {
			
			for (int j = 0; j < r; j++) {
				decrypted += encrypted.charAt(arg0);
				
			}
			
		}
		
	}

}
