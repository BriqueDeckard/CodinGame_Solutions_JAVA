// File CharacterDao.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos

import androidx.lifecycle.LiveData
import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.CHARACTER_TABLE_NAME
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.DbContract.Queries.Companion.SELECT_ALL_FROM
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.DbContract.Queries.Companion.DELETE_FROM
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacter

/**
 *   Interface "CharacterDao" :
  **/
@Dao
interface CharacterDao {

    @Query("$SELECT_ALL_FROM $CHARACTER_TABLE_NAME")
    fun getAllCharacters(): LiveData<List<DBCharacter>>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(characterDbModel: DBCharacter?):Int?

    @Query("$DELETE_FROM $CHARACTER_TABLE_NAME")
    suspend fun deleteAll()
}