// File RaceFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.RaceDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.RaceModel

/**
 *   Interface "RaceFactory" :
 *   Converts dto to domain model.
 *   Converts domain model to dto.
 **/
interface RaceFactory : Factory<RaceDto, RaceModel> {
    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: RaceDto?): RaceModel?

    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: RaceModel?): RaceDto?
}