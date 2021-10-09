// File CharacterFactory.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacterDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel

/**
 *   Interface "CharacterFactory" :
 **/
interface CharacterFactory
    : Factory<CharacterDto, CharacterModel> {

    /**
     * Converts a dto into a domain model.
     */
    override fun toDomain(dto: CharacterDto?): CharacterModel?

    /**
     * Converts a domain model into a dto.
     */
    override fun toDto(domainModel: CharacterModel?): CharacterDto?
}