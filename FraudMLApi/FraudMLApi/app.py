
from flask import Flask
from flask_restful import reqparse, abort, Api, Resource
from flask_restful import fields, marshal_with
import datetime

from Model.Retail import Transaction
from Resources.TransactionsMLFraud import *

app = Flask(__name__)
api = Api(app)

##################

api.add_resource(TransactionsApi, '/transactions')
api.add_resource(TransactionApi,  '/transaction/<transaction_id>')
api.add_resource(TransactionsResultSavingApi,  '/transactionFraudSaving')

if __name__ == '__main__':
    app.run(debug=False, port=5002)





