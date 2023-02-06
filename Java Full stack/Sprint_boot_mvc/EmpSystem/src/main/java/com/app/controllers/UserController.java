package com.app.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.app.pojos.Employee;
import com.app.pojos.Role;
import com.app.service.UserService;

@Controller
@RequestMapping("/user")
public class UserController {

	@Autowired
	private UserService userService;

	@GetMapping("/register")
	public String getRegForm() {

		return "/users/Register";
	}

	@GetMapping("/login")
	public String getloginForm() {

		return "/users/login";
	}

	@PostMapping("/login")
	public String authenticate(RedirectAttributes flash, @RequestParam String email, @RequestParam String pass,
			HttpSession session) {
		try {
			Employee emp = userService.userAuthenticate(email, pass);
			session.setAttribute("dtls", emp);
			System.out.println(emp);
			if (emp.getRole().equals(Role.valueOf("USER"))) {
				System.out.println("usr found");
				return "redirect:/customer/home";
			}
			return "redirect:/admin/home";
		} catch (Exception e) {
			System.out.println("user not found");
			flash.addFlashAttribute("msg", "invalid credentials");
			return "redirect:/";

		}

	}

	@PostMapping("/register")
	public String processRegister(@RequestParam String fname, @RequestParam String lname, @RequestParam String email,
			@RequestParam String pass, RedirectAttributes flash) {

		userService.registerUser(new Employee(fname, lname, email, pass, Role.valueOf("ADMIN")));
		flash.addFlashAttribute("msg", "user registered");
		return "redirect:/";
	}

}
