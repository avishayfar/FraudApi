from Model.Retail import Transaction
from ML.Fraud import *
from flask_restful import fields, marshal_with, reqparse, Resource
from flask import jsonify
import json
from DAO.TransactionDao import *


transaction_parser = reqparse.RequestParser()  
transaction_parser.add_argument('ColumnsNames', required=True ,help='Feature Names' , action='append')
transaction_parser.add_argument('Values',       required=True ,help='Feature Values', action='append')


transaction_fields = {
    'ColumnsNames': fields.List(fields.String),
    'Values': fields.List(fields.String),
}

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


class TransactionsApi(Resource):
       
    #@marshal_with(transaction_fields)
    def post(self):
        args = transaction_parser.parse_args()
        columnsNameLst = args['ColumnsNames']
        valuesLst = args['Values'] 
        transaction = Transaction(columnsNameLst, valuesLst)       
        
        try:
            fraudCalc = FraudCalc()
            fruadVal = fraudCalc.calculate(transaction)
            return jsonify(float(fruadVal))
        except Exception: 
            return jsonify(55555)


class TransactionsResultSavingApi(Resource):
       
    #@marshal_with(transaction_fields)
    def post(self):
        args = transaction_parser.parse_args()
        columnsNameLst = args['ColumnsNames']
        valuesLst = args['Values'] 
        transaction = Transaction(columnsNameLst, valuesLst)
        transactionDao = TransactionDao()
        retVal = transactionDao.Save(transaction)
        return jsonify(retVal)
      





      



