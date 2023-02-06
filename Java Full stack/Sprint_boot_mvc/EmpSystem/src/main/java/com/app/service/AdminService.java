package com.app.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.app.UserRepository.AdminDao;
import com.app.pojos.Employee;

@Service
public class AdminService {

	@Autowired
	private AdminDao adminDao;

	public List<Employee> allEmps() {
		return adminDao.getEmp();
	}

	public Optional<Employee> getEmpById(int id) {
		return adminDao.findById(id);
	}

	public Employee updateEMp(int id, Employee emp) {

		Employee e = adminDao.findById(id).orElseThrow();
		emp.setPassword(e.getPassword());
		emp.setRole(e.getRole());
		return adminDao.save(emp);

	}

	public void deleteEmp(int id) {
		adminDao.deleteById(id);
	}
}
