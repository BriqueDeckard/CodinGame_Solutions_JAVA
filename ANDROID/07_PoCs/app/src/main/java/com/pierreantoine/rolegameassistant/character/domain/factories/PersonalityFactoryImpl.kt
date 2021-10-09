// File PersonalityFactoryImpl.kt
// @Author pierre.antoine - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.PersonalityDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.PersonalityModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.PersonalityFactory

/**
 *   Class "PersonalityFactoryImpl" :
 *   Used to convert Personality dtos into domain model and domain model into dtos.
 **/
class PersonalityFactoryImpl : PersonalityFactory {
    /**
     * Converts a dto into a domain model
     */
    override fun toDomain(dto: PersonalityDto?): PersonalityModel? {
        return PersonalityModel(
            id = dto?.id,
            personality = dto?.personality
        )
    }

    /**
     * Converts a domain model into a dto.
     */
    override fun toDto(domainModel: PersonalityModel?): PersonalityDto? {
        return PersonalityDto(
            id = domainModel?.id,
            personality = domainModel?.personality)
    }
}