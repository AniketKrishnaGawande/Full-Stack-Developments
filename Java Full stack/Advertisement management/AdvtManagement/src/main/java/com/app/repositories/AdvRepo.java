package com.app.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import com.app.pojos.Advertisements;

public interface AdvRepo extends JpaRepository<Advertisements, Integer>{

}
