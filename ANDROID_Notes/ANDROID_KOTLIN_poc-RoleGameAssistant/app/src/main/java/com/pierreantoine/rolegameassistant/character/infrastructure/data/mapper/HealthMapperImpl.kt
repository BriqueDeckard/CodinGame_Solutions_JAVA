// File HealthMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBHealth
import com.pierreantoine.rolegameassistant.character.domain.aggregate.HealthModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.HealthMapper

/**
 *   Class "HealthMapperImpl" :
 *   TODO: Fill class use.
 **/
class HealthMapperImpl : HealthMapper {

    override fun map(health: HealthModel?): DBHealth? {
        return DBHealth(
            dbHealth_id = health?.id,
            dbHealth_hpMod = health?.hpMod,
            dbHealth_useMax = health?.useMax,
            dbHealth_maxHealth = health?.maxHealth
        )
    }
}