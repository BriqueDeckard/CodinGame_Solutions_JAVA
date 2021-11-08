package com.briquedeckard.library.mail;

public class MailDTO {
	public Integer getCustomerId() {
		return customerId;
	}

	public void setCustomerId(Integer customerId) {
		this.customerId = customerId;
	}

	public String getEmailSubject() {
		return emailSubject;
	}

	public void setEmailSubject(String emailSubject) {
		this.emailSubject = emailSubject;
	}

	public String getEmailContent() {
		return emailContent;
	}

	public void setEmailContent(String emailContent) {
		this.emailContent = emailContent;
	}

	public String getMAIL_FROM() {
		return MAIL_FROM;
	}

	public final String MAIL_FROM = "noreply.library.test@gmail.com";

	private Integer customerId;

	private String emailSubject;

	private String emailContent;

}
