package com.app.pojos;

import javax.persistence.*;

import lombok.*;

@Getter
@Setter
@NoArgsConstructor
@ToString
@Entity
@Table(name = "Employees")
@AllArgsConstructor
public class Employee extends BaseClass {
	private String fName;
	private String lName;
	private String email;
	private String password;
	@Enumerated(EnumType.STRING)
	private Role role;

}
