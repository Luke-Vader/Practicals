

import java.io.*;
import java.net.*;
public class Client {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {
			Socket s=new Socket("localhost",4500);
			System.out.println("Connected");
			
			
			
			BufferedReader sinput= new BufferedReader(new InputStreamReader(s.getInputStream()));
			PrintWriter pw = new PrintWriter(new OutputStreamWriter(s.getOutputStream()));
			
			BufferedReader uinput= new BufferedReader(new InputStreamReader(System.in));

			System.out.println("Enter 2 num for Max ");
			 String num =uinput.readLine();
			 String num2=uinput.readLine();		 
			
			 pw.println(num);
			 pw.println(num2);
			 pw.flush();
			 String op=sinput.readLine();
			 System.out.println(op);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
