// File CharacterDto.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data

import androidx.room.Embedded
import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.CHARACTER_TABLE_NAME
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability.DBAbilityScores
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBackground
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBBasicInfo
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills.DBSkills

/**
 *   Class "CharacterDto" :
 *   TODO: Fill class use.
 **/
@Entity(
    foreignKeys = arrayOf(
        ForeignKey(
            entity = DBBasicInfo::class,
            parentColumns = arrayOf("dbBasicInfo_id"),
            onDelete = ForeignKey.NO_ACTION,
            childColumns = arrayOf("dbBasicInfo_id")
        )),
    tableName = CHARACTER_TABLE_NAME
)
class DBCharacter(
    @PrimaryKey(autoGenerate = true)
    var dbCharacter_id:Int?,
    @Embedded
    var dbCharacteristics: Int?,
    var dbBackground_id: Int?,
    var dbAbilityScores_id: Int?,
    var dbHealth_id: Int?,
    var dbSkills_id: Int??,
    var dbBasicInfo_id:Int?


) {
// TODO : Fill class.
}