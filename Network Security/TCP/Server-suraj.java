	import java.net.ServerSocket;
	import java.net.Socket;
	import java.io.BufferedReader;
	import java.io.IOException;
	import java.io.InputStreamReader;
	import java.io.OutputStreamWriter;
	import java.io.PrintWriter;
	
	
	public class TeeCeePeeServer {	
		 static int max(int n ,int m) 
		    { 
			    int maxx;
			    if(n>m){
			    	maxx=n;
			    }
			    else
			    	maxx=m;
		        return maxx;
		    } 
		
		public static void main(String[] args) {
			
			try {
				ServerSocket ss=new ServerSocket(4500);
				System.out.println("Server started!!");	
				System.out.println("waiting for client...");
				Socket s = ss.accept();
				System.out.println("Client accepted");			
				BufferedReader br = new BufferedReader(new InputStreamReader(s.getInputStream()));
				
				PrintWriter pw = new PrintWriter(new OutputStreamWriter(s.getOutputStream()));
				
				 String num = br.readLine();
				 String num2 = br.readLine();
				 
				 int num1 = Integer.parseInt(num);
				 int nm2 = Integer.parseInt(num2);
				 
				 String output = Integer.toString(max(num1,nm2));
				 pw.println(output);
				 pw.flush();
				 
			} catch (IOException e) {
				e.printStackTrace();
			}
			
		}
	
	}
