// File PersonalityDto.kt
// @Author errei - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background

/**
 *   Class "PersonalityDto" :
 *   USed to transmit Personality object values between ui and application layer.
 **/
class PersonalityDto (
    /** Identifier  **/
    var id:Int?,
    /** Personality value **/
    var personality:String?
)