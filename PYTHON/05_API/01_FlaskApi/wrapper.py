from sqlalchemy.orm import sessionmaker
from sqlalchemy.ext.declarative import declarative_base
from sqlalchemy import create_engine, Column, String, ForeignKey

print("Imports succesful")

MYSQL_HOST = "172.17.0.2"
MYSQL_PORT =3306
MYSQL_USER ="root"
MYSQL_PWD = "root"
MYSQL_DB = "user"

SQLALCHEMY_DB_URI = "mysql+pymysql://{}:{}@{}:{}/{}".format(MYSQL_USER,MYSQL_PWD, MYSQL_HOST, MYSQL_PORT, MYSQL_DB)

engine = create_engine(SQLALCHEMY_DB_URI)
print("Engine created")
Session = sessionmaker(bind=engine)
session = Session()
print("Session created")

Base = declarative_base()

"""
"User" table corresponding object
"""

class User:
    def __init__(self, email, nom, prenom, ville, telephone):
        self.email = email
        self.nom = nom
        self.prenom = prenom
        self.ville = ville
        self.telephone = telephone

__tablename__="user"

email = Column(String(120), unique=True, nullable=False, primary_key=True)
nom = Column(String(80), nullable=False)
prenom = Column(String(80), nullable=False)
ville = Column(String(80), nullable=False)
telephone = Column(String(80), nullable=False)

# ---- CRUD ----
"""
Add
"""
def add_user(email, nom, prenom, ville, telephone):
    try:
        # Create a new user
        user = User(email = email,
        nom = nom,
        prenom = prenom,
        ville = ville,
        telephone = telephone)
        print("ADD")
        # Add it
        session.add(user)
        # Commit
        session.commit()
        return True
    except Exception as e:
        print(Type(e) + e)
        return false
"""
Get by ID
"""
def get_user_by_id(email):
    try:
        # returns the first user correspondig to the filter 'email'
        result = session.query(User).filter_by(email=email).first()
        return result
    except Exception as e:
        print(e)
        return False

"""
Get all users
"""
def get_all_users():
    try:
        # returns the uses that correspond to "no filter"
        result = session.query(User).filter_by()

        return result
    except Exception as e:
        print(e)
        return False
"""
Delete user
"""
def delete_user_by_id(email):
    try:
        # Get the user by its ID
        user_to_delete = get_user_by_id(email)
        # delete it
        if user_to_delete :
            session.delete(user_to_delete)
            session.commit()
            return True
        else:
            return False
    except Exception as e:
        print(e)
        return False
"""
Update something on user
"""
def update_attribute(email, attributes):

    try:
        # Get the user
        user_to_update = get_user_by_id(email)
        if user_to_update :
            # Update the attributes
            for k,v in attributes.items():
                setattr(user_to_update, k, v)
            # COMMIT !!
            session.commit()
            return user_to_update
        else:
            return False
    except Exception as e:
        print(e)
        return False