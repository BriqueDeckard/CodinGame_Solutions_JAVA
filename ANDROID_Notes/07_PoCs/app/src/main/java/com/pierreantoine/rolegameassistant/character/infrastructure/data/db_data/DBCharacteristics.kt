// File DBCharacteristics.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.CHARACTERISTICS_TABLE_NAME

/**
 *   Class "DBCharacteristics" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = CHARACTERISTICS_TABLE_NAME)
class DBCharacteristics(
    @PrimaryKey(autoGenerate = true)
    var dbCharacteristics_id:Int?,
    var dbCharacteristics_gender:String?,
    var dbCharacteristics_height:Int?,
    var dbCharacteristics_weight:Int?,
    var dbCharacteristics_age:Int?
) {
// TODO : Fill class.
}