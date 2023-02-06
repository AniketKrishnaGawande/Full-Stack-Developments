package com.app.UserRepository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import com.app.pojos.Employee;

public interface AdminDao extends JpaRepository<Employee, Integer> {

	@Query(value = "select e from Employee e where e.role='USER'")
	public List<Employee> getEmp();

}
