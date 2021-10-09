// File CharacterRepository.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.repository

import androidx.lifecycle.LiveData
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.repositories.CharacterRepository
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos.BasicInfoDao
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos.CharacterDao
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos.CharacteristicsDao
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.BasicInfoMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.CharacterMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.CharacteristicsMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacter

/**
 *   Class "CharacterRepository" :
 *   Layer between application and infrastructure.
 **/
class CharacterRepositoryImpl(
    private val characterDao: CharacterDao?,
    private val basicInfoDao: BasicInfoDao?,
    private val characteristicsDao: CharacteristicsDao?,
    private val characterMapper: CharacterMapper?,
    private val basicInfoMapper: BasicInfoMapper?,
    private val characteristicsMapper: CharacteristicsMapper?

) : CharacterRepository {
    /**
     * Insert a character model.
     */
    override suspend fun insert(character: CharacterModel?): CharacterModel? {

        var basicInfoId = basicInfoDao?.insert(
            basicInfoMapper?.map(
                character?.basicInfo))

        var characteristicsId = characteristicsDao?.insert(
            characteristicsMapper?.map(
                character?.characteristics))








        characterDao?.insert(characterMapper?.map(character))
        return character
    }

    val allCharacters: LiveData<List<DBCharacter>>? = characterDao?.getAllCharacters()

    /**
     * Get a character model by its Id.
     */
    override suspend fun get(id: Int?): CharacterModel? {


        return null //STUB
    }

    /**
     * Get all the character models.
     */
    override suspend fun getAll(): List<CharacterModel>? {
        TODO("implement method according to LiveData use")
    }

    /**
     * Update a character model.
     */
    override suspend fun update(character: CharacterModel?): CharacterModel? {
        TODO("Implement update into the DAO")
        // characterDao?.update(characterMapper.map(character))
    }

    /**
     * Delete a character model.
     */
    override suspend fun delete(id:Int?): CharacterModel? {
        TODO("Implement delete one into the DAO")
        // characterDao?.delete(characterMapper.map(character))
    }

    /**
     * Delete all the characters.
     */
    override suspend fun deleteAll(): Boolean? {
        characterDao?.deleteAll()
        return true
    }
}