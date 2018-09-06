import psycopg2
from sqlalchemy import *
from Model.Retail import Transaction

class TransactionDao():
   
    def __init__(self):
        self.engine = create_engine('postgresql://postgres:Qwe12345@localhost:5432/FRD')
        self.metadata = MetaData(self.engine)

    def Save(self,transaction):
       try:
           if not (self.engine.dialect.has_table(self.engine, "TransactionsWithFraud")):
               transactionsWithFraud = self.CreateTableOfTransactionsWithFraud()
           else:
               transactionsWithFraud = Table('TransactionsWithFraud', self.metadata, autoload=True)

           insert = transactionsWithFraud.insert()
           colNamesWithValues = transaction.ColNamesWithValues() 
           insert.execute(colNamesWithValues)
           return True
       except Exception:
           print ("The exception - ",Exception)
           return False

    def CreateTableOfTransactionsWithFraud(self):
        transactionsWithFraud = Table('TransactionsWithFraud', self.metadata,
            Column("ItemNzd" , DECIMAL),
            Column("totalNzd" , DECIMAL),
            Column("voidedItemsNzd" , DECIMAL),
            Column("voidedLineNzd" , DECIMAL),
            Column("distinctItemNzd" , DECIMAL),
            Column("earlyMorning" ,Integer),
            Column("lateMorning" ,Integer),
            Column("lunch" ,Integer),
            Column("afternoon", Integer),
            Column("evening" ,Integer),
            Column("lateNight" ,Integer),
            Column("quantitiyItemsNzd" , DECIMAL),
            Column("RescanResult" ,Integer))
        transactionsWithFraud.create()
        return transactionsWithFraud


    



    
