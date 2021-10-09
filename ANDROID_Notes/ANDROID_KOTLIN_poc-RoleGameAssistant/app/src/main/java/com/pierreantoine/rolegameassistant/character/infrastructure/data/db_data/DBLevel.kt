// File DBLevel.kt
// @Author errei - 20/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data

import androidx.room.PrimaryKey

/**
 *   Class "DBLevel" :
 *   TODO: Fill class use.
 **/
class DBLevel     (
    @PrimaryKey(autoGenerate = true)
    var dbLevel_id:Int?,
    var dbLevel_value:Int?,
    var dbLevel_hpMod:Int?
){
// TODO : Fill class.
}