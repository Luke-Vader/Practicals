import java.util.Scanner;


public class World {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int r;
		double c;
		String plainText;
		System.out.println("Enter Depth: ");
		r = sc.nextInt();
		System.out.println("Enter Plaintext:");
		plainText = sc.next();
		
		System.out.println("Cipher Text: " + encrypt(plainText, r));
		
		System.out.println("Decrypted Message: " + decrypt(encrypt(plainText, r), r));
		
		/*for (int i = 0; i < r; i++) {
			System.out.println("");
			for (int j = 0; j < c; j++) {
				System.out.print(arr[i][j]);
			}
		}*/
	}
	
	private static String encrypt(String plain, int depth) {
		String cipher = "";
		int k = 0;
		double c;
		c = Math.ceil(((double)plain.length())/depth);
		char arr[][] = new char[depth][(int) c];
		
		for (int i = 0; i < c; i++) {
			for (int j = 0; j < depth; j++) {
				if (k < plain.length()) {
					arr[j][i] = plain.charAt(k);
					k++;
				} else {
					arr[j][i] = '_';
					k++;
				}
			}
		}
		
		for (int i = 0; i < depth; i++) {
			for (int j = 0; j < c; j++) {
				cipher += arr[i][j];
			}			
		}
		
		return cipher;
	}
	
	private static String decrypt(String cipher, int depth) {
		String message = "";
		double c;
		int k = 0;
		c = Math.ceil(((double)cipher.length())/depth);
		char arr[][] = new char[depth][(int) c];
		
		for (int i = 0; i < depth; i++) {
			for (int j = 0; j < c; j++) {
				arr[i][j] = cipher.charAt(k);
				k++;
			}
		}
		
		for (int i = 0; i < c; i++) {
			for (int j = 0; j < depth; j++) {
				if (arr[j][i] != '_') {
					message += arr[j][i];
				}
			}
		}
		
		return message;
		
	}

}

