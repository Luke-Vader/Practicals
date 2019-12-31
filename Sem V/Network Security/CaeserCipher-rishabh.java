import java.util.Scanner;

public class CeaserCipher {
	
	public static void main(String[] args) {
		System.out.println("Caeser Cipher\nEnter a String to be encoded: ");
		Scanner sc = new Scanner(System.in);
		String string = sc.nextLine();
		if (string != null) {
			System.out.println("1. Ceaser Cipher" +
					"\n2. Your Cipher" +
					"\nChoose(1-2): ");
		}
		
		int n = sc.nextInt();
		
		System.out.println("Entered String: " + string);
		System.out.println("Encryption: ");
		
		switch(n) {
		case 1: caeser(string);
				break;
				
		case 2: System.out.println("Your Caeser Value: ");
				int caeser = sc.nextInt();
				char max = string.charAt(0);
				for (int i = 0; i < string.length(); i++) {
					if (string.charAt(i) > max) {
						max = string.charAt(i);						
					}
				}
				if (caeser > (127 - max)) {
					System.out.println("ASCII value out of Range");
				} else {
					yourCaeser(string, caeser);
				}
				break;
				
		default: System.out.println("Invalid Input");
		
		}
		sc.close();
	}
	
	private static void caeser(String string) {
		for (int i = 0; i < string.length(); i++) {
			System.out.print((char)(string.charAt(i) + 3));
		}
		System.out.println("\nDecryption: \n" + string);
		
	}
	
	private static void yourCaeser(String string, int x) {
		for (int i = 0; i < string.length(); i++) {
			System.out.print((char)(string.charAt(i) + x));
		}
		System.out.println("\nDecryption: \n" + string);
	}

}
