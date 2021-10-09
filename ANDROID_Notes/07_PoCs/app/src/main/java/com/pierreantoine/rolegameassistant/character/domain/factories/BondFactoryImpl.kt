// File BondFactoryImpl.kt
// @Author pierre.antoine - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.BondDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BondModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.BondFactory

/**
 *   Class "BondFactoryImpl" :
 *   Used to converts dto into domain model and domain model into dto.
 **/
class BondFactoryImpl : BondFactory {
    /**
     * Converts a dto into a domain model
     */
    override fun toDomain(dto: BondDto?): BondModel? {
        return BondModel(
            id = dto?.id,
            bond = dto?.bond
        )
    }

    /**
     * Converts a domain model into a dto.
     */
    override fun toDto(domainModel: BondModel?): BondDto? {
        return BondDto(
            id = domainModel?.id,
            bond = domainModel?.bond
        )
    }
}