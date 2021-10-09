// File AppModule.kt
// @Author pierre.antoine - 17/01/2020 - No copyright.

package com.uldskull.poc_koin.infrastructure.cross_cutting

import com.uldskull.poc_koin.application.ApplicationServicesImpl
import com.uldskull.poc_koin.application.contracts.ApplicationServices
import com.uldskull.poc_koin.infrastructure.data.MapperImpl
import com.uldskull.poc_koin.infrastructure.data.Mapper
import com.uldskull.poc_koin.domain.HelloFactoryImpl
import com.uldskull.poc_koin.domain.contracts.HelloFactory
import com.uldskull.poc_koin.infrastructure.data.HelloRepositoryImpl
import com.uldskull.poc_koin.domain.contracts.HelloRepository
import com.uldskull.poc_koin.ui.MainActivityViewModel
import org.koin.androidx.viewmodel.dsl.viewModel
import org.koin.dsl.module

val appModule = module {

    //     single instance of HelloRepository
    single<HelloRepository> { HelloRepositoryImpl(get()) }

    single<HelloFactory> { HelloFactoryImpl() }

    single<ApplicationServices> { ApplicationServicesImpl (get(), get())  }

    viewModel { MainActivityViewModel(get(), get()) }


    single<Mapper> { MapperImpl() }
    // Simple Presenter Factory
    // afin d'avoir une nouvelle instance à chaque fois que ma vue sera créée

    //  À chaque fois que j'ai besoin d'injecter une instance dans un constructeur,
    //  je vais utiliser la fonction get()
    factory {
        ApplicationServicesImpl(
            get(),
            get()
        )
    }
}