// File Mapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.uldskull.poc_koin.infrastructure.data

import com.uldskull.poc_koin.domain.HelloModel

/**
 *   Interface "Mapper" :
 *   TODO: Fill interface use.
 **/
interface Mapper  {
    fun map(model: HelloModel): DbHelloModel
}