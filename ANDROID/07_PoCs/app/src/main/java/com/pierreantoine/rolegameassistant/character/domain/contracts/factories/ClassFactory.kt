// File ClassFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.ClassDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.ClassModel

/**
 *   Interface "ClassFactory" :
 *   Converts dto to domain model.
 *   Converts domain model to dto.
 **/
interface ClassFactory : Factory<ClassDto, ClassModel> {

    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: ClassDto?): ClassModel?
    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: ClassModel?): ClassDto?
}