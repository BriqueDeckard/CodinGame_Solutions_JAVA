// File CharacteristicsFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacteristicsDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacteristicsModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.CharacteristicsFactory

/**
 *   Class "CharacteristicsFactoryImpl" :
 *   Used to convert Characteristics dtos into domain model and domain model into dtos.
 **/
class CharacteristicsFactoryImpl :
    CharacteristicsFactory {
    /** Converts a dto into a domain model **/
    override fun toDomain(dto: CharacteristicsDto?): CharacteristicsModel? {
        return CharacteristicsModel(
            id = dto?.id,
            weight = dto?.weight,
            height = dto?.height,
            gender = dto?.gender,
            age = dto?.age
        )
    }
    /** Converts a domain model into a dto  **/
    override fun toDto(domainModel: CharacteristicsModel?): CharacteristicsDto? {
        return CharacteristicsDto(
            id = domainModel?.id,
            weight = domainModel?.weight,
            age = domainModel?.age,
            gender = domainModel?.gender,
            height = domainModel?.height


        )

    }
}