package com.app.repositories;

import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.app.pojos.User;

@Repository
public interface UserRepo extends JpaRepository<User, Integer>{

	public Optional<User> findByEmailAndPassword(String email, String password); 
}
