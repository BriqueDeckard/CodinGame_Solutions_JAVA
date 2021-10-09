// File IdealFactoryImpl.kt
// @Author pierre.antoine - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.IdealDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.IdealModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.IdealFactory

/**
 *   Class "IdealFactoryImpl" :
 *   Used to convert Ideal dtos into domain model and
 *   domain model into dtos.
 **/
class IdealFactoryImpl : IdealFactory {
    /**
     * Converts a dto into a domain model
     */
    override fun toDomain(dto: IdealDto?): IdealModel? {
        return IdealModel(
            id = dto?.id,
            ideal = dto?.ideal
        )
    }

    /**
     * Converts a domain model into a dto.
     */
    override fun toDto(domainModel: IdealModel?): IdealDto? {
        return IdealDto(
            id = domainModel?.id,
            ideal = domainModel?.ideal
        )
    }
}