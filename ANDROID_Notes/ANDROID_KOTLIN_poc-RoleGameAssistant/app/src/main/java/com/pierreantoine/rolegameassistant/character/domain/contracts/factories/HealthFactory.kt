// File HealthFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.HealthDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.HealthModel

/**
 *   Interface "HealthFactory" :
 *   Converts dto to domain model.
 *   Converts domain model to dto.
 **/
interface HealthFactory : Factory<HealthDto, HealthModel> {
    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: HealthDto?): HealthModel?
    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: HealthModel?): HealthDto?
}