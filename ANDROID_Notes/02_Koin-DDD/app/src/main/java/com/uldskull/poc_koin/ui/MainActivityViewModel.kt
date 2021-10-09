// File MainActivityViewModel.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.uldskull.poc_koin.ui

import android.app.Application
import androidx.lifecycle.AndroidViewModel
import com.uldskull.poc_koin.application.contracts.ApplicationServices
import com.uldskull.poc_koin.domain.contracts.HelloModelDto

/**
 *   Class "MainActivityViewModel" :
 *   TODO: Fill class use.
 **/
class MainActivityViewModel(application: Application,val  applicationServices: ApplicationServices)
    : AndroidViewModel(application){

    fun insert(dto: HelloModelDto):String{
      return  applicationServices.insert(dto)
    }
// TODO : Fill class.
}