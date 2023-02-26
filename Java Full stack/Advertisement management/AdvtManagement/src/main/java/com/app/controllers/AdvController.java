package com.app.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.app.dto.AdvDto;
import com.app.pojos.Advertisements;
import com.app.services.AdvService;

@RestController
@RequestMapping("/adv")
public class AdvController {
	@Autowired
	private AdvService service;

	@GetMapping
	public List<Advertisements> getAll() {
		return service.getAll();
	}

	@PostMapping
	public Advertisements insertAdv(@RequestBody AdvDto adv) {
		return service.addAdv(adv);

	}

}
