

#################### resource.py #######################

def abort_if_todo_doesnt_exist(transaction_id):
    if transaction_id not in TRANSACTIONS:
        abort(404, message="transaction {} doesn't exist".format(transaction_id))

class TransactionApi(Resource):

    @marshal_with(transaction_fields)
    def get(self, transaction_id):
        abort_if_todo_doesnt_exist(transaction_id)
        #return
        pass

    @marshal_with(transaction_fields)
    def delete(self, transaction_id):
        abort_if_todo_doesnt_exist(transaction_id)
        #return
        pass

    @marshal_with(transaction_fields)
    def put(self, transaction_id):
        args = transaction_parser.parse_args()
        columnsNameLst = args['columnsNameLst']
        valuesLst = args['valuesLst']
        st = Transaction(columnsNameLst, valuesLst)
        #return
        pass


############################# app.py ##############################

from flask import Flask
from flask_restful import reqparse, abort, Api, Resource
from flask_restful import fields, marshal_with
import datetime

from Model.Retail import Transaction
from Resources.TransactionsMLFraud import *

app = Flask(__name__)
api = Api(app)

##################

api.add_resource(TransactionApi,  '/transaction/<transaction_id>')

if __name__ == '__main__':
    app.run(debug=False, port=5002)