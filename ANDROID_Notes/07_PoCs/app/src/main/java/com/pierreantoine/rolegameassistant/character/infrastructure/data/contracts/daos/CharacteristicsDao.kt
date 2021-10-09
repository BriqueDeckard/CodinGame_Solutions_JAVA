// File CharacteristicsDao.kt
// @Author pierre.antoine - 23/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacteristics

/**
 *   Interface "CharacteristicsDao" :
 *   TODO: Fill interface use.
 **/
@Dao
interface CharacteristicsDao {

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(characteristicsDbModel: DBCharacteristics?):Int?
}