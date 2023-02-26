package com.app.pojos;

import java.time.LocalDate;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.FetchType;
import javax.persistence.OneToMany;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonInclude.Include;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString(exclude = "list")
@Entity
@JsonInclude(value = Include.NON_EMPTY)
public class User extends BaseId {
	@Column(length = 20, unique = true)
	private String email;
	@Column(length = 20)
	private String password;
	private LocalDate dob;
	@Column(nullable = false)
	@Enumerated(EnumType.STRING)
	private Role role;
	@OneToMany(mappedBy = "user", cascade = CascadeType.ALL,orphanRemoval = true)
	@JsonIgnore
	private List<Advertisements> list;
	public void addList(Advertisements adv) {
		list.add(adv);
		adv.setUser(this);
	}
}
