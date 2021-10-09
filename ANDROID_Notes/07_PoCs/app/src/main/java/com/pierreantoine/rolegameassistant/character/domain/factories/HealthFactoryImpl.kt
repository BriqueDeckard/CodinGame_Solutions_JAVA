// File HealthFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.HealthDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.HealthModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.HealthFactory

/**
 *   Class "HealthFactoryImpl" :
 *   Used to convert Health dtos into domain model and domain model into dtos.
 **/
class HealthFactoryImpl :
    HealthFactory {
    /** Converts a dto into a domain model  **/
    override fun toDomain(dto: HealthDto?): HealthModel? {
        return HealthModel(
            id = dto?.id,
            hpMod = dto?.hpMod,
            maxHealth = dto?.maxHealth,
            useMax = dto?.useMax
        )
    }

    /** Converts a domain model into a dto  **/
    override fun toDto(domainModel: HealthModel?): HealthDto? {
        return HealthDto(
            id = domainModel?.id,
            useMax = domainModel?.useMax,
            maxHealth = domainModel?.maxHealth,
            hpMod = domainModel?.hpMod
        )
    }
}