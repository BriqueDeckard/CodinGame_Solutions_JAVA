// File HelloFactory.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.uldskull.poc_koin.domain

import com.uldskull.poc_koin.domain.contracts.HelloFactory
import com.uldskull.poc_koin.domain.contracts.HelloModelDto

/**
 *   Class "HelloFactory" :
 *   TODO: Fill class use.
 **/
class HelloFactoryImpl:
    HelloFactory {

    override fun convert(dto: HelloModelDto): HelloModel {
        return HelloModel(dto.who)
    }
}