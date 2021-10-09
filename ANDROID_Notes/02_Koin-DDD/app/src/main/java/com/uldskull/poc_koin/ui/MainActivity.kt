package com.uldskull.poc_koin.ui

import android.os.Bundle
import android.view.View
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.uldskull.poc_koin.R
import com.uldskull.poc_koin.application.ApplicationServicesImpl
import com.uldskull.poc_koin.domain.contracts.HelloModelDto
import kotlinx.android.synthetic.main.activity_main.*
import org.koin.android.ext.android.inject
import org.koin.androidx.viewmodel.ext.android.getViewModel

class MainActivity : AppCompatActivity() {

    val applicationServices: ApplicationServicesImpl by inject()

    private lateinit var viewModel : MainActivityViewModel



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        viewModel = getViewModel ()
        btn_say_hi.setOnClickListener(View.OnClickListener {


            var helloModelDto: HelloModelDto =
                HelloModelDto("Me ! ")
            var dbModel: String = applicationServices.insert(helloModelDto)

            Toast.makeText(this, dbModel, Toast.LENGTH_SHORT).show()

        })

        btn_say_hello.setOnClickListener(View.OnClickListener {
            var helloModelDto: HelloModelDto =
                HelloModelDto("You ! ")

            var dbResult:String = viewModel.insert(helloModelDto)

            Toast.makeText(this, dbResult, Toast.LENGTH_SHORT).show()
        })
        title = "MainActivity"


    }


}
