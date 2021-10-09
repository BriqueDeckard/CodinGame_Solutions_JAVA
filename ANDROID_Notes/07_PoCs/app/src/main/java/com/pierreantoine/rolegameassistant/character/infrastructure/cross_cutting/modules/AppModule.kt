/** File AppModule.kt
 *   @Author pierre.antoine - 18/01/2020 - No copyright.
 **/

package com.pierreantoine.rolegameassistant.character.infrastructure.cross_cutting.modules

import androidx.room.Room
import com.pierreantoine.rolegameassistant.character.application.CharacterApplicationServicesImpl
import com.pierreantoine.rolegameassistant.character.application.contracts.services.CharacterApplicationServices
import com.pierreantoine.rolegameassistant.character.domain.contracts.factories.AbilityScoresFactory
import com.pierreantoine.rolegameassistant.character.domain.contracts.repositories.CharacterRepository
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.*
import com.pierreantoine.rolegameassistant.character.domain.factories.*
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.*
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.*
import com.pierreantoine.rolegameassistant.character.infrastructure.data.database.CharacterDatabase
import com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.*
import com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.background.*
import com.pierreantoine.rolegameassistant.character.infrastructure.data.repository.CharacterRepositoryImpl
import com.pierreantoine.rolegameassistant.character.ui.main.CharacterViewModel
import org.koin.android.ext.koin.androidApplication
import org.koin.androidx.viewmodel.dsl.viewModel
import org.koin.dsl.module

/** Injects mappers singletons  **/
val mappersModule = module {
    single<AbilityScoreMapper> { AbilityScoreMapperImpl() }
    single<AbilityScoresMapper> { AbilityScoresMapperImpl() }
    single<ClassMapper> { ClassMapperImpl() }
    single<RaceMapper> { RaceMapperImpl() }
    single<BioMapper> { BioMapperImpl() }
    single<BondMapper> { BondMapperImpl() }
    single<FlawMapper> { FlawMapperImpl() }
    single<IdealMapper> { IdealMapperImpl() }
    single<PersonalityMapper> { PersonalityMapperImpl() }
    single<BackgroundMapper> {
        BackgroundMapperImpl(
            bioMapper = get(),
            bondMapper = get(),
            flawMapper = get(),
            idealMapper = get(),
            personalityMapper = get()
        )
    }
    single<BasicInfoMapper> { BasicInfoMapperImpl(get(), get()) }
    single<CharacteristicsMapper> { CharacteristicsMapperImpl() }
    single<HealthMapper> { HealthMapperImpl() }
    single<SkillMapper> { SkillMapperImpl() }
    single<SkillsMapper> { SkillsMapperImpl() }

    single<CharacterMapper> {
        CharacterMapperImpl(
            healthMapper = get(),
            abilityScoresMapper = get(),
            backgroundMapper = get(),
            basicInfoMapper = get(),
            characteristicsMapper = get(),
            skillsMapper = get()
        )
    }
}
/** Injects factories singleton **/
val factoriesModule = module {
    single<AbilityScoresFactory> { AbilityScoresFactoryImpl() }
    single<BioFactory> { BioFactoryImpl() }
    single<BondFactory> { BondFactoryImpl() }
    single<FlawFactory> { FlawFactoryImpl() }
    single<IdealFactory> { IdealFactoryImpl() }
    single<PersonalityFactory> { PersonalityFactoryImpl() }
    single<BackgroundFactory> {
        BackgroundFactoryImpl(
            bioFactory = get(),
            bondFactory = get(),
            flawFactory = get(),
            idealFactory = get(),
            personalityFactory = get()
        )
    }
    single<BasicInfoFactory> { BasicInfoFactoryImpl(get(), get()) }
    single<CharacteristicsFactory> { CharacteristicsFactoryImpl() }
    single<HealthFactory> { HealthFactoryImpl() }
    single<SkillsFactory> { SkillsFactoryImpl() }
    single<ClassFactory> { ClassFactoryImpl() }
    single<RaceFactory> { RaceFactoryImpl() }

    single<CharacterFactory> {
        CharacterFactoryImpl(
            abilityScoresFactory = get(),
            backgroundFactory = get(),
            basicInfoFactory = get(),
            characteristicsFactory = get(),
            healthFactory = get(),
            skillsFactory = get()
        )
    }
}
/** Inject database singleton   **/
val dbModule = module {
    single {
        Room.databaseBuilder(androidApplication(), CharacterDatabase::class.java, "character-db")
            .build()
    }
}
/** Inject DAO singleton    **/
val daoModule = module {
    single { get<CharacterDatabase>().characterDao() }
    single { get<CharacterDatabase>().basicInfoDao() }
}

//  https://android.jlelse.eu/painless-android-testing-with-room-koin-bb949eefcbee
/** Inject repositories singletons  **/
val repositoryModule = module {
    single<CharacterRepository> { CharacterRepositoryImpl(
        characteristicsMapper =  get(),
        basicInfoMapper = get(),
        basicInfoDao = get(),
        characterDao = get(),
        characteristicsDao = get(),
        characterMapper = get()
    )
    }
}

/** Inject application services singletons  **/
val applicationServicesModule = module {
    single<CharacterApplicationServices> { CharacterApplicationServicesImpl(get(), get()) }
}

/** Inject viewModels   **/
val viewModelModule = module {
    viewModel { CharacterViewModel(get(), get()) }
}


