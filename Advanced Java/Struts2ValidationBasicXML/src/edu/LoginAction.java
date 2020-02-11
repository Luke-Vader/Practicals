package edu;
import com.opensymphony.xwork2.ActionSupport;
/*
 The following regex will do:

^\+?[0-9\-]+\*?$

Logic:

Beginning of string: ^
Optional + character, escaped because "+" could also be a regex operator: \+?
At least one character which is either 0-9 or "-", escaped because "-" 
could also be a regex operator: [0-9\-]+
Optional "*" character, escaped: \*?
End of string: `$'
 */

public class LoginAction extends ActionSupport {
	private String email;
	private String password;
	private String phone;
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getPassword() {
		return password;
	}
	
	public String execute()
	{
		if(password.equals("welcome"))
		{
			return SUCCESS;
		}
		return INPUT;
		
	}
	public void setPassword(String password) {
		this.password = password;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}

}
