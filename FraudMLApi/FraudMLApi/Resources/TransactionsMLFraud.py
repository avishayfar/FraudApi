from Model.Retail import Transaction
from ML.Fraud import *
from flask_restful import fields, marshal_with, reqparse, Resource
from flask import jsonify
import json
from Connectivitiy.TransactionDao import *


transaction_parser = reqparse.RequestParser()  
transaction_parser.add_argument('ColumnsNames', required=True ,help='Feature Names' , action='append')
transaction_parser.add_argument('Values',       required=True ,help='Feature Values', action='append')


transaction_fields = {
    'ColumnsNames': fields.List(fields.String),
    'Values': fields.List(fields.String),
}


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




      





      



