package com.app.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class IndexPageController {

	@RequestMapping("/")
	public String indexPage() {
		System.out.println("inside indexpage method of " + getClass().getName());

		return "/index";
	}

}
