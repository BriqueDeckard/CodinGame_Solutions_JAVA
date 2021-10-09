// File BackgroundMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBackground
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BackgroundModel

/**
 *   Interface "BackgroundMapper" :
 *   TODO: Fill interface use.
 **/
interface BackgroundMapper {
    fun map(background: BackgroundModel?): DBBackground?
// TODO : Fill interface.
}