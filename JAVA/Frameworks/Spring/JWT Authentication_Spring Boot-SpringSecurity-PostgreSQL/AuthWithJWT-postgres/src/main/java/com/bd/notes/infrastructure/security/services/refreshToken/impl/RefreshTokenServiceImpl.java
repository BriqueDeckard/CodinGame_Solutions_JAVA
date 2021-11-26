package com.bd.notes.infrastructure.security.services.refreshToken.impl;

import java.time.Instant;
import java.util.Optional;
import java.util.UUID;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Service;

import com.bd.notes.domain.aggregates.token.RefreshToken;
import com.bd.notes.infrastructure.data.dao.RefreshTokenDao;
import com.bd.notes.infrastructure.data.dao.UserDao;
import com.bd.notes.infrastructure.security.exception.TokenRefreshException;
import com.bd.notes.infrastructure.security.services.refreshToken.RefreshTokenService;

@Service
public class RefreshTokenServiceImpl implements RefreshTokenService {
	@Value("${com.bd.notes.jwtRefreshExpirationMs}")
	private Long refreshTokenDurationMs;

	@Autowired
	private RefreshTokenDao refreshTokenRepository;

	@Autowired
	private UserDao userRepository;

	@Override
	public Optional<RefreshToken> findByToken(String token) {
		return refreshTokenRepository.findByToken(token);
	}

	@Override
	public RefreshToken createRefreshToken(Long userId) {
		RefreshToken refreshToken = new RefreshToken();

		refreshToken.setUser(userRepository.findById(userId).get());
		refreshToken.setExpiryDate(Instant.now().plusMillis(refreshTokenDurationMs));
		refreshToken.setToken(UUID.randomUUID().toString());

		refreshToken = refreshTokenRepository.save(refreshToken);
		return refreshToken;
	}

	@Override
	public RefreshToken verifyExpiration(RefreshToken token) {
		if (token.getExpiryDate().compareTo(Instant.now()) < 0) {
			refreshTokenRepository.delete(token);
			throw new TokenRefreshException(token.getToken(),
					"Refresh token was expired. Please make a new signin request.");
		}
		return token;
	}

	@Override
	@Transactional
	public int deleteByUserId(Long userId) {
		return refreshTokenRepository.deleteByUser(userRepository.findById(userId).get());
	}

}
