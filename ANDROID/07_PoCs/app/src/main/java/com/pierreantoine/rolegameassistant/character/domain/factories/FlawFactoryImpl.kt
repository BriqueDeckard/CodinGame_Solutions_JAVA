// File FlawFactoryImpl.kt
// @Author pierre.antoine - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.FlawDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.FlawModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.FlawFactory

/**
 *   Class "FlawFactoryImpl" :
 *   Used to converts flaw dtos into domain model and domain model into dtos.
 **/
class FlawFactoryImpl : FlawFactory {
    /**
     * Converts a dto into a domain model
     */
    override fun toDomain(dto: FlawDto?): FlawModel? {
        return FlawModel(
            id = dto?.id,
            flaw = dto?.flaw
        )
    }

    /**
     * Converts a domain model into a dto.
     */
    override fun toDto(domainModel: FlawModel?): FlawDto? {
        return FlawDto(
            id = domainModel?.id,
            flaw = domainModel?.flaw
        )
    }
}