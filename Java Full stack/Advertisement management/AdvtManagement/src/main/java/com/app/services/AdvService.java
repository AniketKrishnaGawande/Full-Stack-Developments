package com.app.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.app.dto.AdvDto;
import com.app.pojos.Advertisements;
import com.app.pojos.Status;
import com.app.pojos.User;
import com.app.repositories.AdvRepo;
import com.app.repositories.UserRepo;

@Service
public class AdvService {

	@Autowired
	private AdvRepo repo;
	@Autowired
	private UserService service;

	public List<Advertisements> getAll() {
		List<Advertisements> list = repo.findAll();
		return list;
	}

	public Advertisements addAdv(AdvDto adv) {

		User u = service.getById(adv.getUserId());
		System.out.println(u);

		Advertisements newAdv = new Advertisements();
		newAdv.setProduct(adv.getProduct());
		newAdv.setCategory(adv.getCategory());
		newAdv.setStatus(Status.valueOf("PENDING"));
		u.addList(newAdv);
		return repo.save(newAdv);

	}
}
