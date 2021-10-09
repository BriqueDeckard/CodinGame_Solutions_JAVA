// File HealthMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBHealth
import com.pierreantoine.rolegameassistant.character.domain.aggregate.HealthModel

/**
 *   Interface "HealthMapper" :
 *   TODO: Fill interface use.
 **/
interface HealthMapper {
    fun map(health:HealthModel?): DBHealth?
// TODO : Fill interface.
}