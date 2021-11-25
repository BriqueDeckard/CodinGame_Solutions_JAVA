package com.bd.notes.infrastructure.security.services.signup;

import com.bd.notes.domain.aggregates.payload.request.signup.SignupRequestDTO;
import com.bd.notes.infrastructure.security.exception.EmailExistsException;
import com.bd.notes.infrastructure.security.exception.UsernameExistsException;

public interface SignupService {

	void saveUser(SignupRequestDTO dto) throws EmailExistsException, UsernameExistsException;

}