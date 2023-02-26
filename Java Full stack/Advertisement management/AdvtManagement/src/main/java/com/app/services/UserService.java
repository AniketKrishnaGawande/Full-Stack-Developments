package com.app.services;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.app.dto.LoginDto;
import com.app.pojos.User;
import com.app.repositories.UserRepo;

@Service
@Transactional
public class UserService {

	@Autowired
	private UserRepo repo;

	public User regiter(User u) {
		return repo.save(u);
	}

	public User login(LoginDto user) {
		try {
			User u = repo.findByEmailAndPassword(user.getEmail(), user.getPassword()).orElseThrow();
			return u;
		} catch (Exception e) {
			System.out.println("error in service");
		}
		return null;
	}

	public User getById(int id) {
		User u = repo.findById(id).orElseThrow();
		u.getList().size();
		return u;
	}

}
