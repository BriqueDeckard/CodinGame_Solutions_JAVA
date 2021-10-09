// File BasicInfoFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.BasicInfoDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.BasicInfoModel

/**
 *   Interface "BasicInfoFactory" :
 *   Converts a dto into a domain model.
 *   Converts a domain model into a dto.
  **/
interface BasicInfoFactory
    : Factory<BasicInfoDto, BasicInfoModel> {

    /**
     * Converts a dto into a domain model.
     */
    override fun toDomain(dto: BasicInfoDto?): BasicInfoModel?

    /**
     * Converts a domain model into a dto.
     */
    override fun toDto(domainModel: BasicInfoModel?): BasicInfoDto?
}