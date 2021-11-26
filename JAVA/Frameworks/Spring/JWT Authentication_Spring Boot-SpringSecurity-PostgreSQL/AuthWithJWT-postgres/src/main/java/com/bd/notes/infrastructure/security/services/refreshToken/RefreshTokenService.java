package com.bd.notes.infrastructure.security.services.refreshToken;

import java.util.Optional;

import com.bd.notes.domain.aggregates.token.RefreshToken;

public interface RefreshTokenService {

	Optional<RefreshToken> findByToken(String token);

	RefreshToken createRefreshToken(Long userId);

	RefreshToken verifyExpiration(RefreshToken token);

	int deleteByUserId(Long userId);

}