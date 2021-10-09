// File Factory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

/**
 *   Interface "Factory" :
 *   To ensure that the factory that implements it has toDomain and toDto
 **/
interface Factory<T, U> {
    /**
     * Converts a dto into a domain model
     */
    fun toDomain(dto:T?):U?

    /**
     * Converts a domain model into a dto.
     */
    fun toDto(domainModel:U?):T?
}