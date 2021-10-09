// File MapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.uldskull.poc_koin.infrastructure.data

import com.uldskull.poc_koin.domain.HelloModel

/**
 *   Class "MapperImpl" :
 *   TODO: Fill class use.
 **/
class MapperImpl : Mapper {


    override fun map(model: HelloModel): DbHelloModel {
        return DbHelloModel(model.who)
    }
// TODO : Fill class.
}