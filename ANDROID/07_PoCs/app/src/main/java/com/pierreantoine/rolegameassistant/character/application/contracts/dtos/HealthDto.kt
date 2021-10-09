// File HealthDto.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos

/**
 *   Class "HealthDto" :
 *   Values transmitted between ui and application layer.
 **/
class HealthDto(
    /** Identifier  **/
    var id:Int?,
    /** Health point modifier   **/
    var hpMod:Int?,
    /** Use max health  **/
    var useMax:Boolean?,
    /** Max health value    **/
    var maxHealth:Int?
)