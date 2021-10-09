// File DBBasicInfo.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info

import androidx.room.Embedded
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.BASIC_INFO_TABLE_NAME

/**
 *   Class "DBBasicInfo" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = BASIC_INFO_TABLE_NAME)
    class DBBasicInfo (
    @PrimaryKey(autoGenerate = true)
    var dbBasicInfo_id:Int?,
    var dbBasicInfo_name: String?,
    var dbBasicInfo_level: Int?,
    var dbBasicInfo_experience: Int?,
    @Embedded
    var dbBasicInfo_race: DBRace?,
    @Embedded
    var dbBasicInfo_classModel: DBClass?
){
// TODO : Fill class.
}