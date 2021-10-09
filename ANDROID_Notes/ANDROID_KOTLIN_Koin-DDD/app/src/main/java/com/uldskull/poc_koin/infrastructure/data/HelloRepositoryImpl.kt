// File HelloRepositoryImpl.kt
// @Author pierre.antoine - 17/01/2020 - No copyright.

package com.uldskull.poc_koin.infrastructure.data

import android.util.Log
import com.uldskull.poc_koin.domain.HelloModel
import com.uldskull.poc_koin.domain.contracts.HelloRepository

/**
 *   Class "HelloRepositoryImpl" :
 *   TODO: Fill class use.
 **/
class HelloRepositoryImpl (val mapper: Mapper):
    HelloRepository {

    override fun insertEntity(helloModel: HelloModel): String {
        return mapper.map(helloModel).who
    }



// TODO : Fill class.
}