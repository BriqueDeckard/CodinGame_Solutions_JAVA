package edu.bd.notes.url_encoder;

import java.io.UnsupportedEncodingException;

import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLEncoder;

public class UrlEncoderJava {
	public static void main(String[] args) throws MalformedURLException, UnsupportedEncodingException {
		String baseUrl = "https://www.google.fr/?q=";
		String query = "u@ query=42 56 75";
		URL url = new URL(baseUrl + query);
		System.out.println("Without encoding: " + url);
		
		url = new URL(baseUrl + URLEncoder.encode(query, "UTF-8"));
		System.out.println("With encoding: " + url);
	}

}
