// File BondDto.kt
// @Author errei - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background

/**
 *   Class "BondDto" :
 *   Used to transmit bond object values between ui and application layer
 **/
class BondDto (
    /** Identifier  **/
    var id:Int?,
    /** Bond value **/
    var bond:String?
)