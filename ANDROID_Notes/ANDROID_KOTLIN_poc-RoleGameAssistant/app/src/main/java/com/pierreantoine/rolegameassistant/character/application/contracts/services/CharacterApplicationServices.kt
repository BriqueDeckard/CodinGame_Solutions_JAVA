// File CharacterApplicationServices.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.services

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacterDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel

/**
 *   Interface "CharacterApplicationServices" :
 *   Interface to provide a hosting environment for the execution of domain logic
 **/
interface CharacterApplicationServices {

    /**
     * Insert a character.
     */
    suspend fun insert(characterDto: CharacterDto?) : CharacterDto?

    /**
     * Get a character by its Id.
     */
    suspend fun get(characterDto: CharacterDto?) : CharacterDto?

    /**
     * Update a character.
     */
    suspend fun update(characterDto: CharacterDto?) : CharacterDto?

    /**
     * Delete a character.
     */
    suspend fun delete(characterDto: CharacterDto?) : CharacterDto?
}