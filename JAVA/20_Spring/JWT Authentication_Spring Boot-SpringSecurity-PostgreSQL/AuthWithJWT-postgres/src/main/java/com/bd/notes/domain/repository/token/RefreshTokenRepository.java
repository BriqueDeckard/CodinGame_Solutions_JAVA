package com.bd.notes.domain.repository.token;

import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;

import com.bd.notes.domain.aggregates.token.RefreshToken;
import com.bd.notes.domain.aggregates.user.User;

public interface RefreshTokenRepository extends JpaRepository<RefreshToken, Long> {
	@Override
	Optional<RefreshToken> findById(Long id);

	Optional<RefreshToken> findByToken(String token);
	
	int deleteByUser(User user);

}
