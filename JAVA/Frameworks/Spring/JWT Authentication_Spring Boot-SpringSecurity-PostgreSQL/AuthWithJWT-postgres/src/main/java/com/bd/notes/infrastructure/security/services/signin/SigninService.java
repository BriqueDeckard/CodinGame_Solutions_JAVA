package com.bd.notes.infrastructure.security.services.signin;

import com.bd.notes.domain.aggregates.payload.request.login.LoginRequestDTO;
import com.bd.notes.domain.aggregates.payload.response.jwt.JwtResponse1;

public interface SigninService {

	JwtResponse1 authenticateUser(LoginRequestDTO dto);

}