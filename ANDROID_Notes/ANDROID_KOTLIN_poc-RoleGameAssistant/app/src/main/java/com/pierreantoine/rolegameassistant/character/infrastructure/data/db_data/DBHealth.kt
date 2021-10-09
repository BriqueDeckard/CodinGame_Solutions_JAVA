// File DBHealth.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.HEALTH_TABLE_NAME

/**
 *   Class "DBHealth" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = HEALTH_TABLE_NAME)
class DBHealth(
    @PrimaryKey(autoGenerate = true)
    var dbHealth_id:Int?,
    var dbHealth_hpMod:Int?,
    var dbHealth_useMax:Boolean?,
    var dbHealth_maxHealth:Int?
) {
// TODO : Fill class.
}