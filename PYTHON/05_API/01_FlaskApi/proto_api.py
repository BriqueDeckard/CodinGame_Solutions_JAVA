
import wrapper
import json
from flask import Flask, jsonify, request
print("Import success")

app = Flask(__name__)


@app.route('/api/v1/user', methods=['POST'])
def create_user():
    # Gets the query payload 
    
    payload = request.get_json()
    nom = payload['nom']
    email = payload['email']
    prenom= payload['prenom']
    ville = payload['ville']
    telephone = payload['telephone']
    
    print(nom, "+", prenom,"+",email,"+",ville,"+",telephone)

    result = wrapper.add_user(email=email, nom=nom, prenom=prenom, ville=ville,telephone=telephone)

    if result:
        return jsonify(status='True', message='User created')
    return jsonify(status='False')

@app.route('/api/v1/user/', methods=['GET'])
def get_all_users():
    result = wrapper.get_all_users()
    if result:
        return jsonify(status="True", 
        result= [
            {"nom":user.nom,
             "prenom":user.prenom,
             "email":user.email,
             "ville": user.ville,
             "telephone": user.telephone} for user in result.all() ])
    return jsonify(status="False")

@app.route('/api/v1/user/<email>', methods=['GET'])
def get_user(email):
    result = wrapper.get_user_by_id(email)
    if result:
        return jsonify(status="True", 
                    result={"nom":result.nom,
                            "prenom":result.prenom,
                            "email":result.email,
                            "ville": result.ville,
                            "telephone": result.telephone}
                        )
    return jsonify(status="False")

@app.route('/api/v1/user/<email>', methods=['PUT'])
def mofify_user(email):
    result = wrapper.update_attribute(email, request.form.to_dict())
    if result:
        return jsonify(status="True",
                        message= "updated",
                        result={
                            "nom":result.nom,
                            "prenom":result.prenom,
                            "email":result.email,
                            "ville": result.ville,
                            "telephone": result.telephone}
                            )
    return jsonify(status= "False")


@app.route('/api/v1/user/<email>', methods=['DELETE'])
def delete_user(email):
    result = wrapper.delete_user_by_id(email)
    if result:
        return jsonify(status="True",
                        message= "Deleted",
                        email=email
                        )
    return jsonify(status="False")


if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000, debug=True)