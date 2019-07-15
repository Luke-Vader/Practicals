//Practical 5 on RSA algorithm btw it doesn't work for larger plaintext

import java.util.Random;
import java.util.Scanner;
import java.math.BigInteger;

public class RSA {
	
	public static void main(String[] args) {
		BigInteger p;
		BigInteger q;
		BigInteger n;
		BigInteger tot;
		BigInteger e;
		BigInteger d;
		BigInteger ct;
		BigInteger pt,pt1;
		Random r;
		
		r = new Random();
		Scanner sc = new Scanner(System.in);
		System.out.println("Plain Text: ");
		pt = sc.nextBigInteger();
		p = BigInteger.probablePrime(8, r);
		q = BigInteger.probablePrime(8, r);
		n = p.multiply(q);
		System.out.println(n);
		tot = (p.subtract(BigInteger.ONE)).multiply(q.subtract(BigInteger.ONE));
		System.out.println("tot: " + tot);
		e = BigInteger.probablePrime(6, r);
		System.out.println(e);
		while (e.gcd(tot).compareTo(BigInteger.ONE) > 0) {
			e = BigInteger.probablePrime(4, r);
			System.out.println("adf");
		}
		
		System.out.println("E:" + e);
		d = e.modInverse(tot);
		System.out.println("D:" + d);
		ct = pt.modPow(e,n);
		System.out.println("Ciphered: " + ct);
		pt1 = ct.modPow(d,n);
		System.out.println("Decrypted: " + pt1);
		
		
		
	}

}
