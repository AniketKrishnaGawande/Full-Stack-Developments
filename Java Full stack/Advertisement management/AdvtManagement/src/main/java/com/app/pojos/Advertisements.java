package com.app.pojos;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.ManyToOne;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.ToString;

@Entity
@Getter
@Setter
@ToString(exclude = "user")
public class Advertisements extends BaseId {
	@Column(length = 20)
	private String product;
	@Column(length = 20)
	private String category;
	@Enumerated(EnumType.STRING)
	private Status status;
	@ManyToOne
	private User user;

}
