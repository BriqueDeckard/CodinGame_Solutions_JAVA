// File DBClass.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.CLASS_TABLE_NAME

/**
 *   Class "DBClass" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = CLASS_TABLE_NAME)
class DBClass(
    @PrimaryKey(autoGenerate = true)
    var dbClass_id:Int?,
    var dbClass_name:String?
) {
// TODO : Fill class.
}