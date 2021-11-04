# API:

## Principles:

An API is a set of definitions and protocols that make the software creation and integration easier.

It allows to services to communicate with other products or services, without knowing the details of their implementation.

It is sometimes considered as a contract, followed by a documentation which constitute a "deal" between the different parts. 
Eg. if part 1 send a remote request, following a particulary structure, the part 2 's software should answer by following the defined conditions.

### Simple Object Access Protocol: 
- Uses the XML format for the messages ; 
- Receives query via HTTP or SMTP.
SOAP --> Protocol

### Representational State Transfer: 
- Web APIs that respect constraints implied by the REST architecture are called "RESTful API".
REST --> Architecture

APIs are RESTful only if they respect the six RESTful system's designing contraints :
- Client-server architecture
- Stateless server
- Cache memory
- Layered system
- Uniform interface:
  - resources identification in query 

### Authent: 

The user logs in with a POST request containing his username and password,
The server returns a temporary / permanent authentication token,
The user sends the token within each HTTP request via an HTTP header Authorization: Bearer TOKEN.
When the user logs out, the token is cleared on server-side. 

[blog-ocoto](https://blog.octo.com/securiser-une-api-rest-tout-ce-quil-faut-savoir/#private_public_resources)