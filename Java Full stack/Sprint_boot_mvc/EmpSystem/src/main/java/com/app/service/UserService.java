package com.app.service;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.app.UserRepository.UserDao;
import com.app.pojos.Employee;

@Service
public class UserService {
	@Autowired
	private UserDao userDao;

	public Employee registerUser(Employee emp) {
		return userDao.save(emp);
	}

	public Employee userAuthenticate(String email, String pass) {
		return userDao.findByEmailAndPassword(email, pass);

	}

}
