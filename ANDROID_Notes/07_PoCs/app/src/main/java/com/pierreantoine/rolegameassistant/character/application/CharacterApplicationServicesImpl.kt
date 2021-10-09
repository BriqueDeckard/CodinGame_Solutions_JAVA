// File CharacterApplicationServicesImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application

import android.util.Log
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacterDto
import com.pierreantoine.rolegameassistant.character.application.contracts.services.CharacterApplicationServices
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.CharacterFactory
import com.pierreantoine.rolegameassistant.character.domain.contracts.repositories.CharacterRepository

/**
 *   Class "CharacterApplicationServicesImpl" :
 *   Implementation of CharacterApplicationServices
 **/
class CharacterApplicationServicesImpl(
    private val characterRepository: CharacterRepository,
    private val characterFactory: CharacterFactory
) :
    CharacterApplicationServices {
    /**
     * Insert a character into the database.
     */
    override suspend fun insert(characterDto: CharacterDto?): CharacterDto? {
        Log.i(this::class.java.name, "insert")
        var characterModel: CharacterModel? =
            characterRepository.insert(characterFactory.toDomain(characterDto))

        return characterFactory.toDto(characterModel)
    }

    /**
     * Get a character from the database.
     */
    override suspend fun get(characterDto: CharacterDto?): CharacterDto? {
        Log.i(this::class.java.name, "get")
        var characterModel = characterRepository.get(characterDto?.id)

        return characterFactory.toDto(characterModel)
    }

    /**
     * Update a character.
     */
    override suspend fun update(characterDto: CharacterDto?): CharacterDto? {
        Log.i(this::class.java.name, "update")

        var characterModel =
            characterRepository.update(characterFactory.toDomain(characterDto))

        return characterFactory.toDto(characterModel)
    }

    /**
     * Delete a character
     */
    override suspend fun delete(characterDto: CharacterDto?): CharacterDto?{
        Log.i(this::class.java.name, "delete")
        var characterModel =
            characterRepository.delete(characterFactory.toDomain(characterDto)?.id)

        return characterFactory.toDto(characterModel)
    }
}