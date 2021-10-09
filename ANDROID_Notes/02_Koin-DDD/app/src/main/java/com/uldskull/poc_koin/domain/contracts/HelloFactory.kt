// File HelloFactory.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.uldskull.poc_koin.domain.contracts

import com.uldskull.poc_koin.domain.HelloModel

/**
 *   Interface "HelloFactory" :
 *   TODO: Fill interface use.
 **/
interface HelloFactory {

    fun convert(dto: HelloModelDto): HelloModel
}