import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {

	public static void main(String[] args) {

        try {
        	ServerSocket serverSocket = new ServerSocket(2080);
            Socket socket = serverSocket.accept();
            BufferedReader br = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter pw = new PrintWriter(new OutputStreamWriter(socket.getOutputStream()));
            String number = br.readLine();
            //String output = number + " from Server";
            int output = Integer.parseInt(number);
            pw.print(output);
            pw.flush(); 
            
        } catch(Exception e) {
        	e.printStackTrace();
        	System.out.println("Connection Failed");
        	
        }

	}

}
