// File BackgroundFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.BackgroundDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BackgroundModel

/**
 *   Interface "BackgroundFactory" :
 *   Used to convert background dto into background domain model
 *   and to convert background domain model into dto.
 **/
interface BackgroundFactory
    : Factory<BackgroundDto, BackgroundModel> {
    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: BackgroundDto?): BackgroundModel?
    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: BackgroundModel?): BackgroundDto?

}