package com.app.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.app.dto.LoginDto;
import com.app.dto.UserDto;
import com.app.pojos.User;
import com.app.services.UserService;

@RestController
@RequestMapping("/user")
public class UserController {
	@Autowired
	private UserService service;

	@PostMapping("/signUp")
	public User authenticate(@RequestBody UserDto u) {
		User user = new User();
		user.setEmail(u.getEmail());
		user.setPassword(u.getPassword());
		user.setDob(u.getDob());
		user.setRole(u.getRole());
		return service.regiter(user);
	}

	@PostMapping("/login")
	public User login(@RequestBody LoginDto user) {
try {
		User u = service.login(user);
		return u;
}catch (Exception e) {
System.out.println("error in controller");
}
return null;
	}
}
