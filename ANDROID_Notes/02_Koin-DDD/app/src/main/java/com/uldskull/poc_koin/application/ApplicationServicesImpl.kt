// File MySimplePresenter.kt
// @Author pierre.antoine - 17/01/2020 - No copyright.

package com.uldskull.poc_koin.application

import com.uldskull.poc_koin.application.contracts.ApplicationServices
import com.uldskull.poc_koin.domain.contracts.HelloFactory
import com.uldskull.poc_koin.domain.contracts.HelloModelDto
import com.uldskull.poc_koin.domain.HelloModel
import com.uldskull.poc_koin.domain.contracts.HelloRepository

/**
 *   Class "MySimplePresenter" :
 *   un composant qui va nous aider à récupérer notre message et qui sera utilisé par
 *   une vue Android.
 **/
class ApplicationServicesImpl(val repo: HelloRepository, val factory: HelloFactory) :
    ApplicationServices {

    override fun insert(helloModelDto: HelloModelDto): String {

        val model: HelloModel = factory.convert(helloModelDto)

        model.who = model.who + "OO"



        return repo.insertEntity(model)
    }

}