// File DBAbilityScores.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.ABILITY_SCORES_TABLE_NAME

/**
 *   Class "DBAbilityScores" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = ABILITY_SCORES_TABLE_NAME)
class DBAbilityScores(
    @PrimaryKey(autoGenerate = true)
    var dbAbilityScores_id:Int?
) {

// TODO : Fill class.
}