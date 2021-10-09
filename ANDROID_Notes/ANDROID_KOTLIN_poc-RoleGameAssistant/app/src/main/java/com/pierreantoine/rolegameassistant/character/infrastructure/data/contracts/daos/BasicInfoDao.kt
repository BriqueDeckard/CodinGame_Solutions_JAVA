// File BasicInfoDao.kt
// @Author pierre.antoine - 23/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos

import androidx.lifecycle.LiveData
import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.BASIC_INFO_TABLE_NAME
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBBasicInfo
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.DbContract.Queries.Companion.SELECT_ALL_FROM
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.DbContract.Queries.Companion.DELETE_FROM
/**
 *   Interface "BasicInfoDao" :
 *   Used to acces sqlite database
 **/
@Dao
interface BasicInfoDao {

    @Query("$SELECT_ALL_FROM $BASIC_INFO_TABLE_NAME")
    fun getAllCHaracters(): LiveData<List<DBBasicInfo?>>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(dbBasicInfo: DBBasicInfo?):Int?

    @Query("$DELETE_FROM $BASIC_INFO_TABLE_NAME")
    suspend fun deleteAll()
}