package com.app.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.app.pojos.Employee;
import com.app.service.AdminService;

@Controller
@RequestMapping("/customer")
public class CustomerController {

	@Autowired
	private AdminService adService;

	@GetMapping("/home")
	public String custHome(HttpSession session) {
		Employee e = (Employee) session.getAttribute("dtls");
		System.out.println(e.getFName());
		return "/customer/home";
	}

	@GetMapping("/update/{id}")
	public String UpdateEmp(@PathVariable int id, Model map) {
		map.addAttribute("emp", adService.getEmpById(id));
		return "/customer/updateForm";
	}

	@GetMapping("delete")
	public String deleteEmp(@RequestParam int id, RedirectAttributes flash) {

		adService.deleteEmp(id);
		flash.addFlashAttribute("msg", "emp details deleted");
		return "redirect:/admin/emps";
	}

	@PostMapping("/update/{id}")
	public String processUpdation(@PathVariable int id, @ModelAttribute Employee emp, RedirectAttributes flash) {

		adService.updateEMp(id, emp);
		flash.addFlashAttribute("msg", "emp details updated");
		return "redirect:/admin/emps";
	}

}
