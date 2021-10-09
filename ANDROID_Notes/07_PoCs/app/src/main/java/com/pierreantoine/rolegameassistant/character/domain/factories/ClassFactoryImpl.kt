// File ClassFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.ClassDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.ClassModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.ClassFactory

/**
 *   Class "ClassFactoryImpl" :
 *   Used to convert Class dtos into domain model and domain model into dtos.
 **/
class ClassFactoryImpl :
    ClassFactory {
    /** Converts dto to domain model **/
    override fun toDomain(dto: ClassDto?): ClassModel? {
        return ClassModel(
            id = dto?.id,
            name = dto?.name
        )
    }

    /** Converts domain model into dto  **/
    override fun toDto(domainModel: ClassModel?): ClassDto? {
        return ClassDto(
            id = domainModel?.id,
            name = domainModel?.name
        )
    }
}