// File RaceFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.RaceDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.RaceModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.RaceFactory

/**
 *   Class "RaceFactoryImpl" :
 *   Used to convert Race dtos into domain model and domain model into dtos.
 **/
class RaceFactoryImpl :
    RaceFactory {
    /** Converts dto into domain model  **/
    override fun toDomain(dto: RaceDto?): RaceModel? {
        return RaceModel(
            id = null,
            name = dto?.name
        )
    }
    /** Converts domain model into dto  **/
    override fun toDto(domainModel: RaceModel?): RaceDto? {
        return RaceDto(
            id = null,
            name = domainModel?.name
        )
    }
}