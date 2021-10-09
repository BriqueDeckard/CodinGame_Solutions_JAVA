// File BasiInfoFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.BasicInfoDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.BasicInfoModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.BasicInfoFactory
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.ClassFactory
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.RaceFactory

/**
 *   Class "BasiInfoFactoryImpl" :
 *   Class used to convert basic info dtos into basic info domain model.
 **/
class BasicInfoFactoryImpl(
    /** Factory for race dtos   **/
    val raceFactory: RaceFactory?,
    /** Factory for class dtos  **/
    val classFactory: ClassFactory?
) :
    BasicInfoFactory {
    /** Converts a dto into a domain model  **/
    override fun toDomain(dto: BasicInfoDto?): BasicInfoModel? {
        return BasicInfoModel(
            id = dto?.id,
            experience = dto?.experience,
            level = dto?.level,
            race = raceFactory?.toDomain(dto?.race),
            name = dto?.name,
            classModel = classFactory?.toDomain(dto?.classDto)
        )
    }

    /** Converts a domain model into a dto  **/
    override fun toDto(domainModel: BasicInfoModel?): BasicInfoDto? {
        return BasicInfoDto(
            id = null,
            name = domainModel?.name,
            race = raceFactory?.toDto(domainModel?.race),
            level = domainModel?.level,
            experience = domainModel?.experience,
            classDto = classFactory?.toDto(domainModel?.classModel)
        )
    }
}