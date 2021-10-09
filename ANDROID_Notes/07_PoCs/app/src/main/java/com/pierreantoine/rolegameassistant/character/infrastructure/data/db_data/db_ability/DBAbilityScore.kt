// File DBAbilityScore.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.ABILITY_SCORE_TABLE_NAME

/**
 *   Class "DBAbilityScore" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = ABILITY_SCORE_TABLE_NAME)
class DBAbilityScore (
    @PrimaryKey(autoGenerate = true)
    var dbAbilityScore_id:Int?,
    var dbAbilityScore_ability:String?,
    var dbAbilityScore_roll:Int?,
    var dbAbilityScore_bonus:Int?,
    var dbAbilityScore_total:Int?
){
// TODO : Fill class.
}