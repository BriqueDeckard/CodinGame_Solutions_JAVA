// File DBRace.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.RACE_TABLE_NAME

/**
 *   Class "DBRace" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = RACE_TABLE_NAME)
class DBRace(
    @PrimaryKey(autoGenerate = true)
    var dbRace_id:Int?,
    var dbRace_name:String?
) {
// TODO : Fill class.
}