// File DBSkill.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills

import androidx.room.Entity
import androidx.room.PrimaryKey

/**
 *   Class "DBSkill" :
 *   TODO: Fill class use.
 **/
@Entity
class DBSkill (
    @PrimaryKey(autoGenerate = true)
    var dbSkill_id:Int?,
    var dbSkill_checked:Boolean?,
    var dbSkill_name:String?,
    var dbSkill_modifier:Int?
){
// TODO : Fill class.
}