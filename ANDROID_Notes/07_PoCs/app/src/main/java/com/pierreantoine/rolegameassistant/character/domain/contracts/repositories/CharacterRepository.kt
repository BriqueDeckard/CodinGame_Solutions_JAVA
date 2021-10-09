// File CharacterRepository.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.repositories

import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel

/**
 *   Interface "CharacterRepository" :
 *   Layer between application and infrastructure.
 **/
interface CharacterRepository : Repository<CharacterModel>{

    /**
     * Insert a character model.
     */
   override suspend fun insert(character:CharacterModel?):CharacterModel?

    /**
     * Get a character model by its Id.
     */
    override suspend fun get(id:Int?):CharacterModel?

    /**
     * Get all the character models.
     */
    override   suspend fun getAll():List<CharacterModel>?

    /**
     * Update a character model.
     */
    override  suspend fun update(character: CharacterModel?):CharacterModel?

    /**
     * Delete a character model.
     */
    override suspend fun delete(id:Int?):CharacterModel?

    /**
     * Delete all the characters.
     */
    override  suspend fun deleteAll():Boolean?
}