// File CharacteristicsFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacteristicsDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacteristicsModel

/**
 *   Interface "CharacteristicsFactory" :
 *   Converts dto to domain model.
 *   Converts domain model to dto.
 **/
interface CharacteristicsFactory
    : Factory<CharacteristicsDto, CharacteristicsModel> {

    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: CharacteristicsDto?): CharacteristicsModel?

    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: CharacteristicsModel?): CharacteristicsDto?
}