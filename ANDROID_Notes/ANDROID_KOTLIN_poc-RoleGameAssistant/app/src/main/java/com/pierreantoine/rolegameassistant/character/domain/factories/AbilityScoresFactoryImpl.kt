// File AbilityScoresFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import android.util.Log
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.ability.AbilityScoresDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.ability.AbilityScoresModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factories.AbilityScoresFactory

/**
 *   Class "AbilityScoresFactoryImpl" :
 *   Used to convert AbilityScoresDto into AbilityScoresModel
 *   Used to convert AbilityScoresModel into AbilityScoresDto
 **/
class AbilityScoresFactoryImpl :
    AbilityScoresFactory {

    val TAG = this.javaClass.name

    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: AbilityScoresDto?): AbilityScoresModel? {
        Log.i(TAG, "toDomain")
        return AbilityScoresModel(
            id= dto?.id

        )
    }

    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: AbilityScoresModel?): AbilityScoresDto? {
        return AbilityScoresDto(
            id = domainModel?.id
        )
    }

}