// File DlawDto.kt
// @Author errei - 22/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background

/**
 *   Class "FlawDto" :
 *   Used to transmit flaw values between ui and application layer.
 **/
class FlawDto (
    /** Identifier  **/
    var id:Int?,
    /** Flaw value **/
    var flaw:String?
)