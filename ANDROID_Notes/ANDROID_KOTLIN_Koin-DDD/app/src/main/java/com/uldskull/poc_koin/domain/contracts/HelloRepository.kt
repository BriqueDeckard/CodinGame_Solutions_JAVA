// File HelloRepository.kt
// @Author pierre.antoine - 17/01/2020 - No copyright.

package com.uldskull.poc_koin.domain.contracts

import com.uldskull.poc_koin.domain.HelloModel

/**
 *   Interface "HelloRepository" :
 *   va nous fournir un message via la fonction giveHello()
 **/
interface HelloRepository {
    fun insertEntity(dto: HelloModel):String
}