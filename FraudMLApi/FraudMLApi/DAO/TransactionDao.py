import psycopg2
from sqlalchemy import *
from Model.Retail import Transaction

class TransactionDao():
   
    def __init__(self):
        engine = create_engine('postgresql://postgres:Qwe12345@localhost:5432/FRD')
        metadata = MetaData(engine)

    def Save(self,transaction):
       try: 
           if not (self.engine.dialect.has_table(self.engine, "TransactionsWithFraud")):
               CreateTableOfTransactionsWithFraud()
           transactionsWithFraud = Table('TransactionsWithFraud', metadata, autoload=True)
           insert = transactionsWithFraud.insert()
           insert.execute(transaction.ColNamesWithValues())
           return true
       except Exception:
           return false

    def CreateTableOfTransactionsWithFraud(self):
        transactionsWithFraud = Table('TransactionsWithFraud', metadata,
            Column("ItemNzd" , double),
            Column("totalNzd" , double),
            Column("voidedItemsNzd" , double),
            Column("voidedLineNzd" , double),
            Column("distinctItemNzd" , double),
            Column("Early Morning" ,Integer),
            Column("late morning" ,Integer),
            Column("lunch" ,Integer),
            Column("afternoon", Integer),
            Column("evening" ,Integer),
            Column("late night" ,Integer),
            Column("quantitiyItemsNzd" , double),
            Column("RescanResult" ,Integer),
        )
        transactionsWithFraud.create()

    



    
