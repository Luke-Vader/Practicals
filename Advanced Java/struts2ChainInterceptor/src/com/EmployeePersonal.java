package com;

import com.opensymphony.xwork2.ActionSupport;

public class EmployeePersonal extends ActionSupport{
	private String id;
	private String name;
	private String city;
	
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getCity() {
		return city;
	}
	public void setCity(String city) {
		this.city = city;
	}
	
@Override
public String execute() throws Exception {
	return super.execute();
}
}