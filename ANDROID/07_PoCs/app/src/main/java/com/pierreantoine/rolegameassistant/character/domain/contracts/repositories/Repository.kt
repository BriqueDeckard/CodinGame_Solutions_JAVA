// File Repository.kt
// @Author pierre.antoine - 23/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.repositories

/**
 *   Interface "Repository" :
 *   Interface to ensure repositories methods.
 **/
interface Repository <T>{

    /** Insert T    **/
    suspend fun insert(t:T?):T?
    /** Get a T by its id   **/
    suspend fun get(id:Int?):T?
    /** Get all T   **/
    suspend fun getAll():List<T>?
    /** Update a T  **/
    suspend fun update(t:T?):T?
    /** Delete a T  **/
    suspend fun delete(id: Int?):T?
    /** Delete all T    **/
    suspend fun deleteAll():Boolean?
}