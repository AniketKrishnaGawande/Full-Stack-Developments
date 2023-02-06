package com.app.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.app.service.AdminService;
import com.fasterxml.jackson.annotation.JsonCreator.Mode;

@Controller
@RequestMapping("/admin")
public class AdminController {
	@Autowired
	private AdminService adminserv;

	@GetMapping("/home")
	public String custHome() {

		return "/admin/home";

	}

	@GetMapping("/emps")
	public String showAllEmp(Model map) {
		map.addAttribute("emps", adminserv.allEmps());
		return "/admin/EmpList";
	}

}
