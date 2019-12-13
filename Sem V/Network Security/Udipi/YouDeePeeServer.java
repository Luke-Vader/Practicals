import java.net.*;
import java.io.*;

public class YouDeePeeServer {

	public static void main(String[] args) {
		try{ 
			DatagramSocket datagramSocket = new DatagramSocket(2000);
			System.out.println("Pratik Working");
			byte b[] = new byte[1024];
			
			DatagramPacket dp = new DatagramPacket(b,b.length);
			datagramSocket.receive(dp);
			String input = new String(dp.getData(),0,dp.getLength());
			StringBuffer sb = new StringBuffer(input);
			String opString = sb.reverse().toString();
			byte b1[] = new byte[1024];
			b1 = opString.getBytes();
			DatagramPacket dp1 = new DatagramPacket(b1,b1.length,InetAddress.getLocalHost(),1000);
			datagramSocket.send(dp1);			
			
		} catch(Exception e) {
			e.printStackTrace();
			System.out.println("Pratik Threw Up");
		}
	}

}
