// File BioFactoryImpl.kt
// @Author pierre.antoine - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.BiographyDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BiographyModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.BioFactory

/**
 *   Class "BioFactoryImpl" :
 *   Class used to convert biography dtos into biography domain model.
**/
class BioFactoryImpl : BioFactory {
    /**
     * Converts a dto into a domain model
     */
    override fun toDomain(dto: BiographyDto?): BiographyModel? {
        return BiographyModel(
            id = dto?.id,
            biography = dto?.biography
        )
    }

    /**
     * Converts a domain model into a dto.
     */
    override fun toDto(domainModel: BiographyModel?): BiographyDto? {
        return BiographyDto(
            id = domainModel?.id,
            biography = domainModel?.biography
        )
    }
}