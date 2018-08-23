from flask_restful import fields


class Transaction:

    def __init__(self,columnsNameLst, valuesLst):
       self.ColumnsNames = columnsNameLst
       self.Values = valuesLst

    def ColNamesWithValues():
        return dict(zip(transaction.ColumnsNames, transaction.values))