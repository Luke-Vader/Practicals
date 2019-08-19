import java.io.*;
import java.net.Socket;

public class Client {
	
	public static void main(String[] args) {

        try {
        	System.out.println("Enter a Number: ");
            BufferedReader userInput = new BufferedReader(new InputStreamReader(System.in));
            String userNumber = userInput.readLine();
        	Socket socket = new Socket("localhost",2080);
            BufferedReader serverInput = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter printWriter = new PrintWriter(new OutputStreamWriter(socket.getOutputStream()));
            printWriter.println(userInput);
            printWriter.flush();
            String out = serverInput.readLine();
            System.out.println(out);
                    
        } catch (Exception e) {
            e.printStackTrace();

        }
	}

}
