// File BiographyDto.kt
// @Author pierre.antoine - 23/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background

/**
 *   Class "BiographyDto" :
 *   Used to transmit data between ui and application layer.
 **/
class BiographyDto (
    /** Identifier  **/
    var id:Int?,
    /** Flaw value **/
    var biography:String?
)